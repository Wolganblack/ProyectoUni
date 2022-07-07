using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SistemaLibreria.UI.Proveedor;
using SistemaLibreria.UI.Facturas;
using SistemaLibreria.UI.Producto;
using SistemaLibreria.UI.RESPALDO;


namespace SistemaLibreria.UI
{
    public partial class Principal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        protected void ClienteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clientes formularioClientes = new Clientes();
            formularioClientes.MdiParent = this;
            formularioClientes.Visible = true;
        }

        protected void ProveedoresBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListaProveedores formularioProveedores = new ListaProveedores();
            formularioProveedores.MdiParent = this;
            formularioProveedores.Visible = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ProductoBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListaProducto formulariolistaProducto = new ListaProducto();
            formulariolistaProducto.MdiParent = this;
            formulariolistaProducto.Visible = true;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void RespaldoBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Respaldodebasedatos respaldodebasedatos = new Respaldodebasedatos();
            respaldodebasedatos.MdiParent = this;
            respaldodebasedatos.Visible = true;
            
        }

        private void FacturaBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListaFacturas facturas = new ListaFacturas();
            facturas.MdiParent = this;
            facturas.Visible = true;

        }
    }
}