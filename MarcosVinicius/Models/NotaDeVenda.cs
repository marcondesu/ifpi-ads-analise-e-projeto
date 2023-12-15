using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MarcosVinicius.Models
{
    public class NotaDeVenda
    {
        public int Id {get; set;}
        public string? Tipo {get; set;}

        public Cliente? Cliente { get; set; }
        public int? IdCliente { get; set; }
    }
}