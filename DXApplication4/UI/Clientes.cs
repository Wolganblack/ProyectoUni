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
using SistemaLibreria.UI;
using DevExpress.Xpo;
using SistemaLibreria.UI.Controles;
using ModeloCliente = ModeloDatos.ORM.Cliente;
using System.Diagnostics;

namespace SistemaLibreria.UI
{
    public partial class Clientes : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void NuevoClienteBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            Agregarcliente agregarcliente = new Agregarcliente();
            agregarcliente.ShowDialog();
            ClienteXpCollection.Reload();

        }

        private void EditarBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ModeloCliente actual = ClientesBindingSource.Current as ModeloCliente;
            if(actual == null)
            {
                return;
            }
            Agregarcliente form = new Agregarcliente();
            form.Id = actual.Id;
            form.ShowDialog();
            this.UnitOfWork.Reload(actual);
        }

        private void ImprimiroExportarBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClientesGridControl.ShowRibbonPrintPreview();
        }

        private void ExportarBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            string path = "output.xlsx";
            ClientesGridControl.ExportToXlsx(path);
            // Open the created XLSX file with the default application.
            Process.Start(path);
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void EliminarBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var current = this.ClientesBindingSource.Current as ModeloCliente;
                if (current == null)
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