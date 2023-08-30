using System.Text.Json.Serialization;

namespace API_CRUD.Models
{
    public class Book
    {
        public int Id { get; set; } // better if it will be GUID
        public string? Name { get; set; }
        public string? Author { get; set; }


    }
}
