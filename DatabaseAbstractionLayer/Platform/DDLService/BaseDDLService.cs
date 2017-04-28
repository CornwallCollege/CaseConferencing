/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OutSystems.HubEdition.Extensibility.Data.DatabaseObjects;
using OutSystems.HubEdition.Extensibility.Data.Platform.DatabaseObjects;
using OutSystems.HubEdition.Extensibility.Data.DMLService;
using OutSystems.HubEdition.Extensibility.Data.Platform.DMLService;
using OutSystems.RuntimeCommon;

namespace OutSystems.HubEdition.Extensibility.Data.Platform.DDLService {
    public abstract class BaseDDLService : IDDLService {
        private readonly IDictionary<string, string> generatedPrimaryKeyConstraintNames = new Dictionary<string, string>();

        protected IPlatformDMLIdentifiers Identifiers { get { return DatabaseServices.DMLService.Identifiers; } }
        protected IPlatformDatabaseObjectFactory ObjectFactory { get { return DatabaseServices.ObjectFactory; } }

        public IPlatformDatabaseServices DatabaseServices { get; private set; }

        protected BaseDDLService(IPlatformDatabaseServices databaseServices) {
            DatabaseServices = databaseServices;
        }

        public abstract bool CanAlterColumn(IPlatformTableSourceColumnInfo existingColumn, IPlatformTableSourceColumnInfo newColumn,
                                            out string errorMessage);

        //dvn: Both CanCreateColumn and CanCreateTable are only needed because we don't validate the model 
        public virtual bool CanCreateColumn(IPlatformTableSourceColumnInfo newColumn, out string errorMessage) {
            errorMessage = "";
            return true;
        }

        public virtual bool CanCreateTable(ITableSourceInfo newTable, ColumnDetails[] columns, out string errorMessage) {
            errorMessage = "";
            return true;
        }


        /// <summary>
        /// This method returns the SQL for the column definition to be used inside the create table and create column statements. 
        /// This implementation returns "escapedColumnName columnSQLDataType DEFAULT defaultValue NOT NULL"
        /// </summary>
        /// <param name="column">The column information for the column to create.</param>
        /// <param name="defaultValue">The default value for the column to create.</param>
        /// <returns>SQL for the column definition.</returns>
        protected virtual string GetColumnDefinition(IPlatformTableSourceColumnInfo column, string defaultValue) {
            return Identifiers.EscapeIdentifier(column.Name) + " " + column.DataType.SqlDataType 
                + (UseDefaultValue(column, defaultValue)? " DEFAULT " + defaultValue: String.Empty) 
                + (GetFinalMandatoryValue(column, defaultValue, column.IsMandatory)? " NOT": String.Empty) + " NULL";
        }


        /// <summary>
        /// Returns true if we can use the default value passed as argument in the column definition.
        /// </summary>
        /// <param name="column"></param>
        /// <param name="defaultValue">The default value for the column that we want to change to (tentatively).</param>
        /// <returns>True if we can use the default value, false otherwise.</returns>
        protected virtual bool UseDefaultValue(IPlatformTableSourceColumnInfo column, string defaultValue) {
            return !column.IsPrimaryKey && (defaultValue != null);
        }

        /// <summary>
        /// Returns the final mandatory value to use for the column definition. This can change depending on the column, 
        /// and depending on the default value.
        /// </summary>
        /// <param name="column">The column information.</param>
        /// <param name="defaultValue">The default value for the column.</param>
        /// <param name="mandatory">The mandatory value that we want to change to (tentatively).</param>
        /// <returns>The final mandatory value that we want to change.</returns>
        protected virtual bool GetFinalMandatoryValue(IPlatformTableSourceColumnInfo column, string defaultValue, bool mandatory) {
            if (UseDefaultValue(column, defaultValue) && (defaultValue == DatabaseServices.DMLService.DefaultValues.Null)) {
                return false; // Make sure we don't ask "DEFAULT NULL NOT NULL"
            }
            return mandatory;
        }

