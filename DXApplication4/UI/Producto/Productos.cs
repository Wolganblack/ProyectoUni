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
using DevExpress.Data.Filtering;


namespace SistemaLibreria.UI.Producto
{
    public partial class Productos : DevExpress.XtraEditors.XtraForm
    {
        public int? Id
        {
            get;

            set;
        }


        public Productos()
        {
            InitializeComponent();
        }

        private void AgregarSimpleButton_Click(object sender, EventArgs e)
        {
            if (!this.ProductoDxValidationProvider.Validate())
            {
                return;

            }
            this.ProductoBindingSource.EndEdit();
            UnitOfWork.CommitChanges();
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            if (this.Id != null)
            {
                var criteria = CriteriaOperator.Parse(string.Format("{0} = {1}", nameof(Productos.Id), this.Id));
                ProductosXpCollection.Criteria = criteria;
                ProductosXpCollection.LoadingEnabled = true;
                ProductosXpCollection.Load();
            }
            else
            {
                this.ProductoBindingSource.AddNew();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }



