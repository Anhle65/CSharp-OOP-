using System;
using System.Collections;

namespace WorkflowEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.Add(new Activity());
            workflow.Add(new SendSMS());
            workflow.Add(new Video());
            var engine = new WorkflowEngine();
            engine.Run(workflow);
            Console.WriteLine("Hello World!");
        }
    }
}
