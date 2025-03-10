using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionDesign
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }


        //Inherits the DbConnection properties and oveerides the Open and Close Method
        public override void Open()
        {
            Console.WriteLine("Opening Oracle Server connection with connection string: " + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Closing Oracle Server connection.");
        }
    }
}
