using System;
using System.Collections.Generic;
using DBAccessManager.Interfaces;
using HMSDBAccessManager.Implementations;

namespace DBAccessManager.Implementations
{
    public class DatabaseConfigurations 
    {
        // Reading from application configuraiton.
        // The file app.config could be moved to another location for
        // end user or support team to configure
        public IDictionary<string, DBConnectionInfo> Configurations { get; set; }

        public string DbmsName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public DatabaseConfigurations()
        {
        }

        public DBConnectionInfo GetDatabaseInfoByDBName(string databaseName)
        {
            return this.Configurations[databaseName];
        }
    }
}
