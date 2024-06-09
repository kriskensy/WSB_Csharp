using System;

namespace Lab_04_homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailLogger emailLogger = new EmailLogger();

            emailLogger.Log("emailLogger");
            ((ILogger)emailLogger).Log("ILogger");
            ((IEmailSender)emailLogger).Log("IEmailSender");
        }
    }

    public interface ILogger
    {
        void Log(string message);
    }

    public interface IEmailSender
    {
        void Log(string message);
    }

    public class EmailLogger : ILogger, IEmailSender
    {
        void ILogger.Log(string message)
        {
            Console.WriteLine(message);
        }

        void IEmailSender.Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}