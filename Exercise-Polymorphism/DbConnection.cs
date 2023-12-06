using System;

namespace Exercise_Polymorphism
{
    public abstract class DbConnection
    {
        private string _connectionString;
        public TimeSpan Timeout { get; set; }
        public DbConnection()
        {

        }
        public DbConnection(string ConnectionString)
        {
            _connectionString = ConnectionString;
            if (_connectionString == null || _connectionString == " ")
            {
                throw new ArgumentNullException("The connection can't be null or an empty string");
            }
        }
        public abstract void Opening();
        public abstract void Closing();
    }
}
