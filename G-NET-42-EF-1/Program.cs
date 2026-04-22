using G_NET_42_EF_1.Data;

namespace G_NET_42_EF_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var category = new Category
                {
                    Name = "Data Structure",
                    Description="Coding books",
                    IsActive = true,
                };
                var Author = new Author
                {
                    FirstName="Fayrouz",
                    LastName="Goumaa",
                    Email="fayrouzgoumaa@gmail.com",
                    Biography="Software Developer",
                    DateOfBirth=new DateTime(2002,10,6)
                };
                var book = new Book
                {
                    Title="C#",

                };
            }

        }
    }
}
