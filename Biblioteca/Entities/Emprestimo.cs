namespace Biblioteca.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public User Usuario { get; set; }
        public Book Livro { get; set; }
        public DateTime Data { get; set; }
    }
}
