using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ModeloDatos.ORM
{

    public partial class Rol
    {
        public Rol(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
