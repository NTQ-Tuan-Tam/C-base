namespace BookMan.Controller
{
    using BookMan.ConsoleApp.Views;
    using Models;

    /// <summary>
    /// lớp điều khiển, giúp ghép nối dữ liệu sách với giao diện
    /// </summary>
    internal class BookController
    {
        public void Single(int id)
        {
            Book model = new Book // khởi tạo object 
            {
                Id = 1,
                Authors = " Adam Freeman",
                Title= " expert asp,ner web api 2",
                Publisher = "Apress",
                Year = 2014,
                Tags = "c#, asp.net, mvc",
                Description = "expert insight and undersading of how to create",
                Rating = 5,
                Reading = true
            };
            BookSingleView view = new BookSingleView(model);
            //gội phương thức Render dể thực sự hiển thị ra màn hình 
            view.Render();
        }
         public void Create()
        {
            BookCreateView create = new BookCreateView(); //khoi tao object
            create.Render(); //in ra man hinh
         }      
    }
}
