using System;
using System.Data.Common;

namespace HMSDBAccessManager
{
    /// <summary>
    /// class to instantiate the approriate connection provider by using DBProviderFactory
    /// </summary>
    public class HMSDatabaseConnection
    {
        private DbProviderFactory _providerFactory;
        private string _databaseName;
        public HMSDatabaseConnection(string databaseName)
        {
            this._databaseName = databaseName;
        }

        public HMSDatabaseConnection(string databaseName, Type providerFactory)
        {
            this._providerFactory = DbProviderFactories.GetFactory(providerFactory.Namespace);
            this._databaseName = databaseName;
        }

        public HMSDatabaseConnection GetInstance<T>(string databaseName)
        {
            return new HMSDatabaseConnection(databaseName, typeof(T));
        }
    }
}
