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
            controller.Single(0);
            Console.ReadKey();
        
        }
    }
}
