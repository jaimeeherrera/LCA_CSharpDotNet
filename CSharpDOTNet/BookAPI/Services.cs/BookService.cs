using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Services
{
    public class BookService : IBookService 
    {
        private readonly DbContext _bookContext;

        public BookService(DbContext bookContext)
        {
            _bookContext = bookContext; 

        }
        // Get all books 
        public IEnumerable <Book> GetAll()
        {
            return _bookContext.books.ToList();
        }

        //Ge3t a book by id
        public Book Get(int id)
        {
//return _bookContext.books.FirstOrDefault(base => b.Id == id);
            retrun _bookContext.books.Find(id);
        }
        //Add a new book 
        public BookAPI Add(Book newBook)
        {
            _bookContext.books.Add(newBook);
            _bookContext.SaveChanges();
            return newBook;
        }

        //Update Book
         public 

        public void Delete (Book book)
        {
            var currentBook 
        }
    }
}
