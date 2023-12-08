using System;

namespace Exercise_Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }
        public override void Opening()
        {
            Console.WriteLine("Opening Oracle connection!");
        }
        public override void Closing()
        {
            Console.WriteLine("Closing Oracle connection!");
        }
    }
}
