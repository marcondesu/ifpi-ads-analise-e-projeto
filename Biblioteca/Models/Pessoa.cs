using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento{ get; set; }
    }
}
