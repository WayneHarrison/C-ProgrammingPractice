using System;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace PolymorphismExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var sqlConn = new SqlConnection("Connection String", new TimeSpan(0,0,10,0));
            new DbCommand("Connect", sqlConn);
            var oracleConn = new OracleConnection("Connection String", new TimeSpan(0,0,10,0));
            new DbCommand("Connect", oracleConn);
        }
    }
}
