/* 
 This source code (the "Generated Software") is generated by the OutSystems Platform 
 and is licensed by OutSystems (http://www.outsystems.com) to You solely for testing and evaluation 
 purposes, unless You and OutSystems have executed a specific agreement covering the use terms and 
 conditions of the Generated Software, in which case such agreement shall apply. 
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using OutSystems.RuntimeCommon;

namespace OutSystems.RuntimePublic.Db {
    /// <summary>
    /// Represents the query parameters associated with a command.
    /// </summary>
    public sealed class DataParameter {

        private OutSystems.Internal.Db.DataParameter parameter;

        internal DataParameter(OutSystems.Internal.Db.DataParameter parameter) {
            if (parameter == null) {
                throw new ArgumentNullException("Parameter cannot be initialized with null.");
            }
            this.parameter = parameter;
        }

        /// <summary>
        /// Returns the native parameter object used by the stack in which the application is running.
        /// </summary>
        /// <returns>The native parameter object.</returns>
        public IDbDataParameter GetDriverParameter() {
            return parameter.DriverParameter;
        }

        /// <summary>
        /// Gets or sets the parameter value.
        /// </summary>
        public object Value {
            get { return parameter.Value; }
            set { parameter.SetValue(DbType, value, true); }
        }

        /// <summary>
        /// Gets or sets the database type.
        /// </summary>
        public DbType DbType {
            get { return parameter.DbType; }
            set { parameter.SetValue(value, Value, true); }
        }

        /// <summary>
        /// Sets the size of the parameter.
        /// </summary>
        public int Size {
            set { parameter.Size = value; }
            get { return parameter.Size; }
        }
    }
}
