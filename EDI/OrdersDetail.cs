//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EDI
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrdersDetail
    {
        public short idOrderDetail { get; set; }
        public Nullable<short> idOrder { get; set; }
        public Nullable<int> idPlanet { get; set; }
        public Nullable<short> idReference { get; set; }
        public Nullable<short> Quantity { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
    
        public virtual Orders Orders { get; set; }
        public virtual Planets Planets { get; set; }
        public virtual References References { get; set; }
    }
}
