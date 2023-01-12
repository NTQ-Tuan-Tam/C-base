namespace BookMan.Models
{
    /// <summary>
    /// lớp mÔ tả đối tượng sách 
    /// </summary>
    public class Book
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { if (value >= 1) _id = value; } //check id >= 1 = true;
        }
        private string _authors = "Unknown author";
        /// <summary>
        /// tên tác giả hoặc nhóm tác giả không nhận giá trị rỗng
        /// </summary>

        public string Authors
        {
            get { return _authors; }
            set { if (!string.IsNullOrEmpty(value)) _authors = value; } //ckeck giá trị đầu vào !nul = true
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { if (!string.IsNullOrEmpty(value)) _title = value; } //không nhận giá trị rỗng
        }
        private string _publisher;

        public string Publisher
        {
            get { return _publisher; }
            set { if (!string.IsNullOrEmpty(value)) _publisher = value; }
        }
        private int _year = 2018;
        /// <summary>
        /// năm xuất bản, không nhỏ hơn năm 1950
        /// </summary>
        public int Year
        {
            get { return _year; }
            set { if (value >= 1950) _year = value; } //check điều kện >= 1950 = true
        }
        private int _edition = 1;
        /// <summary>
        /// lần xấu bản, không nhỏ hơn 1 
        /// </summary>
        public int Edition
        {
            get { return _edition; }
            set { if (value >= 1) _edition = value; } // check điều kiệnkhông nhận giá trị < 1 
        }
        public string Isbn { get; set; } = "";
        /// <summary>
        /// thể loại
        /// </summary>
        public string Tags { get; set; } = "";
        /// <summary>
        /// mô tả tóm tắt nội dung 
        /// </summary>
        public string Description { get; set; } = " A new book";
        private int _rating = 1;
        /// <summary>
        /// 
        /// </summary>
        public int Rating
        {
            get { return _rating; }
            set { if (value >= 1) _rating = value; } // giá trị 1 -> 5 
        }
        public bool Reading { get; set; }

        private string _file;

        public string File
        {
            get { return _file; }
            set { if (System.IO.File.Exists(value)) _file = value; } //nhận đường dẫn đúng 
        }
        /// <summary>
        /// file sách (không có đường đẫn) 
        /// </summary>
        public string FileName
        {
            get { return System.IO.Path.GetFileName(_file); }//trả lại tên file ngắn gọn 

        }






    }



}