        /// <summary>
        /// This method returns the SQL for the primary key table constraint to be used inside the create table and create column statements.
        /// This implementation returns "CONSTRAINT escapedConstraintName PRIMARY KEY (escapedColumnNames)"
        /// </summary>
        /// <param name="constraintName">Name of the primary key constrain</param>
        /// <param name="column">The primary key column</param>
        /// <returns>SQL for the primary key table constraint.</returns>
        protected virtual string GetPrimaryKeyTableConstraint(string constraintName, IPlatformTableSourceColumnInfo column) {
            return string.Format("CONSTRAINT {0} PRIMARY KEY ({1})", Identifiers.EscapeIdentifier(constraintName), 
                Identifiers.EscapeIdentifier(column.Name));
        }

        /// <summary>
        /// This method returns the previously generated primary key constraint for a table.
        /// </summary>
        /// <param name="tableSource">Info about the table to which we want to return the previously generated primary key constraint name.</param>
        /// <returns>The primary key constraint name previously generated.</returns>
        protected string GetGeneratedPrimaryKeyConstraintNameForTable(ITableSourceInfo tableSource) {
            return generatedPrimaryKeyConstraintNames[tableSource.Name];
        }

        /// <summary>
        /// Returns the Tenant_Id column from the list of columns
        /// </summary>
        /// <param name="columns">columns to search for</param>
        /// <returns>The Tenant_Id column</returns>
        protected ITableSourceColumnInfo GetTenantFilterField(IEnumerable<IPlatformTableSourceColumnInfo> columns) {
            return columns.FirstOrDefault(col => col.Name.EqualsIgnoreCase("Tenant_Id"));
        }

        /// <summary>
        /// Returns a name that can be used as a primary key identifier name.
        /// </summary>
        /// <param name="tableName">Name of the table for which we want to create a primary key</param>
        /// <returns>A name that can be used as a sql identifier name</returns>
        protected string GetNewPrimaryKeyName(string tableName) {
            string primaryKeyName = ObjectFactory.GetNewPrimaryKeyName(DatabaseServices, tableName);
            generatedPrimaryKeyConstraintNames[tableName] = primaryKeyName;
            return primaryKeyName;
        }

