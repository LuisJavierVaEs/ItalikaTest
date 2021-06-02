using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiItalika.Model.Models
{
    public partial class Producto
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Modelo { get; set; }
        public int? IdTipo { get; set; }
        public string NumeroSerie { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Tipo IdTipoNavigation { get; set; }
    }
}
