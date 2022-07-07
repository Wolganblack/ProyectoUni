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
using ModeloDatos.ORM;
using System.Net.Mail;
using DevExpress.Data.Filtering;


namespace SistemaLibreria.UI.Controles
{
    public partial class Agregarcliente : DevExpress.XtraEditors.XtraForm
    {

        public int? Id
        {
            get;

            set;
        }

        public Agregarcliente()
        {
            InitializeComponent();
        }



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!this.ClienteDxValidationProvider.Validate())
            {
                return;

            }
            this.ClienteBiindingSource.EndEdit();
            UnitOfWork.CommitChanges();
            this.Close();
        }

        private void Emailclitxt_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Cedulatcli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                Nombreclitxt.Focus();

        }

       /* private void Nombreclitxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                Apellidoclitxt.Focus();

        }

        private void Apellidoclitxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                Emailclitxt.Focus();

        }

        private void Emailclitxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
               Agregarclie1.Focus();

        }*/

        private void Emailclitxt_EditValueChanged(object sender, CancelEventArgs e)
        {
            
            
            try
            {
                TextEdit textEdit = (TextEdit) sender;
                string emailAddress = textEdit.EditValue.ToString();
                MailAddress m = new MailAddress(emailAddress);
            }
            catch (FormatException)
            {
                e.Cancel = true;
            }
        }

        private void Agregarcliente_Load(object sender, EventArgs e)
        {
            if (this.Id != null)
            {
                var criteria = CriteriaOperator.Parse(string.Format("{0} = {1}", nameof(Cliente.Id), this.Id));
                ClienteXpCollection.Criteria = criteria;
                ClienteXpCollection.LoadingEnabled = true;
                ClienteXpCollection.Load();
            }
            else
            {
                this.ClienteBiindingSource.AddNew();
            }
        }

        private void Cedulatcli_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void MunicipioSearchLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Emailclitxt_EditValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
