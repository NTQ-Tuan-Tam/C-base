namespace BookMan.Controller
{
    using BookMan.ConsoleApp.Views;
    using DataService;
    using Views;
    using Models;

    /// <summary>
    /// lớp điều khiển, giúp ghép nối dữ liệu sách với giao diện
    /// </summary>
    internal class BookController
    {
        
        protected Repository Repository;
        public BookController(SimpleDataAccess context)
        {
            Repository = new Repository(context);
        }
        public void Single(int id)
        {
            var model = Repository.Select(id);//lấy dữ liệu qua Repository lưu vào model
            BookSingleView view = new BookSingleView(model);
            //gội phương thức Render dể thực sự hiển thị ra màn hình 
            view.Render();
        }
        /// <summary>
        /// kích hoạt chức năng nhâp dữ liệu cho 1 cuốn sách
        /// </summary>
        public void Create()
        {
            BookCreateView view = new BookCreateView(); //khoi tao object
            view.Render(); //in ra man hinh
        }
        public void Update(int id)
        {
            var model = Repository.Select(id);
            var view = new BookUpdateView(model);
            view.Render();
        }
        public void List()
        {
            var model = Repository.Select();//lấy dư liệu
            BookListView view = new BookListView(model);//khởi tạo
            view.Render();
        }
    }
}
