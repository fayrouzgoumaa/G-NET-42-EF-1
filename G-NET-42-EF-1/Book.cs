using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_42_EF_1
{
    internal class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public double price { get; set; }
        public int NumberOfPages { get; set; }
        public int YearPublished { get; set; }
        public bool IsInStock { get; set; }
        public int categoryId {  get; set; }
        public category category {  get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();

    }
}
