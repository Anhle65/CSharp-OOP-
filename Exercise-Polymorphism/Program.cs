using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercise_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            try
            {
                DbConnection sqlconnection = new SqlConnection();
                DbCommand sqlcommand = new DbCommand(sqlconnection, "SELECT FROM anything");
                sqlcommand.Executable();
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
