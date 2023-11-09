namespace Biblioteca.Models
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int TitularId { get; set; }
        public int EstudanteId { get; set; }
        public int BibliotecarioId { get; set; }
        public DateOnly Inicio { get; set; }
        public DateOnly Devolucao { get; set; }
        public float Multa { get; set; }
    }
}
