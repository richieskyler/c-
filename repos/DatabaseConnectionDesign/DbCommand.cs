using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseConnectionDesign
{
    public class DbCommand
    {
        private DbConnection _connection;
        private string _instruction;

        // Constructor to initialize the connection and instruction
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
            {
                throw new ArgumentException("Connection cannot be null.");
            }
            if (string.IsNullOrEmpty(instruction))
            {
                throw new ArgumentException("Instruction cannot be null or empty.");
            }

            _connection = connection;
            _instruction = instruction;
        }

        // Execute method to run the command
        public void Execute()
        {
            _connection.Open();
            Console.WriteLine("Executing instruction: " + _instruction);
            _connection.Close();
        }


    }
}