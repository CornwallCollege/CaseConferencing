/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

namespace OutSystems.HubEdition.Extensibility.Data.DatabaseObjects {

    /// <summary>
    /// Contains information about a table source column.
    /// </summary>
    public interface ITableSourceColumnInfo {

        /// <summary>
        /// Table source that owns the column.
        /// </summary>
        ITableSourceInfo TableSource { get; }

        /// <summary>
        /// Name that identifies the column.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Data type of the values stored in the column.
        /// </summary>
        IDataTypeInfo DataType { get; }

        /// <summary>
        /// Returns true if the column must have a value assigned to it (NOT NULL), or false if it is nullable.
        /// </summary>
        bool IsMandatory { get; }

        /// <summary>
        /// Returns true if the column is part of the table source's primary key, or false otherwise.
        /// </summary>
        bool IsPrimaryKey { get; }

        /// <summary>
        /// Returns true if the column value is generated automatically when a row is inserted (e.g. sequential numbers).
        /// </summary>
        bool IsAutoGenerated { get; }

    }
}
