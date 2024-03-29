﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookMan.DataService
{
    using Models;
    

    public  class Repository
    {
        protected readonly SimpleDataAccess _context;
        public Repository(SimpleDataAccess context)
        {
            _context = context;
            _context.Load();
        }
        public void SaveChange() => _context.SaveChanges();
        public List<Book> Books => _context.Books;
        public Book[] Select() => _context.Books.ToArray();

        public Book Select(int id)
        {
            foreach (var b in _context.Books)
            {
                if(b.Id == id) return b;
            }
            return null;
        }
        public Book[] Select(string key)
        {
            var temp  = new List<Book>();   
            var k = key.ToLower();
            foreach (var b in _context.Books)
            {
                var logic =
                    b.Title.ToLower().Contains(k) ||
                    b.Authors.ToLower().Contains(k) ||
                    b.Publisher.ToLower().Contains(k) ||
                    b.Tags.ToLower().Contains(k) ||
                    b.Description.ToLower().Contains(k);
                if (logic) temp.Add(b);
            }
            return temp.ToArray();
        }
        public void Insert(Book book)
        {
            var lastIndex = _context.Books.Count - 1;
            var id = lastIndex < 0 ? 0 : _context.Books[lastIndex].Id + 1;
            book.Id = id;
            _context.Books.Add(book);
        }
        public bool Delete(int id)
        {
            var b = Select(id);
            if (b == null) return false;
            _context.Books.Remove(b);
            return true;
        }
        public bool Update(int id, Book book)
        {
            var b = Select(id);
            if(b==null) return false;
            b.Authors = book.Authors;
            b.Publisher = book.Publisher;
            
            b.Description = book.Description;
            b.Edition = book.Edition;
            b.File = book.File;
            b.Isbn = book.Isbn;
            b.Rating = book.Rating;
            b.Reading = book.Reading;
            b.Tags = book.Tags;
            b.Title = book.Title;
            b.Year = book.Year;
            return true;


        }
    }
}
