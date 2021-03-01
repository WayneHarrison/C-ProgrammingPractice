using System;

namespace PolymorphismExercises
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString, TimeSpan TimeOut) : base(connectionString, TimeOut)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Database is open.");
        }

        public override void Close()
        {
            Console.WriteLine("Database is closed.");
        }
    }
}