using System.Security.AccessControl;

namespace RecapDemo2
{
    class Program
    {
        static void Main()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Logger = new DatabseLogger();
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
     {
         public ILogger Logger { get; set; }
         public void Add()
         {
             Logger.Log();
             Console.WriteLine("Customer added!");
         }
     }
    class DatabseLogger : ILogger
        {
        public void Log()
        {
            Console.WriteLine("Logged to database!");
        }
        }
    class FileLogger : ILogger
        {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
        }
    class SmsLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to sms");
        }
    }

    interface ILogger
        {
            void Log();
        }
 }