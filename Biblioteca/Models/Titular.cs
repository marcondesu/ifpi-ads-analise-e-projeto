using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
    public class Titular
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("LivroIsbn")]
        public string LivroIsbn { get; set; }
    }
}
