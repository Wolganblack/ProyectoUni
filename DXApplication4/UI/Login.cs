using System;
using System.Windows.Forms;
using DevExpress.Xpo;
using MySql.Data.MySqlClient;

namespace SistemaLibreria.UI
{
    public partial class Login: DevExpress.XtraEditors.XtraForm
    {
        int TotalIntentos = 0;
        public Login()
        {
            this.InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AceptarSimpleButton_Click(object sender, EventArgs e)
        {
            TotalIntentos++;
            String username = UsuarioTextEdit.Text.ToString();
            String password = ClaveTextEdit.Text.ToString();
            var conexion = XpoDefault.DataLayer.Connection as MySqlConnection;
            String query = "SELECT count(id) FROM usuario WHERE (login = ?login) AND (clave = MD5(?clave));";

            MySqlCommand cmd = new MySqlCommand(query, conexion);
            cmd.Parameters.Add(new MySqlParameter("login", username));
            cmd.Parameters.Add(new MySqlParameter("clave", password));
            var count = int.Parse(cmd.ExecuteScalar().ToString());
            if (count == 0)
            {
                if(TotalIntentos > 3)
                {
                    MessageBox.Show(string.Format("Has intenado {0}", TotalIntentos));
                    Application.Exit();
                }
                return;
            }
            this.DialogResult = DialogResult.OK;

        }

        private void CancelarSimpleButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del sistema?", @"Atención",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.DialogResult = DialogResult.None;
                UsuarioTextEdit.Focus();
            }
        }
    }
}
