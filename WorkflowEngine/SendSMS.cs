using System;

namespace WorkflowEngine
{
    internal class SendSMS : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending sms ...");
        }
    }
}