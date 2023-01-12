using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMan.Share;
namespace BookMan.Views
{
    
    using Models;

    internal class BookUpdateView
    {
        protected Book Model;
        public BookUpdateView(Book model)
        {
            Model = model;
        }
        public void Render()
        {

            //ViewColor.WriteLine("Update book information", ConsoleColor.Green);
            //ConsoleColor labelColor = ConsoleColor.Magenta, valueColor = ConsoleColor.White;
            ////hiển thị giá trị cũ 
            //ViewColor.Write("Authors: ", labelColor);
            //ViewColor.WriteLine(Model.Authors, valueColor);

            ////yêu cầu nhập giá trị mới 
            //ViewColor.Write("New Value" , labelColor);
            //ViewColor.WriteLine(Model.Authors, valueColor);
            ////đọc giá trị mới và lưu vào model nếu người dùng update value
            //var str = Console.ReadLine();
            //var author = string.IsNullOrEmpty(str.Trim()) ? Model.Authors : str;

            ViewColor.WriteLine("UPdate book inormation", ConsoleColor.Green);//sử dụng phương thức static 
            var authors = ViewColor.InputString("Authors", Model.Authors);
            var title = ViewColor.InputString("Title", Model.Title);
            var publisher = ViewColor.InputString("Publisher", Model.Publisher);
            var isbn = ViewColor.InputString("Isbn", Model.Isbn);
            var tags = ViewColor.InputString("Tags", Model.Tags);
            var description = ViewColor.InputString("Description", Model.Description);
            var file = ViewColor.InputString("File", Model.File);
            var year = ViewColor.InputInt("Year", Model.Year);
            var edition = ViewColor.InputInt("edition", Model.Edition);
            var rating = ViewColor.InputInt("Rating", Model.Rating);
            var reading = ViewColor.InputBool ("File", Model.Reading);
            
        }
    }
}
