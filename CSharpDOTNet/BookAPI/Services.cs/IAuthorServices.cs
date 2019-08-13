using System.Collections.Generic;
using BookAPI.Models;

namespace BookAPI.Services
{
    public interface IAuthorService
    {
        
        Author Add(Author todo);
        // read
        Author Get(int id);
        // update
        Author Update(Author todo);
        // delete
        void Remove(Author todo);
        // list
        IEnumerable<Author> GetAll();
    }
}