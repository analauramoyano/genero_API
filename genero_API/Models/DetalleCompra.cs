//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace genero_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleCompra
    {
        public int id { get; set; }
        public int compras_fk { get; set; }
        public int libro_fk { get; set; }
        public decimal precio_unitario { get; set; }
        public int cantidad { get; set; }
    
        public virtual Compra Compra { get; set; }
        public virtual Libro Libro { get; set; }
    }
}