        /// <summary>
        /// This method generates the query that will be used in the event trigger. 
        /// This assumes that the underlying database has the NULLIF and COALESCE functions.
        /// </summary>
        /// <param name="sql">StringBuilder that will receive the query SQL.</param>
        /// <param name="triggerTablePrimaryKeyColumn">Primary key column of the table associated with the trigger.</param>
        /// <param name="triggerTableEventColumns">Columns of the table associated with the trigger that fire events.</param>
        /// <param name="triggerTableForeignKeys">Foreign keys of the table associated with the trigger.</param>
        /// <param name="eventTable">Table source that stores the events for the table associated with the trigger. This table resides in the same database as the table where the trigger is defined.</param>
        /// <param name="eventQueueTable">Table source that stores the events to be fired by the platform.</param>
        /// <param name="triggerDataAccessor">SQL snippet to access the newly triggered data (new or updated line in trigger table).</param>
        /// <param name="needsTriggerDataAccessorInFrom">True if we need to include the <paramref name="triggerDataAccessor"/> in a from clause to access it in a query.</param>
        /// <param name="isUpdateVariableAccessor">SQL snippet to access the variable that is true if this trigger is an update.</param>
        protected virtual void FillEventTriggerQuery(StringBuilder sql, IPlatformTableSourceColumnInfo triggerTablePrimaryKeyColumn, 
                IEnumerable<IPlatformTableSourceColumnInfo> triggerTableEventColumns, IEnumerable<ITableSourceForeignKeyInfo> triggerTableForeignKeys, 
                ITableSourceInfo eventTable, ITableSourceInfo eventQueueTable, string triggerDataAccessor, bool needsTriggerDataAccessorInFrom, 
                string isUpdateVariableAccessor) {
            
            // We don't use the qualified name if both tables are in the same database, because this breaks database clone processes
            sql.AppendFormat(" INSERT INTO {0}", eventTable.Database.Equals(eventQueueTable.Database) ? eventQueueTable.Name : eventQueueTable.QualifiedName);            
            sql.Append("(ESPACE_ID, TENANT_ID, ACTIVITY_ID, PROCESS_DEF_ID, DATA_ID, ENQUEUE_TIME, ERROR_COUNT, NEXT_RUN)");
            var triggerTableEventColumnsList = triggerTableEventColumns.ToList();
            ITableSourceColumnInfo tenantFilterField = GetTenantFilterField(triggerTableEventColumnsList);
            string defaultTenantIdField = Identifiers.EscapeIdentifier("_TENANT_ID");

            string tenantIdInSelect = (tenantFilterField == null)? defaultTenantIdField: 
                "COALESCE(" + defaultTenantIdField + ", " + triggerDataAccessor + "." 
                + Identifiers.EscapeIdentifier(tenantFilterField.Name) + ")";

            IDMLService dmlService = DatabaseServices.DMLService;
            string dataIdInSelect = String.Format("{0}.{1}", triggerDataAccessor, Identifiers.EscapeIdentifier(triggerTablePrimaryKeyColumn.Name));
            
            dataIdInSelect = (triggerTablePrimaryKeyColumn.DataType.Type == DBDataType.INTEGER)? dmlService.Functions.IntegerToText(dataIdInSelect): 
                dataIdInSelect;

            sql.AppendFormat(" (SELECT {0}, {1}, {2}, {3}, {4}, GETDATE(), 0, GETDATE() FROM {5} evt{6}", 
                Identifiers.EscapeIdentifier("_ESPACE_ID"), tenantIdInSelect, Identifiers.EscapeIdentifier("_ACTIVITY_ID"), 
                Identifiers.EscapeIdentifier("_PROCESS_DEF_ID"), dataIdInSelect, Identifiers.EscapeIdentifier(eventTable.Name), 
                needsTriggerDataAccessorInFrom? (", " + triggerDataAccessor): String.Empty);
            
            sql.Append(" WHERE ");
            IDMLOperators operators = dmlService.Operators;
            string whereClause = operators.Equal("evt." + Identifiers.EscapeIdentifier("_IS_UPDATE"), isUpdateVariableAccessor);
            var triggerTableColumnNames = new HashSet<string>(triggerTableForeignKeys.Select(fk => fk.ColumnName.ToUpperInvariant()));
            
            foreach (var column in triggerTableEventColumnsList) {
                string insertedFieldSnippet = triggerDataAccessor + "." + Identifiers.EscapeIdentifier(column.Name);
                string evtFieldSnippet = "evt." + Identifiers.EscapeIdentifier(column.Name);
                string coalesceSnippet = "{0}";
                string nullIfSnippet = "{0}";

                if (triggerTableColumnNames.Contains(column.Name.ToUpperInvariant()) || (column == tenantFilterField)) {
                    switch (column.DataType.Type) {
                        case DBDataType.INTEGER:
                            nullIfSnippet = "NULLIF({0}, " + GetDefaultValue(DBDataType.INTEGER) + ")";
                            coalesceSnippet = "COALESCE({0}, " + GetDefaultValue(DBDataType.INTEGER) + ")";
                            break;
                        case DBDataType.TEXT:
                            nullIfSnippet = "NULLIF({0}, " + GetDefaultValue(DBDataType.TEXT) + ")";
                            coalesceSnippet = "COALESCE({0}, " + GetDefaultValue(DBDataType.TEXT) + ")";
                            break;
                    }
                }

                string condition = operators.Or(operators.IsNull(nullIfSnippet.F(evtFieldSnippet)), 
                    operators.Equal(evtFieldSnippet, coalesceSnippet.F(insertedFieldSnippet)));

                whereClause = operators.And(whereClause, "(" + condition + ")");                
            }

            sql.Append(whereClause);
            sql.Append(")");
        }
        
        public abstract string GetDefaultValue(DBDataType type);

