using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.Data.Filtering;

namespace SistemaLibreria.UI.Reportes
{
    public partial class Factura : DevExpress.XtraReports.UI.XtraReport
    {
        public Factura()
        {
            InitializeComponent();
        }

        protected void Factura_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            /*var binaryOperator = new BinaryOperator();
            binaryOperator.LeftOperand = "Id";
            binaryOperator.RightOperand = this.Parameters["FacturaID"].Value.ToString();
            this.FacturaXpCollection.Filter = binaryOperator;
            this.FacturaXpCollection.LoadingEnabled = true;
            this.FacturaXpCollection.Load();*/
        }
    }
}
