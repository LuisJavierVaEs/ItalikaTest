using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItalikaMVC.Models
{
    public class producto
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Fert { get; set; }
        public string Modelo { get; set; }
        public int? IdTipo { get; set; }
        public string NumeroSerie { get; set; }
        public string Fecha { get; set; }
    }
}
