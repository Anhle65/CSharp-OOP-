using System;

namespace Exercise_Polymorphism
{
    public class DbCommand
    {
        private string _instruction;
        private readonly DbConnection _connection;
        public DbCommand(DbConnection connect, string instruction)
        {   
            _connection = connect;
            if (connect == null)
            {
                throw new ArgumentNullException("It should be connect to a valid database");
            }

            _instruction = instruction;
            if (instruction == null)
            {
                throw new ArgumentNullException("The instruction must not be a null or empty string");
            }
        }
        public void Executable()
        {
            _connection.Opening();
            Console.WriteLine($"Executing instruction: {_instruction}");
            _connection.Closing();
        }
    }
}
