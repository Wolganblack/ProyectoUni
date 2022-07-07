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
using ModeloDatosProveedor = ModeloDatos.ORM.Proveedor;
using DXApplication4.UI.Provedor;

namespace SistemaLibreria.UI.Proveedor
{
    public partial class ListaProveedores : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListaProveedores()
        {
            InitializeComponent();
        }

        private void ImprimirBarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridControlProveedores.ShowRibbonPrintPreview();
        }

        private void ExcelBarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "output.xlsx";
            GridControlProveedores.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void NuevoBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarProveedor agregarProveedor = new AgregarProveedor();
            agregarProveedor.ShowDialog();
            ProveedorXpCollection.Reload();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void ListaProveedores_Load(object sender, EventArgs e)
        {

        }

        private void EditarBarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModeloDatosProveedor actual = ListarProveedoresBindingSource.Current as ModeloDatosProveedor;
            if (actual == null)
            {
                return;
            }
            AgregarProveedor form = new AgregarProveedor();
            form.Id = actual.Id;
            form.ShowDialog();
            this.UnitOfWork.Reload(actual);
        }

        private void EliminarBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var current = this.ListarProveedoresBindingSource.Current as ModeloDatosProveedor;
                if(current == null)
                {
                    return;
                }
                this.UnitOfWork.Delete(current);
                UnitOfWork.CommitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

