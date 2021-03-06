/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

namespace OutSystems.HubEdition.Extensibility.Data.DatabaseObjects {

    /// <summary>
    /// Contains information about a table source foreign key.
    /// </summary>
    public interface ITableSourceForeignKeyInfo {

        /// <summary>
        /// Table source that owns the foreign key.
        /// </summary>
        ITableSourceInfo TableSource { get; }

        /// <summary>
        /// Name that identifies the foreign key constraint.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Name of the column.
        /// </summary>
        string ColumnName { get; }

        /// <summary>
        /// Table source that owns the referenced column.
        /// </summary>
        ITableSourceInfo ReferencedTableSource { get; }

        /// <summary>
        /// Name of the referenced column.
        /// </summary>
        string ReferencedColumnName { get; }

        /// <summary>
        /// Returns True if the delete rule of the foreign key is CASCADE DELETE.
        /// </summary>
        bool IsCascadeDelete { get; }
    }
}
