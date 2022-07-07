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
using System.Net.Mail;

namespace DXApplication4.UI.Provedor
{
    public partial class AgregarProveedor : DevExpress.XtraEditors.XtraForm
    {
        public int? Id
        {
            get;

            set;
        }

        public AgregarProveedor()
        {
            InitializeComponent();
        }
        private void AgregarProveedorSimpleButton1_Click(object sender, EventArgs e)
        {
            if (!this.AgregarProveedorDxValidationProvider1.Validate())
            {
                return;
            }
            this.ProovedorBindingSource.EndEdit();
            UnitOfWork.CommitChanges();
            this.Close();
        }

        private void CedulaTextEdit_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.Enter))
                NombreTextEdit.Focus();
        }
        private void EmailTextEdit_EditValueChanged(object sender, CancelEventArgs e)
        {
            try
            {

                TextEdit textEdit = (TextEdit)sender;
                string emailAddress = textEdit.EditValue.ToString();
                MailAddress m = new MailAddress(emailAddress);
            }
            catch (FormatException)
            {
                e.Cancel = true;
            }
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            if (this.Id != null)
            {
                var criteria = CriteriaOperator.Parse(string.Format("{0} = {1}", nameof(AgregarProveedor.Id), this.Id));
                ProveedorXpCollection.Criteria = criteria;
                ProveedorXpCollection.LoadingEnabled = true;
                ProveedorXpCollection.Load();
            }
            else
            {
                this.ProovedorBindingSource.AddNew();
            }
        }

       

        private void CedulaTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void DireccionTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

