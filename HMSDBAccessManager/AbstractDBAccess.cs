using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using DBAccessManager.Implementations;
using DBAccessManager.Interfaces;
using DBAccessManager.SQL;
using HMSDBAccessManager.Implementations;

namespace DBAccessManager
{
    public abstract class AbstractDBAccess : IDbAccess
    {
        public string DBMSName => this.Configuration.DbmsName; // read from configuration class
        private string _databaseName;
        public string DatabaseName
        {
            get
            {
                return this._databaseName;
            }
            set
            {
                this._databaseName = value;
            }
        }

        public DBConnectionInfo Configuration { get;set; }

        public string DbmsName => this.Configuration.DbmsName;

        // we also need a factory to create a database connection to a specific dbms
        // private HMSDatabaseConnection ConnectionFactory {get;set;}
        public AbstractDBAccess()
        {
        }

        public virtual void Prepare() {
            if (this.DatabaseName != null)
            {
                // Implementation goes here...
                // we will create HMSDatabaseConnection class for database by initialize a signleton instance
                // GetInstance<Of SqlClientFactory> or GetInstance<Of OracleClientFactory> passing value DatabaseName
                // eg. this.ConnectionFactory = HMSDatabaseConnection.GetInstance<OracleClientFactory>(this.DatabaseName);
            }
        }

        public int Insert(string entityName, KeyValueList insertRecords)
        {
            throw new NotImplementedException();
        }

        public int Update(string entityName, KeyValueList updateRecords)
        {
            throw new NotImplementedException();
        }

        public int Delete(string entityName, KeyValueList deleteRecord)
        {
            throw new NotImplementedException();
        }

        public List<Dictionary<string, string>> ExecuteQuery(string query, KeyValueList parameters)
        {
            throw new NotImplementedException();
        }
    }
}
