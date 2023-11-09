namespace Biblioteca.Models
{
    public class Livro
    {
        public string Isbn { get; set; }
        public string AutorId { get; set; }
        public string Nome { get; set; }
        public DateOnly DataLancamento { get; set; }
    }
}
