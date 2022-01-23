using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ebury_client
{
    public partial class RegisterPrivateClient : Form
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PASSWORD = Properties.Settings.Default.BD_PASSWORD;

        private string connection_data = "server=" + BD_SERVER + ";user=" + BD_USER
                + ";database=" + BD_NAME + ";port=3306" + ";password=" + BD_PASSWORD;

        public RegisterPrivateClient()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            clearText();
            cancelarWindow();
            
        }
        private void clearText()
        {
            tNIF.Text = "";
            tPrimerNombre.Text = "";
            tSegundoNombre.Text = "";
            tPrimerApellido.Text = "";
            tSegundoApellido.Text = "";
            dFechaNacimiento.Value = DateTime.Today;
            tCalle.Text = "";
            tNumero.Text = "";
            tPuerta.Text = "";
            tCiudad.Text = "";
            tRegion.Text = "";
            tPais.Text = "";
            tCP.Text = "";
            cValida.Checked = false;
            tContrasena.Text = null;
            tRepetirContrasena.Text = "";
        }
        

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            if (tNIF.Text == "" || tPrimerNombre.Text == "" || tPrimerApellido.Text == ""  || tCalle.Text == "" ||
                tPuerta.Text == "" || tCalle.Text == "" || tPais.Text == "" || tCP.Text == "" || tContrasena.Text == "" || tRepetirContrasena.Text == "" || !validNif(tNIF.Text))
            {
                    errorUserWindow();
                    tContrasena.Text = "";
                    tRepetirContrasena.Text = ""; 

            }else if (tContrasena.Text != tRepetirContrasena.Text)
            {
                passErrorWindow();
                tContrasena.Text = ""; 
                tRepetirContrasena.Text = "";
            }
            else
            {
                try
                {
                    MySqlConnection conn = new MySqlConnection(connection_data);
                    string sql = "INSERT INTO address (`street`, `number`, `floorOfficeDoor`, `city`, `region`, `postalCode`, `country`, `valid`) values(";
                    sql += normalize(tCalle.Text) + ", ";
                    sql += normalize(tNumero.Text) + ", ";
                    sql += normalize(tPuerta.Text) + ", ";
                    sql += normalize(tCiudad.Text) + ", ";
                    sql += normalize(tRegion.Text) + ", ";
                    sql += normalize(tCP.Text) + ", ";
                    sql += normalize(tPais.Text) + ", ";
                    sql += getCheckedValue() ;
                    sql += ");";
                    Console.WriteLine(sql);
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    
                    sql = "INSERT INTO `grupo03DB`.`customer` (`nif`, `username`, `password`, `startDate`, `endDate`) VALUES(" ; 
                    sql += normalize(tNIF.Text) + ", ";
                    sql += normalize(tPrimerNombre.Text) + ", ";
                    sql += normalize(tContrasena.Text) + ", ";
                    sql += normalize(DateTime.Now.ToString("yyyy-MM-dd")) + ", ";
                    sql += normalize(DateTime.Now.ToString("yyyy-MM-dd")) +"); ";

                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    int addId = getLastID(); 

                    sql = "INSERT INTO `grupo03DB`.`particular` (`name`, `secondName`, `surname`, `secondSurname`, `birthDate`, `nif`, `address`) VALUES(" ; 
                    sql += normalize(tPrimerNombre.Text) + ", ";
                    sql += normalize(tSegundoNombre.Text) + ", ";
                    sql += normalize(tPrimerApellido.Text) + ", ";
                    sql += normalize(tSegundoApellido.Text) + ", ";
                    sql += normalize(dFechaNacimiento.Value.ToString("yyyy-MM-dd")) + ", ";
                    sql += normalize(tNIF.Text) + ", ";
                    sql += addId +"); ";

                    Console.WriteLine(sql);
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (result >= 1)
                    {
                        succesWindow();
                    }
                    else
                    {
                        errorBdWindow();
                    }

                }
                catch (MySqlException ex)
                {
                    errorBdWindow();
                    clearText();
                }
                catch (Exception ex)
                {
                    string message = "Error \n" + ex.Message;
                    string title = "Aviso";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                }
            }
        }

        private string getCheckedValue()
        {
            String aux;
            if (cValida.Checked)
            {
                aux = "1";
            }
            else
            {
                aux = "0";
            }
            return aux; 
        }
        private void cancelarWindow()
        {
            string message = "La operacion ha sido anulado";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
        private void errorBdWindow()
        {
            string message = "No se ha podido crear la cuenta por problemas de acceso a la base de datos";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }
        private void succesWindow()
        {
            string message = "Su cuenta ha sido dada de alta correctamente";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void errorUserWindow()
        {
            string message = "No se ha podido crear la cuenta porque hay datos obligatorios que no han sido rellenados o datos con formato incorrecto";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                
            }
        }
        private void passErrorWindow()
        {
            string message = "las contraseñas introducidas no coinciden";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
               
            }
        }
        private int getLastID()
        {
            MySqlConnection conn = new MySqlConnection(connection_data);
            try
            {
                conn.Open();

                string sql = "SELECT max(id) from address";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                int res = 0;
                while (rdr.Read())
                {
                    res += int.Parse(rdr[0].ToString());
                }
                conn.Close();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        private String normalize(String recived)
        {
            string aux = (recived == "" || recived == null ? "'no existente'" : "'" + recived + "'");
            return aux;
        }
        public bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private bool validNif(string nif)
        {
            if (nif.Length != 9) return false;
            return isNumeric(nif.Substring(0, 8)) && char.IsLetter(nif, 8);
        }

    }
}
