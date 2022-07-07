using DevExpress.Xpo;
using ModeloDatos.ORM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDatos.Pruebas
{
    class PruebasEntidades
    {
        public UnitOfWork s;

        public PruebasEntidades()
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(
                ConnectionHelper.ConnectionString, DevExpress.Xpo.DB.AutoCreateOption.None
                );
            s = new UnitOfWork();
        }

        public Cliente CrearCliente()
        {
            Cliente c = new Cliente(s);

            c.Nombre = "Cliente1";
            c.Apellido = "Apellido1";
            c.Cedula = "123456789";
            c.Direccion = "abcde";
            c.Email = "c1@email.com";

            return c;
        }

        public List<Departamento> CrearDepartamentos()
        {
            List<Departamento> departamentos = new List<Departamento>();

            string[] nombres =
            {
                "Leon", "Managua", "Chontales"
            };

            foreach(string n in nombres)
            {
                Departamento d = new Departamento(s);
                d.Nombre = n;
                departamentos.Add(d);
            }

            return departamentos;
        }

        [Test]
        public void ProbarEntidades()
        {
            Cliente c = CrearCliente();
            string nombre = "Maria";
            c.Nombre = nombre;

            Assert.AreEqual(c.Nombre, nombre);

            Assert.IsNotEmpty(c.Nombre);

            List<Departamento> departamentos = CrearDepartamentos();

            Assert.IsNotEmpty(departamentos);
        }

        public Municipio CrearMunicipio()
        {
            Municipio m = new Municipio(s);
            m.Nombre = "M1";
            return m;
        }

        [Test]
        public void ProbarFactura()
        {
            Factura f = new Factura(s);

            List<Departamento> departamentos = CrearDepartamentos();
            Municipio m = CrearMunicipio();

            foreach(Departamento d in departamentos)
            {
                d.Save();
            }
            s.CommitChanges();
            m.DepartamentoId = departamentos[0];
            m.Save();

            Cliente c = CrearCliente();
            c.Save();
            c.MunicipioId = m;
            f.ClienteId = c;

            DetalleFactura df = new DetalleFactura(s);
            df.CantidadPedida = 10;
            df.Descripcion = "Desc1";
            df.PrecioTotal = 10;

            f.DetalleFacturas.Add(df);

            Assert.True(f.Validar(), "El metodo validar devuelve false");
            //Guardar datos
            Assert.True(true);
            s.CommitChanges();
        }
    }
}
