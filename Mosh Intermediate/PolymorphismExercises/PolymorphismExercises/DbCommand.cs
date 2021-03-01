using System;
using System.Data.Common;

namespace PolymorphismExercises
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        public DbConnection DbConnection => _dbConnection;

        private readonly string _instruction;

        internal DbCommand(string instruction, DbConnection dbConnection)
        {
            _instruction = instruction;
            _dbConnection = dbConnection;
            if (string.IsNullOrEmpty(_instruction))
                throw new ArgumentNullException();

            execute();

            
        }

        public void execute()
        {
            DbConnection.Open();
            Console.WriteLine("Running instruction");
            DbConnection.Close();
        }
    }
}