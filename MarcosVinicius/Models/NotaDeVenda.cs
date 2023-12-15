using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcosVinicius.Models
{
    public class NotaDeVenda
    {
        public int Id {get; set;}
        public string? Tipo {get; set;}
        public Cliente? Cliente { get; set; }
        [Display(Name = "Cliente"), ForeignKey("Cliente")]
        public int? IdCliente { get; set; }
        public Vendedor? Vendedor { get; set; }
        [Display(Name = "Vendedor"), ForeignKey("Vendedor")]
        public int? IdVendedor { get; set; }
        public Transportadora? Transportadora { get; set; }
        [Display(Name = "Transportadora"), ForeignKey("Transportadora")]
        public int? IdTransportadora { get; set; }
    }
}