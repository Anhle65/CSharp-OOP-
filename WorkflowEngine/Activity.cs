using System;
using System.ComponentModel;

namespace WorkflowEngine
{
    public class Activity : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Operating the task ...");
        }
    }
}
