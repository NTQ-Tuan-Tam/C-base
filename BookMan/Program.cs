using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan
{
    using Controller;
    internal class Program
    {
       private static void Main(string[] args)
        {
            BookController controller = new BookController();
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
                    default:
                        Console.WriteLine("Unknow command");
                        break;
                }
            }
        
        }
    }
}
