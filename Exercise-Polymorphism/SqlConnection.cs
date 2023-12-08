using System;

namespace Exercise_Polymorphism
{
    public class SqlConnection : DbConnection
    {
        //public SqlConnection(string connectionString) : base(connectionString) { }
        public override void Opening()
        {
            Console.WriteLine("Opening SQL connection!");
        }
        public override void Closing()
        {
            Console.WriteLine("Closing SQL connection!");
        }
    }
}
