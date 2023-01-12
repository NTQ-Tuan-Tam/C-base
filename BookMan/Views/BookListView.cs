using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.Views
{

    using BookMan.Models;
    using BookMan.Share;

    internal class BookListView
    {
        protected Book[] Model; // mangr của các objeect kiểu book
        /// <summary>
        /// hàm tạo
        /// </summary>
        /// <param name="model"> danh sách object kiểu book</param>
        public BookListView(Book[] model)
        {
            Model = model;
        }
        /// <summary>
        /// in dansh sacsh ra console
        /// </summary>
        public void Render()
        {
            for (int i = 0; i < Model.Length; i++)
            {
                ViewColor.WriteLine($"[{Model[i].Id}]", ConsoleColor.Yellow);
                ViewColor.WriteLine($" {Model[i].Title}", Model[i].Reading ? ConsoleColor.Cyan : ConsoleColor.White);
            }
        }
    }
}
