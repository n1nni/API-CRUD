using API_CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_CRUD.Data
{
    public interface IMockDbContext
    {
        List<Book>? Books { get; set; }
    }
}