        /// <summary>
        /// This method generates the SQL to create a new table.
        /// This implementation returns the statement "CREATE TABLE FullyQualifiedTableName (columnsDefinitionStatements, primaryKeyStatement)"
        /// </summary>
        /// <param name="newTable">Info about the table to create.</param>
        /// <param name="columns">The columns information for the table to create along with the default values. 
        ///     Note that some of them may be primary keys, as indicated on the IsPrimaryKey property. 
        ///     This will lead to the creation of Primary Key Constraints. 
        ///     Also note that a column could be an autonumber column, there's no need to call the AlterColumnChangeAutoNumber after.</param>
        /// <returns>SQL statements to create the table.</returns>
        public virtual IEnumerable<string> CreateTable(ITableSourceInfo newTable, params ColumnDetails[] columns) {
            IEnumerable<string> columnDefinitions = columns.Select(col => GetColumnDefinition(col.Column, col.DefaultValue));
            IPlatformTableSourceColumnInfo primaryKey = columns.Select(col => col.Column).SingleOrDefault(col => col.IsPrimaryKey);

            string primaryKeyStatement = primaryKey == null ? string.Empty: 
                GetPrimaryKeyTableConstraint(GetNewPrimaryKeyName(newTable.Name), primaryKey);

            yield return String.Format("CREATE TABLE {0} ({1}{2})", newTable.QualifiedName, 
                columnDefinitions.StrCat(", "), primaryKeyStatement.IsNullOrEmpty() ? "" : ", " + primaryKeyStatement);
        }

