using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Livro
    {
        [Key]
        public string Isbn { get; set; }

        public string AutorId { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
