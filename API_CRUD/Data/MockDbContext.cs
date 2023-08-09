using API_CRUD.Models;

namespace API_CRUD.Data
{
    public class MockDbContext : IMockDbContext
    {
        public List<Book> Books { get; set; } = new List<Book>()
        {
            new Book(){ Id=1, Name="C# in Depth", Author ="Jon Skeet" },
            new Book(){ Id=2, Name="Mastering ASP.NET Web API", Author ="Malendra Hurbuns" }
        };

    }
}
