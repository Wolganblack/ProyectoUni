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
using DevExpress.XtraGrid;
using ModeloDatos.ORM;
using DevExpress.Data.Filtering;
using ReporteFactura = SistemaLibreria.UI.Reportes.Factura;
using DevExpress.XtraReports.UI;

namespace SistemaLibreria.UI.Facturas
{
    public partial class AgregarFacturas : DevExpress.XtraEditors.XtraForm
    {
        private Factura factura;

        public int? Id
        {
            get;

            set;
        }
        public AgregarFacturas()
        {
            InitializeComponent();
        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void ImprimirSimpleButton_Click(object sender, EventArgs e)
        {
            if(this.factura == null)
            {
                return;
            }
            ReporteFactura reporteFactura = new ReporteFactura();
            reporteFactura.Parameters["FacturaID"].Value = this.factura.Id;
            ReportPrintTool printTool = new ReportPrintTool(reporteFactura);
            printTool.ShowRibbonPreview();
        }

        private void AgregarFacturas_Load(object sender, EventArgs e)
        {
            
            if (this.Id != null)
            {
                var criteria = CriteriaOperator.Parse(string.Format("{0} = {1}", nameof(Cliente.Id), this.Id));
                this.FacturaXpCollection.Criteria = criteria;
                this.FacturaXpCollection.LoadingEnabled = true;
                this.FacturaXpCollection.Load();
                this.factura = this.FacturaBindingSource.Current as Factura;
            }
            else
            {
                this.factura = this.FacturaBindingSource.AddNew() as Factura;
            }
            if (this.factura != null)
            {
                this.DetalleFacturaBindingSource.DataSource = this.factura.DetalleFacturas;
            }
        }

        private void AñadirVentaSimpleButton_Click(object sender, EventArgs e)
        {
            var producto = this.ProductoSearchLookUpEdit.EditValue as ModeloDatos.ORM.Producto;
            var cantidad = this.CantidadTextEdit.EditValue;
            int valorCantidad = 0;
            if (producto == null || 
                cantidad == null || 
                !int.TryParse(cantidad.ToString(), out valorCantidad))
            {
                return;
            }

            var detalleFacura = new DetalleFactura(this.factura.Session);
            detalleFacura.Descripcion = producto.Descripcion;
            detalleFacura.CantidadPedida = valorCantidad;
            detalleFacura.FacturaId = this.factura;
            detalleFacura.ProductoId = producto;
            detalleFacura.PrecioTotal = producto.PrecioVenta * valorCantidad;
            this.DetalleFacturaBindingSource.Add(detalleFacura);
            this.DetalleFacturaGridView.RefreshData();
        }

        private void AgregarFacturaSimpleButton_Click(object sender, EventArgs e)
        {
            if (!this.AgregarFacDxValidationProvider.Validate())
            {
                return;

            }
            this.DetalleFacturaBindingSource.EndEdit();
            UnitOfWork.CommitChanges();
            this.Close();
        }

        private void ProductoSearchLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            var producto = this.ProductoSearchLookUpEdit.EditValue as ModeloDatos.ORM.Producto;

            if(producto==null)
            {
                this.StockTextEdit.EditValue = null;
                return;
            }
            this.StockTextEdit.EditValue = producto.Existencias;
        }

        private void ProductoSearchLookUpEdit_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ModificarSimpleButton_Click(object sender, EventArgs e)
        {
            var detalle = this.DetalleFacturaBindingSource.Current as ModeloDatos.ORM.DetalleFactura;
            if(detalle==null)
            {
                return;
            }
            detalle.Delete();
            this.DetalleFacturaBindingSource.Remove(detalle);
            this.DetalleFacturaGridView.RefreshData();

        }

      
    }
        /*  public void ShowGridPreview(GridControl grid)
{
// Check whether the GridControl can be previewed.
if (!grid.IsPrintingAvailable)
{
MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
return;
}

// Open the Preview window.
grid.ShowPrintPreview();
}*/
    }

