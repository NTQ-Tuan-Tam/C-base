using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan
{
    using Controller;
    using DataService;
    internal class Program
    {
        private static void Main(string[] args) { 
            SimpleDataAccess context = new SimpleDataAccess();
            BookController controller = new BookController(context);
            while (true)
            {
                Console.Write("Request: > ");
                string Request = Console.ReadLine();
                switch (Request.ToLower())
                {
                    case "single":
                        controller.Single(1);
                        break;
                    case "create":
                        controller.Create();
                        break;
                    case "update":
                        controller.Update(1);
                        break;
                    case "list":
                        controller.List();
                        break;
                    
                    default:
                        Console.WriteLine("Unknow command");
                        break;
                }
            }
        
        }
    }
}
