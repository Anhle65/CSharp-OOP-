using System;

namespace WorkflowEngine
{
    internal class Video : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Working with videos...");
        }
    }
}