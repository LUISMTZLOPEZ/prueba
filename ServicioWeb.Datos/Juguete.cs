//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioWeb.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Juguete
    {
        public int Jugue_Id { get; set; }
        public string Jugue_Nombre { get; set; }
        public Nullable<int> Jugue_Existencia { get; set; }
        public Nullable<int> Jugue_Marca_Id { get; set; }
        public Nullable<int> Jugue_Categoria_Id { get; set; }
        public Nullable<System.DateTime> Jugue_Fecha_Alta { get; set; }
        public Nullable<decimal> Jugue_Precio { get; set; }
        public Nullable<bool> Jugue_Estatus { get; set; }
        public string Jugue_Foto { get; set; }
        public Nullable<decimal> Jugue_Costo { get; set; }
    
        public virtual Cata_Categoria Cata_Categoria { get; set; }
        public virtual Cata_Marca Cata_Marca { get; set; }
    }
}