        /// <summary>
        /// This method generates the SQL to create a new index.
        /// This implementation returns the statement "CREATE UNIQUE INDEX FullyQualifiedIndexName ON FullyQualifiedTableName (escapedColumnNames)"
        /// </summary>
        /// <param name="newIndex">Info about the index to create.</param>
        /// <returns>SQL statements to create the index.</returns>
        public virtual IEnumerable<string> CreateIndex(IPlatformTableSourceIndexInfo newIndex) {                                   
            string createStatement = String.Format("CREATE {0}INDEX {1} ON {2} ({3})", newIndex.IsUnique? "UNIQUE " : "", 
                Identifiers.EscapeAndQualifyIdentifier(newIndex.TableSource.Database, newIndex.Name), newIndex.TableSource.QualifiedName,
                newIndex.Columns.Select(col => Identifiers.EscapeIdentifier(col.Name)).StrCat(","));
            
            return createStatement.ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to drop an index previously obtained through the IIntrospectionService API.
        /// This implementation returns "DROP INDEX FullyQualifiedIndexName"
        /// </summary>
        /// <param name="existingIndex">Info about the index to drop.</param>
        /// <returns>SQL statements to drop the index.</returns>
        public virtual IEnumerable<string> DropIndex(IPlatformTableSourceIndexInfo existingIndex) {
            yield return String.Format("DROP INDEX {0}",
                Identifiers.EscapeAndQualifyIdentifier(existingIndex.TableSource.Database, existingIndex.Name));
        }

        /// <summary>
        /// This method generates the SQL to create a new foreign key.
        /// This implementation returns
        /// ALTER TABLE FullyQualifiedTableName ADD CONSTRAINT escapedConstraintName FOREIGN KEY (escapedForeignKeyColumnNames) REFERENCES FullyQualifiedForeignTableName (escapedForeignColumnNames) ON DELETE CASCADE
        /// </summary>
        /// <param name="newForeignKey">Info about the foreign key to create.</param>
        /// <returns>SQL statements to create the foreign key.</returns>
        public virtual IEnumerable<string> CreateForeignKey(ITableSourceForeignKeyInfo newForeignKey) {            
            yield return String.Format("ALTER TABLE {0} ADD CONSTRAINT {1} FOREIGN KEY ({2}) REFERENCES {3} ({4}){5}",
                newForeignKey.TableSource.QualifiedName, Identifiers.EscapeIdentifier(newForeignKey.Name), 
                Identifiers.EscapeIdentifier(newForeignKey.ColumnName), newForeignKey.ReferencedTableSource.QualifiedName,
                Identifiers.EscapeIdentifier(newForeignKey.ReferencedColumnName), newForeignKey.IsCascadeDelete? " ON DELETE CASCADE": String.Empty);
        }

        public abstract IEnumerable<string> CreateEventTrigger(IPlatformTableSourceEventTriggerInfo newTrigger, IPlatformTableSourceColumnInfo triggerTablePrimaryKeyColumn, IEnumerable<IPlatformTableSourceColumnInfo> triggerTableEventColumns, IEnumerable<ITableSourceForeignKeyInfo> triggerTableForeignKeys, ITableSourceInfo eventTable, ITableSourceInfo eventQueueTable);

        /// <summary>
        /// This method generates the SQL to create a new primary key.
        /// This implementation returns "ALTER TABLE FullyQualifiedTableName ADD primaryKeyStatement"
        /// </summary>
        /// <param name="existingTable">Info about the table to create a new primary key. This info is obtained through the IIntrospectionServiceAPI</param>
        /// <param name="column">Info about the column that composes the primary key.</param>
        /// <returns>SQL statements to create the primary key.</returns>
        protected virtual IEnumerable<string> CreatePrimaryKey(ITableSourceInfo existingTable, IPlatformTableSourceColumnInfo column) {
            string constraintName = GetNewPrimaryKeyName(existingTable.Name);
            
            string alterTableStatement = String.Format("ALTER TABLE {0} ADD {1}", existingTable.QualifiedName, 
                GetPrimaryKeyTableConstraint(constraintName, column));

            return alterTableStatement.ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to create a new column.
        /// This implementation returns "ALTER TABLE FullyQualifiedTableName ADD columnsDefinitionStatement"
        /// and adds the SQL of the CreatePrimaryKey if the column is primary key.
        /// </summary>
        /// <param name="newColumn">Info about the column to create.</param>
        /// <param name="defaultValue">Column default value. It could be empty.</param>
        /// <returns>SQL statements to create the column.</returns>
        public virtual IEnumerable<string> CreateColumn(IPlatformTableSourceColumnInfo newColumn, string defaultValue) {
            string addColumnStatement = String.Format("ALTER TABLE {0} ADD {1}", newColumn.TableSource.QualifiedName, 
                GetColumnDefinition(newColumn, defaultValue));

            var result = new List<string> { addColumnStatement };

            if (newColumn.IsPrimaryKey) {
                result.AddRange(CreatePrimaryKey(newColumn.TableSource, newColumn));
            }

            return result;
        }

        public abstract IEnumerable<string> AlterColumn(IPlatformTableSourceColumnInfo existingColumn,
                                                       IPlatformTableSourceColumnInfo newColumn, string defaultValue);

        /// <summary>
        /// This method generates the SQL to drop a table previously obtained through the IIntrospectionService API.
        /// This implementation always returns "DROP TABLE FullyQualifiedTableName"
        /// </summary>
        /// <param name="existingTable">Info about the table to drop.</param>
        /// <returns>SQL statements to drop the table.</returns>
        public virtual IEnumerable<string> DropTable(ITableSourceInfo existingTable) {
            return String.Format("DROP TABLE {0}", existingTable.QualifiedName).ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to drop a foreign key previously obtained through the IIntrospectionService API.
        /// This implementation returns "ALTER TABLE FullyQualifiedTableName DROP CONSTRAINT escapedConstraintName"
        /// </summary>
        /// <param name="existingForeignKey">Info about the foreign key to drop.</param>
        /// <returns>SQL statements to drop the foreign key.</returns>
        public virtual IEnumerable<string> DropForeignKey(ITableSourceForeignKeyInfo existingForeignKey) {
            string statement = String.Format("ALTER TABLE {0} DROP CONSTRAINT {1}", existingForeignKey.TableSource.QualifiedName, 
                Identifiers.EscapeIdentifier(existingForeignKey.Name));

            return statement.ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to drop a trigger previously obtained through the IIntrospectionService API.
        /// This implementation returns "DROP TRIGGER FullyQualifiedTriggerName"
        /// </summary>
        /// <param name="existingTrigger">Info about the trigger to drop.</param>
        /// <returns>SQL statements to drop the trigger.</returns>
        public virtual IEnumerable<string> DropEventTrigger(IPlatformTableSourceEventTriggerInfo existingTrigger) {
            string statement = 
                String.Format("DROP TRIGGER {0}", Identifiers.EscapeAndQualifyIdentifier(existingTrigger.TableSource.Database, existingTrigger.Name));

            return statement.ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to drop a column previously obtained through the IIntrospectionService API.
        /// This implementation returns "ALTER TABLE FullyQualifiedTableName DROP COLUMN escapedColumnName"
        /// </summary>
        /// <param name="existingColumn">Info about the column to drop.</param>
        /// <returns>SQL statements to drop the column.</returns>
        public virtual IEnumerable<string> DropColumn(IPlatformTableSourceColumnInfo existingColumn) {
            return String.Format("ALTER TABLE {0} DROP COLUMN {1}", existingColumn.TableSource.QualifiedName, 
                Identifiers.EscapeIdentifier(existingColumn.Name)).ToEnumerable();
        }

        /// <summary>
        /// Generates a message stating that a given column (<paramref name="existingColumn"/>) cannot be changed to another type, defined by the <paramref name="newColumn"/>.
        /// </summary>
        /// <param name="existingColumn">Existing column to be changed</param>
        /// <param name="newColumn">New version of the column, based on the model</param>
        /// <param name="isExistingColumnImmutable">True if the existing column cannot be changed into any other type, False if some conversions are allowed</param>
        /// <returns>A user-friendly error message</returns>
        protected static string GetColumnCannotBeChangedMessage(IPlatformTableSourceColumnInfo existingColumn, IPlatformTableSourceColumnInfo newColumn, bool isExistingColumnImmutable) {
            return GetColumnCannotBeChangedMessage(existingColumn.TableSource.Name, existingColumn.Name, existingColumn.DataType.SqlDataType, existingColumn.DataType.Type.ToText(), newColumn.DataType.SqlDataType, newColumn.DataType.Type.ToText(), isExistingColumnImmutable);
        }

        /// <summary>
        /// Generates a message stating that a given column (<paramref name="columnName"/>) cannot be changed to another type (<paramref name="newColumnType"/>)
        /// </summary>
        /// <param name="tableName">Name of the existing table that owns the column</param>
        /// <param name="columnName">Name of the existing column to be changed</param>
        /// <param name="existingColumnDbType">Database type of the existing column (e.g. VARCHAR)</param>
        /// <param name="existingColumnType">Model type of the existing column (e.g. Text)</param>
        /// <param name="newColumnDbType">New database type for the column (e.g. VARCHAR)</param>
        /// <param name="newColumnType">New model type for the column</param>
        /// <param name="isExistingColumnImmutable">True if the existing column cannot be changed into any other type, False if some conversions are allowed</param>
        /// <returns>A user-friendly error message</returns>
        protected static string GetColumnCannotBeChangedMessage(string tableName, string columnName, string existingColumnDbType, string existingColumnType, string newColumnDbType, string newColumnType, bool isExistingColumnImmutable) {
            return string.Format(
                "Column '{0}.{1}' exists in database as {2} ({3}) but the new version is defined as {4} ({5}). Database {3} columns can not be changed{6}.",
                tableName, columnName, existingColumnType, existingColumnDbType, newColumnType, newColumnDbType,
                isExistingColumnImmutable ? "" : " to " + newColumnDbType);
        }

        /// <summary>
        /// This method generates the SQL to create a new view. If already exists a view with the same name it should be replaced by the new one.
        /// This implementation returns "CREATE OR REPLACE VIEW FullyQualifiedViewName AS viewSQL"
        /// </summary>
        /// <param name="newView">Info about the view we want to create.</param>
        /// <param name="viewSQL">SQL query that defines the view contents.</param>
        /// <param name="withCheckOption">true if the INSERT and UPDATE operations performed over the view should be constrained only to the rows referenced by the view</param>
        /// <returns>SQL statements to create the view.</returns>
        public virtual IEnumerable<string> CreateOrReplaceView(ITableSourceInfo newView, string viewSQL, bool withCheckOption) {
            return String.Format("CREATE OR REPLACE VIEW {0} AS {1}{2}", newView.QualifiedName, viewSQL, withCheckOption ? " WITH CHECK OPTION" : "").ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to grant permissions on a table source to a user.
        /// This implementation returns "GRANT permissions ON FullyQualifiedTableName TO userName"
        /// </summary>
        /// <param name="existingTableSource">Info about the table or view which we want to grant permissions on.</param>
        /// <param name="username">User to grant permissions.</param>
        /// <param name="permissions">Permissions to grant to the user.</param>
        /// <returns>SQL statements to grant permissions.</returns>
        public virtual IEnumerable<string> GrantPermissions(ITableSourceInfo existingTableSource, string username, Permissions permissions) {
            IList<string> permissionList = new List<string>();
            if (permissions.HasPermissions(Permissions.Select)) {
                permissionList.Add("SELECT");
            }
            if (permissions.HasPermissions(Permissions.Insert)) {
                permissionList.Add("INSERT");
            }
            if (permissions.HasPermissions(Permissions.Update)) {
                permissionList.Add("UPDATE");
            }
            if (permissions.HasPermissions(Permissions.Delete)) {
                permissionList.Add("DELETE");
            }

            string statement = String.Format("GRANT {0} ON {1} TO {2}", permissionList.StrCat(","), existingTableSource.QualifiedName, 
                Identifiers.EscapeIdentifier(username));

            return statement.ToEnumerable();
        }

        protected virtual string ChangeTriggersStatus(ITableSourceInfo tableSource, bool enable) {
            return string.Format("ALTER TABLE {0} {1} ALL TRIGGERS",
                tableSource.QualifiedName,
                (enable ? "ENABLE" : "DISABLE"));
        }

        /// <summary>
        /// This method generates the SQL to enable all the triggers for an existing table source.
        /// This implementation returns "ALTER TABLE TableQualifiedName ENABLE ALL TRIGGERS"
        /// </summary>
        /// <param name="existingTableSource">Info about the table source which we want to enable the triggers.</param>
        /// <returns>SQL statements to enable the triggers.</returns>
        public virtual IEnumerable<string> EnableTriggers(ITableSourceInfo existingTableSource) {
            return ChangeTriggersStatus(existingTableSource, /*enable*/true).ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to disable all the triggers for an existing table source.
        /// This implementation returns "ALTER TABLE TableQualifiedName DISABLE ALL TRIGGERS"
        /// </summary>
        /// <param name="existingTableSource">Info about the table source which we want to disable the triggers.</param>
        /// <returns>SQL statements to disable the triggers.</returns>
        public virtual IEnumerable<string> DisableTriggers(ITableSourceInfo existingTableSource) {
            return ChangeTriggersStatus(existingTableSource, /*enable*/false).ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to enable the auto-number behavior for an existing table source.
        /// This implementation returns an empty statement.
        /// </summary>
        /// <param name="existingTableSource">Info about the table source which we want to enable the auto-number.</param>
        /// <returns>SQL statements to enable the auto-number.</returns>
        public virtual IEnumerable<string> EnableAutoNumber(ITableSourceInfo existingTableSource) {
            return string.Empty.ToEnumerable();
        }

        /// <summary>
        /// This method generates the SQL to disable the auto-number behavior for an existing table source.
        /// This implementation returns an empty statement.
        /// </summary>
        /// <param name="existingTableSource">Info about the table source which we want to disable the auto-number.</param>
        /// <returns>SQL statements to disable the auto-number.</returns>
        public virtual IEnumerable<string> DisableAutoNumber(ITableSourceInfo existingTableSource) {
            return string.Empty.ToEnumerable();
        }
    }
}
