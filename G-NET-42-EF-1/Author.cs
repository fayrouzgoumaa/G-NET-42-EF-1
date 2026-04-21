using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_42_EF_1
{
    internal class Author
    {
        public int Id { get; set; }
        public string First { get; set; } 
       public  string LastName {  get; set; }
        public string Email {  get; set; }
        public string Biography {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Book> Books {  get; set; }=new List<Book>();
    }
}
