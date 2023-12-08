using System;

namespace WorkflowEngine
{
    internal class SendMail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email ...");
        }
    }
}