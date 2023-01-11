using System;

namespace BookMan.Controller
{
    using Models;
    using System.Configuration;
    using System.Net.Http;

    internal class BookSingleView
    {
        protected Book Model; //biến lưu trữ thông tin cần hiển thị 

        public BookSingleView(Book model)
        {
            Model = model; // chuyển dữ liệu tuwf tham số sang biến thành viên để sử dụng toàn class
        }
        public void Render()
        {
            if (Model == null )
            {
               Console.WriteLine("No book found. sory!",ConsoleColor.Red);
                return;
            }
            Console.WriteLine("bool detail information", ConsoleColor.Green);

            Console.WriteLine($"Authors: {Model.Authors}");
            Console.WriteLine($"Title:   {Model.Title}");
            Console.WriteLine($"Publisher: {Model.Publisher}");
            Console.WriteLine($"Year: {Model.Year}");
            Console.WriteLine($"Edition: {Model.Edition}");
            Console.WriteLine($"Isbn: {Model.Isbn}");
            Console.WriteLine($"Tags : {Model.Tags}");
            Console.WriteLine($"Description : {Model.Description}");
            Console.WriteLine($"Rating: {Model.Rating}");
            Console.WriteLine($"Reading: {Model.Reading}");
            Console.WriteLine($"File: {Model.File}");
            Console.WriteLine($"File Name: {Model.FileName}");
        }
        protected void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);
        }

    }
}
