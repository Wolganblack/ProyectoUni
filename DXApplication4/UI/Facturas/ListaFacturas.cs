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
using ModelodatosFacturas = ModeloDatos.ORM.Factura;

namespace SistemaLibreria.UI.Facturas
{
    public partial class ListaFacturas : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public ListaFacturas()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {

        }

        private void NuevobarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AgregarFacturas agregarFacturas = new AgregarFacturas();
            agregarFacturas.ShowDialog();
            this.ListaFacturaXpCollection.Reload();

        }

        private void ExcelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string path = "output.xlsx";
            ListaFacturaGridControl.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void ImprimirBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           ListaFacturaGridControl.ShowRibbonPrintPreview();

        }

        private void EliminarBarButtonItemB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var current = this.ListaFacturaBindingSource.Current as ModelodatosFacturas;
                if (current == null)
                {
                    return;
                }
                this.ListaFacturaUnitOfWork.Delete(current);
                ListaFacturaUnitOfWork.CommitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditarBarButtonItemB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ModelodatosFacturas actual = ListaFacturaBindingSource.Current as ModelodatosFacturas;
            if (actual == null)
            {
                return;
            }
            AgregarFacturas form = new AgregarFacturas();
            form.Id = actual.Id;
            form.ShowDialog();
            this.ListaFacturaUnitOfWork.Reload(actual);
        }
    }
    }

