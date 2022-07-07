using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ModeloDatos.ORM
{

    public partial class Cliente
    {
        public Cliente(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }


        public string Nombre_apellido
        {
            get
            {
                return Nombre + "  " + Apellido;
            }

        }
        
    }

}
