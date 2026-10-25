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
        }
        











    }
}
