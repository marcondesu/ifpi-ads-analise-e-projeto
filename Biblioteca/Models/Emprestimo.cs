using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Models
{
    public class Emprestimo
    {
        [Key]
        public int Id { get; set; }

        public int TitularId { get; set; }
        public int EstudanteId { get; set; }
        public int BibliotecarioId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Devolucao { get; set; }
        public float Multa { get; set; }
    }
}
