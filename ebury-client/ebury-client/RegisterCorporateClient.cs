using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebury_client
{
    public partial class RegisterCorporateClient : Form
    {
        private static string BD_SERVER = Properties.Settings.Default.BD_SERVER;
        private static string BD_NAME = Properties.Settings.Default.BD_NAME;
        private static string BD_USER = Properties.Settings.Default.BD_USER;
        private static string BD_PASSWORD = Properties.Settings.Default.BD_PASSWORD;

        private string connection_data = "server=" + BD_SERVER + ";user=" + BD_USER
                + ";database=" + BD_NAME + ";port=3306" + ";password=" + BD_PASSWORD;

        public RegisterCorporateClient()
        {
            InitializeComponent();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bRegistrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connection_data);
            try
            {
                
                FormatException f = new FormatException("No se ha podido crear la cuenta porque" +
                    " hay datos obligatorios que no han sido rellenados o datos con formato incorrecto.");
                String[] obligatorios = {tCIF.Text, tPrimerNombre.Text, tContrasena.Text, tRepetirContrasena.Text, 
                    tCalle.Text, tPuerta.Text, tCiudad.Text, tPais.Text, tCP.Text};

                // Mira si los campos obligatorios no son nulos o vacíos.
                foreach (String s in obligatorios)
                {
                    if (String.IsNullOrEmpty(s))
                        throw f;
                }

                // El CIF ha de ser un texto alfanumérico de nueve caracteres.
                if (tCIF.Text.Length != 9)
                    throw f;

                // El primer carácter ha de ser una letra.
                if (!Char.IsLetter(tCIF.Text[0]))
                    throw f;

                // Los ocho restantes caracteres han de ser números.
                for (int i = 1; i < 9; i++)
                {
                    if (!Char.IsNumber(tCIF.Text[i]))
                        throw f;
                }

                // Las contraseñas de sendos campos han de coincidir.
                if (!tContrasena.Text.Equals(tRepetirContrasena.Text))
                    throw new FormatException("Las contraseñas no coinciden.");

                // Introduce la dirección en la BD primero para completar el campo "id" de la tabla "company".
                string cmd = "INSERT INTO address (street, number, floorOfficeDoor, city, region, " +
                    "postalCode, country, valid) VALUES ('" + tCalle.Text + "', '" + tNumero.Text + "', '" +
                    tPuerta.Text + "', '" + tCiudad.Text + "', '" + tRegion.Text + "', '" + tCP.Text + "', '" +
                    tPais.Text + "', " + (cValida.Checked ? 1 : 0) + ");";
                conn.Open(); // Intenta conectarse a la base de datos.
                MySqlCommand com = new MySqlCommand(cmd, conn);
                com.ExecuteNonQuery();

                // Obtiene la ID de la última dirección para asignarla al campo "address" de la tabla "company"
                // (al ser autoincremental, simplemente se obtiene contando el número de filas de esta tabla).
                com = new MySqlCommand("SELECT COUNT(*) FROM address;", conn);
                int id = Convert.ToInt32(com.ExecuteScalar());

                // Inserta los datos restantes en la tabla "customer".
                cmd = "INSERT INTO customer (nif, username, password, startDate) VALUES ('" +
                    tCIF.Text + "', '" + tPrimerNombre.Text + "', '" + tContrasena.Text + "', '" +
                        DateTime.Now.ToString("yyyy-MM-dd") + "');";
                com = new MySqlCommand(cmd, conn);
                com.ExecuteNonQuery();

                // Ahora en la tabla "company".
                cmd = "INSERT INTO company VALUES('" + tPrimerNombre.Text + "', '" + tCIF.Text + "', " + id + ");";
                com = new MySqlCommand(cmd, conn);
                com.ExecuteNonQuery();

                // Salta a la parte de asignar clientes a esta empresa.
                Close();
                GestionCorporateClient g = new GestionCorporateClient(new User(tPrimerNombre.Text, tContrasena.Text));
                g.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                tContrasena.Text = "";
                tRepetirContrasena.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se ha podido crear la cuenta por problema de acceso a la base de datos.");
                Close();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
