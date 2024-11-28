using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Data { get; set; }
        public string Description { get; set; }
        public int PageNumber { get; set; }
        public int Price { get; set; }
        public string AuthorsName { get; set; }
        public string ReadersName { get; set; }
    }
}
