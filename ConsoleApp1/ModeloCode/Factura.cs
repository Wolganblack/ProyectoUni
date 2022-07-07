using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ModeloDatos.ORM
{

    public partial class Factura
    {
        public Factura(Session session) : base(session) { }
        public override void AfterConstruction() {
            base.AfterConstruction();
            this.Fecha = DateTime.Now;
        }


        public bool Validar()
        {
            if (this.ClienteId == null)
            {
                return false;
            }

            if (this.DetalleFacturas == null || this.DetalleFacturas.Count == 0)
            {
                return false;
            }

            return true;
        }

        public decimal TotalFactura
        {
            get
            {

                decimal suma = 0;
                foreach (var detalleFactura in DetalleFacturas)
                {
                    suma += detalleFactura.Total;
                }
                return suma;
            }
           
        }

    }

}
