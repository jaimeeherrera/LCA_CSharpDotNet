using System.Collections.Generic;
using System.Linq;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Services
{
    public class AuthorService : IAuthorService
    {

        private readonly BookContext _bookContext;

        public AuthorService(BookContext bookContext)
        {
            // TODO: keep a reference to the BookContext in _bookContext
            _bookContext = bookContext;
        }

        public Author Add(Author author)
        {
            // TODO: implement add
            _bookContext.Authors.Add(author);
            _bookContext.SaveChanges();
            return author;
        }

        public Author Get(int id)
        {
            // TODO: return the specified Author using Find()
            return _bookContext.Authors
                .Include(a => a.Books)
                .SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Author> GetAll()
        {
            // TODO: return all Authors using ToList()
            return _bookContext.Authors
                .Include(a => a.Books)
                .ToList();
        }

        public Author Update(Author updatedAuthor)
        {
            // get the ToDo object in the current list with this id 
            var currentAuthor = _bookContext.Authors.Find(updatedAuthor.Id);

            // return null if todo to update isn't found
            if (currentAuthor == null) return null;
            _bookContext.Entry(currentAuthor)
                .CurrentValues
                .SetValues(updatedAuthor);

            // update the todo and save
            _bookContext.Authors.Update(currentAuthor);
            _bookContext.SaveChanges();
            return currentAuthor;
        }

        public void Remove(Author author)
        {
            // TODO: remove the author
            _bookContext.Authors.Remove(author);
            _bookContext.SaveChanges();
        }

    }
}