﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }


        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string ICollection<Book> Books { get; set; }
    }
}
