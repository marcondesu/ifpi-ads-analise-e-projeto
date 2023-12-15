using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcosVinicius.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}
        [Display(Name = "Descrição")]
        public string? Descricao {get; set;}
        public int Quantidade {get; set;}
        [Display(Name = "Preço")]
        public double Preco {get; set;}
        public Marca? Marca { get; set; }
        [Display(Name = "Marca"), Required(), ForeignKey("Marca")]
        public int MarcaId { get; set; }
    }
}