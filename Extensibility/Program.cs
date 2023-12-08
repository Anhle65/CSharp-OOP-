using System;

namespace Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            var dbMigrator = new DbMigrator(new FileLogger("C:/Users/Hoang/Desktop/Studying_resources_myself/Tutorial(CSharp)/CSharp-OOP-/Extensibility/text.txt"));

            /* creat a new class and implement the ILogger interface
             -> change behavior of the application without change the code in the current class
            */
            dbMigrator.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}
