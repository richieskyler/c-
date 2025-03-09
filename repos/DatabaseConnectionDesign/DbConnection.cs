using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionDesign
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        //Constructor to intitialize the connectionString
        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new ArgumentException("Connection string cannot be empty");
            }

            ConnectionString = connectionString;
        }

        //Abstract method to be determined by the dervied class
        public abstract void Open();
        public abstract void Close();

    }
}
