namespace libraryManager.Models
{
    public class Book
    {
        public int Id { get; set; } //si ponemos Id efcore lo usa autom como PK 
        public string Title { get; set; } = string.Empty; //Hacemos que sean una cadena vacia en lugar de NULL
        public string Author { get; set; } = string.Empty;
        public int PublishedYear { get; set; }
        public bool IsAvailable { get; set; } = true; //si lo creamos es porque esta disponible 

    }
}