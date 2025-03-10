using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionDesign
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

    
        //Inherits the DbConnection properties and oveerides the Open and Close Method
        public override void Open()
        {
            Console.WriteLine("Opening SQL Server connection with connection string: " + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("Closing SQL Server connection.");
        }

    }

}
