using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using libraryManager.Models;
using libraryManager.Data;
using System.Threading.Tasks;


namespace libraryManager.Endpoints
{
    public static class libraryEndpoints
    {
        public static async Task MapProductEndpoints(this IEndpointRouteBuilder app)
        {
            var libraryGroup = app.MapGroup("/api/books");

            //GET no funciona 
            libraryGroup.MapGet("/", async (AppDbContext db) =>
            {
                var books = await db.Books
                .AsNoTracking()
                .ToListAsync();
                return Results.Ok(books);

            });


            //POST
            libraryGroup.MapPost("/", async (Book newBook, AppDbContext db) => {
                db.Books.Add(newBook);//lo pone en memoria 
                await db.SaveChangesAsync();
                return Results.Created($"api/books/{newBook.Id}", newBook);

            });





















        }
        











    }
}
