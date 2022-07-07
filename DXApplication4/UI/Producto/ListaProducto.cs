using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using ModeloProducto = ModeloDatos.ORM.Producto;

namespace SistemaLibreria.UI.Producto
{
    public partial class ListaProducto : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListaProducto()

        {
            InitializeComponent();
        }

        private void NuevoProductoBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Productos formularioProducto = new Productos();
            formularioProducto.ShowDialog();
            this.ListaProductoxpCollection.Reload();
        }

        private void ImprimiroExportarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           GridControlProducto.ShowRibbonPrintPreview();
        }

        private void ExportExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "output.xlsx";
            GridControlProducto.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void EditarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModeloProducto actual = ListaProductoBindingSource1.Current as ModeloProducto;
            if (actual == null)
            {
                return;
            }
            Productos    form = new Productos();
            form.Id = actual.Id;
            form.ShowDialog();
            this.UnitOfWork1.Reload(actual);
        }

        private void EliminarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var current = this.ListaProductoBindingSource1.Current as ModeloProducto;
                if (current == null)
                {
                    return;
                }
                this.UnitOfWork1.Delete(current);
                UnitOfWork1.CommitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}