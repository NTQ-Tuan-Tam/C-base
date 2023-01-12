using BookMan.Share;
using System;
namespace BookMan.ConsoleApp.Views
{
    /// <summary>
    /// class để thêm một cuốn sách mới
    /// </summary>
    internal class BookCreateView
    {
        public BookCreateView()
        {
        }
        /// <summary>
        /// yêu cầu người dùng nhập từng thông tin và lưu lại thông tin đó
        /// </summary>
        public void Render()
        {
            ViewColor.WriteLine("CREATE A NEW BOOK", ConsoleColor.Green);
            var title = ViewColor.InputString("Title"); //đọc vào biến title            
            var authors = ViewColor.InputString("Authors"); //đọc vào biến authors            
            var publisher = ViewColor.InputString("Publisher"); //đọc vào biến publisher
            var year = ViewColor.InputInt("Year"); // nhập giá trị cho biến year
            var edition = ViewColor.InputInt("Edition"); // nhập giá trị cho biến edition
            var tags = ViewColor.InputString("Tags");
            var description = ViewColor.InputString("Description");
            var rate = ViewColor.InputInt("Rate");
            var reading = ViewColor.InputBool("Reading");
            var file = ViewColor.InputString("File");
        }

       

    }
}