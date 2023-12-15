using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcosVinicius.Models
{
    public class Item
    {
        public int Id {get; set;}
        public double Preco {get; set;}
        public int Percentual {get; set;}
        public int Quantidade {get; set;}
        public NotaDeVenda? NotaDeVenda { get; set; }
        [Display(Name = "Nota de Venda"), ForeignKey("NotaDeVenda")]
        public int IdNotaDeVenda { get; set; }
        public Produto? Produto { get; set; }
        [Display(Name = "Produto"), ForeignKey("Produto")]
        public int IdProduto { get; set; }
    }
}