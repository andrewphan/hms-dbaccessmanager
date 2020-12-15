using System;
namespace HMSDBAccessManager.Implementations
{
    public class DBConnectionInfo
    {
        public string DbmsName { get; set; }
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }

        /// <summary>
        /// SQLite Database File name
        /// </summary>
        public string DbFileName { get; set; }

        public DBConnectionInfo()
        {
        }
    }
}
