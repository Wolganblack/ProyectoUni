﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace ModeloDatos.ORM
{

    [Persistent(@"usuario")]
    public partial class Usuario : XPLiteObject
    {
        int fId;
        [Key(true)]
        [Persistent(@"id")]
        public int Id
        {
            get { return fId; }
            set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
        }
        string fLogin;
        [Size(45)]
        [Persistent(@"login")]
        public string Login
        {
            get { return fLogin; }
            set { SetPropertyValue<string>(nameof(Login), ref fLogin, value); }
        }
        string fClave;
        [Size(45)]
        [Persistent(@"clave")]
        public string Clave
        {
            get { return fClave; }
            set { SetPropertyValue<string>(nameof(Clave), ref fClave, value); }
        }
        Rol fRolId;
        [Persistent(@"rol_id")]
        [Association(@"UsuarioReferencesRol")]
        public Rol RolId
        {
            get { return fRolId; }
            set { SetPropertyValue<Rol>(nameof(RolId), ref fRolId, value); }
        }
    }

}