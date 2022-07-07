using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ModeloDatos.ORM
{

    public partial class DetalleFactura
    {
        public DetalleFactura(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public decimal Total
        {
            get
            {
                return CantidadPedida * this.ProductoId.PrecioVenta;
            }
        }

    }

}
