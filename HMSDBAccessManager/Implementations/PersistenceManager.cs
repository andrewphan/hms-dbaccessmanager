using System;
using System.Collections.Generic;
using DBAccessManager.Implementations;
using DBAccessManager.Interfaces;
using DBAccessManager.SQL;
using HMSDBAccessManager.Implementations;

namespace DBAccessManager
{
    /// <summary>
    /// 
    /// </summary>
    public class PersistenceManager : IPersistenceManager
    {
        protected static DatabaseConfigurations Configurations { get; set; }
        protected DBConnectionInfo ConnectionInfo { get; set; }

        public PersistenceManager(string databaseName)
        {
            // Load database configuration mapping with databasename
            // Load DbAccessClass

        }

        public string DbmsName => this.ConnectionInfo.DbmsName;

        protected IDbAccess DatabaseFacade { get; set; }

        private void ReadDBConfiguraiont(string databaseName)
        {
            // IMplementation goes here
        }

        private void LoadDbAccessClass(string databaseName)
        {
            // Assign approprivate value to the facade
            this.DatabaseFacade.DatabaseName = databaseName;
            this.DatabaseFacade.Configuration = this.ConnectionInfo;
            this.DatabaseFacade.Prepare();
        }

        public int Delete(string entityName, KeyValueList deleteRecord)
        {
            // to call utilities class StatementGenerator to build
            // the query statement
            // then execute function ExecuteQuery
            throw new NotImplementedException();
        }

        public List<Dictionary<string, string>> ExecuteQuery(string query, KeyValueList parameters)
        {
            // return 
            throw new NotImplementedException();
        }

        public int Insert(string entityName, KeyValueList insertRecords)
        {
            // to call utilities class StatementGenerator to build
            // the query statement
            // then execute function ExecuteQuery
            throw new NotImplementedException();
        }

        public int Update(string entityName, KeyValueList updateRecords)
        {
            // to call utilities class StatementGenerator to build
            // the query statement
            // then execute function ExecuteQuery
            throw new NotImplementedException();
        }
    }

}
