namespace DatabaseConnectionDesign
{
    class DatabaseConnectionDesign
    {
        static void Main(string[] args)
        {
            //var sqlConnection = new SqlConnection("SQL_Connection_String");
            //sqlConnection.Open();
            //sqlConnection.Close();

            //var oracleConnection = new OracleConnection("Oracle_Connection_String");
            //oracleConnection.Open();
            //oracleConnection.Close();


            var sqlConnection = new SqlConnection("SQL_Connection_String");
            var dbCommand = new DbCommand(sqlConnection, "SELECT * FROM Users");
            dbCommand.Execute();

            var oracleConnection = new OracleConnection("Oracle_Connection_String");
            var dbCommand2 = new DbCommand(oracleConnection, "SELECT * FROM Employees");
            dbCommand2.Execute();








        }








    }
}
