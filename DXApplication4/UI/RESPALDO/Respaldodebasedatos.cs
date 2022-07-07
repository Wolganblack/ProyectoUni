using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using ModeloDatos.ORM;
using DevExpress.Xpo;

namespace SistemaLibreria.UI.RESPALDO
{
    public partial class Respaldodebasedatos : DevExpress.XtraEditors.XtraForm
    {
        public Respaldodebasedatos()
        {
            InitializeComponent();
        }

        private void Respaldodebasedatos_Load(object sender, EventArgs e)
        {

        }

        private void RespaldoSimpleButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo SQL (*sql)|*.sql";
                saveFileDialog.Title = "seleccionar el archivo de respaldo";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog.FileName;

                   /* string respaldodescript = XpoDefault.ConnectionString;
                    respaldodescript += "charset=utf8; convertzerodatetime=true";*/
                    /* string ruta = @"C:\TABLASORACLE";*/
                    //using (MySqlConnection conexion = new MySqlConnection(respaldodescript))
                    {
                        var conexion = XpoDefault.DataLayer.Connection as MySqlConnection;
                        using (MySqlCommand command = new MySqlCommand())
                        {
                            command.Connection = conexion;
                            using (MySqlBackup mySqlBackup = new MySqlBackup(command))
                            {
                                command.Connection = conexion;
                                //conexion.Open();
                                mySqlBackup.ExportToFile(ruta);
                                conexion.Close();
                                MessageBox.Show("Respaldo generado");
                            }
                        }
                    }
                }
            }
        }

        private void ImportarSimpleButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivo SQL (*sql)|*.sql";
                openFileDialog.Title = "seleccionar el archivo de respaldo";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = openFileDialog.FileName;

                    /*string respaldodescript = XpoDefault.ConnectionString;
                    respaldodescript += "charset=utf8; convertzerodatetime=true";*/
                    /* string ruta = @"C:\TABLASORACLE";*/
                    //using (MySqlConnection conexion = new MySqlConnection(respaldodescript))
                    {
                        var conexion = XpoDefault.DataLayer.Connection as MySqlConnection;
                        using (MySqlCommand command = new MySqlCommand())
                        {
                            command.Connection = conexion;
                            using (MySqlBackup mySqlBackup = new MySqlBackup(command))
                            {
                                command.Connection = conexion;
                                //conexion.Open();
                                mySqlBackup.ImportFromFile(ruta);
                                conexion.Close();
                                MessageBox.Show("Base de datos restaurada");
                            }
                        }
                    }
                }
            }
        }
    }
}
    
     