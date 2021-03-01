using System;

namespace PolymorphismExercises
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        private readonly TimeSpan _timeout;

        public string ConnectionString => _connectionString;
        public TimeSpan TimeOut => _timeout;

        public DbConnection(string connectionString, TimeSpan timeout)
        {
            _connectionString = connectionString;
            _timeout = timeout;
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException();

            
        }

        public abstract void Open();
        public abstract void Close();
    }
}