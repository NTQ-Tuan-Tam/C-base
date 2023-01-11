using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.Views
{
    internal class BookCreateView
    {
        public BookCreateView()
        {

        }
        public void Render()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Create a new book");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Title : ");
            Console.ResetColor();
            string title = Console.ReadLine(); // đọc 1 dòng và lưu vào biến tile 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Authors: ");
            Console.ResetColor();
            string authors = Console.ReadLine();// đọc 1 dòng và lưu vào biến authors
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Publisher: ");
            Console.ResetColor();
            string publisher = Console.ReadLine();  // đọc 1 dòng và lưu vào biến Publisher
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Year: ");
            Console.ResetColor();
            string yearString = Console.ReadLine(); // đọc 1 dòng và lưu vào biế yearString 
            int year = int.Parse(yearString); // chuyển đổi số sang số nguyên
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Edition: ");
            Console.ResetColor();
            string editistionString= Console.ReadLine();
            int edition = int.Parse(editistionString);
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.Write("Reading [y/n]: ");
            Console.ResetColor();
            ConsoleKeyInfo readingChar = Console.ReadKey(); // đọc 1 ký tự và lưu vào biến yearString 
            bool reading = readingChar.KeyChar == 'y' || readingChar.KeyChar == 'Y' ?
                true : false;
            Console.WriteLine();// --> boor sung phuowng thuwcs create cho boolController


        }
    }
}
