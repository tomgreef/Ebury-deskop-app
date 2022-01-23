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
    public partial class GestionCorporateClient : Form
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PASSWORD = Properties.Settings.Default.BD_PASSWORD;

        private string connection_data = @"server=" + BD_SERVER + ";userid=" + BD_USER + ";password=" + BD_PASSWORD + ";database=" + BD_NAME;

        private User mainUser;

        private DataGridViewRow seleccionado = null;

        public GestionCorporateClient(User u)
        {
            mainUser = u;
            InitializeComponent();
        }

        private void GestionCorporateClient_Load(object sender, EventArgs e)
        {
            lTipo.Items.Clear();
            lTipo.Items.Add("Socio");
            lTipo.Items.Add("Representante");
            tablaRelacionados.Rows.Clear();
        }

        private void loadRelated()
        {
            tablaRelacionados.Rows.Clear();

            MySqlConnection conn = new MySqlConnection(connection_data);
            string sql = "SELECT * FROM related WHERE company = '" + mainUser.Nif + "';";

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            MySqlDataReader r = cmd.ExecuteReader();

            MySqlConnection conn2 = new MySqlConnection(connection_data);
            conn2.Open();
            while (r.Read())
            {
                string sql_ind = "SELECT * FROM particular WHERE nif = '" + r.GetString(1) + "';";
                MySqlCommand cmd_ind = new MySqlCommand(sql_ind, conn2);
                MySqlDataReader r_ind = cmd_ind.ExecuteReader();
                if (r_ind.Read())
                {
                    tablaRelacionados.Rows.Add(r.GetString(1), r_ind.GetString(0), r_ind.GetString(1), r_ind.GetString(2), r.GetString(2));
                }
            }
            conn2.Close();
            conn.Close();
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
            lTipo.ClearSelected();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            clearText();
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

        private void bAnadir_Click(object sender, EventArgs e)
        {
            if (tNIF.Text == "" || tPrimerNombre.Text == "" || tPrimerApellido.Text == "" || tCalle.Text == "" 
                || tPuerta.Text == "" || tCiudad.Text == "" || tPais.Text == "" || tCP.Text == "" || tContrasena.Text == "" 
                || tRepetirContrasena.Text == "" || lTipo.SelectedIndices.Count == 0 || !validNif(tNIF.Text)
                || (tNumero.Text != "" && !isNumeric(tNumero.Text)) || (tCP.Text != "" && !isNumeric(tCP.Text)))
            {
                errorUserWindow();
                tContrasena.Text = "";
                tRepetirContrasena.Text = ""; 
            }
            else if (tContrasena.Text != tRepetirContrasena.Text)
            {
                passErrorWindow();
                tContrasena.Text = "";
                tRepetirContrasena.Text = "";
            }
            else
            {
                MySqlConnection conn = new MySqlConnection(connection_data);
                string sql = "INSERT INTO address (`street`, `number`, `floorOfficeDoor`, `city`, `region`, `postalCode`, `country`, `valid`) VALUES(";
                sql += normalize(tCalle.Text) + ", ";
                sql += normalize(tNumero.Text) + ", ";
                sql += normalize(tPuerta.Text) + ", ";
                sql += normalize(tCiudad.Text) + ", ";
                sql += normalize(tRegion.Text) + ", ";
                sql += normalize(tCP.Text) + ", ";
                sql += normalize(tPais.Text) + ", ";
                sql += (cValida.Checked) ? "1" : "0";
                sql += ");";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                string query = "INSERT INTO customer (`nif`, `username`, `password`, `startDate`, `endDate`) VALUES('"
                    + tNIF.Text + "', '" + tPrimerNombre.Text + "', '" + tContrasena.Text + "', '" +
                    DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "');";
                var command = new MySqlCommand(query, conn);
                command.ExecuteNonQuery();

                sql = "INSERT INTO particular (`name`, `secondName`, `surname`, `secondSurname`, `birthDate`, `nif`, `address`) VALUES(";
                sql += normalize(tPrimerNombre.Text) + ", ";
                sql += normalize(tSegundoNombre.Text) + ", ";
                sql += normalize(tPrimerApellido.Text) + ", ";
                sql += normalize(tSegundoApellido.Text) + ", ";
                sql += normalize(dFechaNacimiento.Value.ToString("yyyy-MM-dd")) + ", ";
                sql += normalize(tNIF.Text) + ", ";
                sql += getLastId() + "); ";

                cmd = new MySqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();


                if (result < 1)
                {
                    errorBdWindow();
                }

                string sql_rel = "INSERT INTO related VALUES ('" + mainUser.Nif + "', '" + tNIF.Text + "', '" + getType(lTipo.SelectedItem.ToString()) + "');";
                cmd = new MySqlCommand(sql_rel, conn);
                int result2 = cmd.ExecuteNonQuery();
                conn.Close();

                if (result2 < 1)
                {
                    errorBdWindow();
                }
                else
                {
                    clearText();
                }

                loadRelated();
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

        private void errorBdWindow()
        {
            string message = "No se ha podido crear la cuenta por problemas de acceso a la base de datos";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

            }
        }

        private void errorBdWindow2()
        {
            string message = "Error al eliminar la cuenta por problemas de acceso a la base de datos";
            string title = "Aviso";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {

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

        private int getLastId()
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
            return (recived == "" || recived == null) ? "'no existente'" : "'" + recived + "'";
        }

        private void bFinalizar_Click(object sender, EventArgs e)
        {
            succesWindow();
            Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            if (seleccionado != null)
            {
                deleteParticular(seleccionado.Cells[0].Value.ToString());
                tablaRelacionados.Rows.Remove(seleccionado);
                loadRelated();
            }
        }

        private void deleteParticular(String nif)
        {
            MySqlConnection conn = new MySqlConnection(connection_data);
            conn.Open();

            string sql_rel = "DELETE FROM related WHERE nif = '" + nif + "';";
            var command = new MySqlCommand(sql_rel, conn);

            int result = command.ExecuteNonQuery();

            if (result < 1)
            {
                errorBdWindow2();
            }

            string sql_part = "DELETE FROM particular WHERE nif = '" + nif + "';";
            command = new MySqlCommand(sql_part, conn);

            result = command.ExecuteNonQuery();

            if (result < 1)
            {
                errorBdWindow2();
            }

            string sql_cust = "DELETE FROM customer WHERE nif = '" + nif + "';";
            command = new MySqlCommand(sql_cust, conn);

            result = command.ExecuteNonQuery();

            if (result < 1)
            {
                errorBdWindow2();
            }

            conn.Close();
        }

        private String getType(String type)
        {
            return (type == "Socio") ? "Partner" : "Representative";
        }

        private void tablaRelacionados_SelectionChanged(object sender, EventArgs e)
        {
            if (tablaRelacionados.SelectedRows.Count > 0)
            {
                seleccionado = tablaRelacionados.SelectedRows[0];
            }
            else
            {
                seleccionado = null;
            }
        }
    }
}
