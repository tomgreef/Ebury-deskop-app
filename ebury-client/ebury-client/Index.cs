using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using BDLibrary;

namespace ebury_client
{
    public partial class Index : Form
    {

        private User user = null;
        private string[] colCuentasBancarias = { "accountNumber", "balance" };

        public Index()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user = new User(tUsername.Text, tPassword.Text);
                connected();
            }
            catch
            {
                MessageBox.Show("Usuario/Contraseña Incorrecta");
            }
        }

        private void connected()
        {
            //Muestro
            labelUser.Visible = true;
            labelHello.Visible = true;
            labelUser.Text = user.userName;
            bAlemania.Visible = true;
            bHolanda.Visible = true;
            pictureDefault.Visible = true;
            panelLeft.Visible = true;
            bHome.Visible = true;
            bDisconnect.Visible = true;
            panelHome1.Visible = true;
            panelHome2.Visible = true;

            // Oculto
            tUsername.Text = "";
            tPassword.Text = "";
            labelPassword.Visible = false;
            labelUsername.Visible = false;
            panelRight.Visible = false;
            bLogin.Visible = false;
            pictureLeft.Visible = false;
            pictureRight.Visible = false;
            tUsername.Visible = false;
            tPassword.Visible = false;

            //Cargo los datos
            string connection_data = "server=eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com;user=grupo03;database=grupo03DB;port=3306;password=2zzd92Xe7sr4BRxW";

            MySqlConnection co = null;

            try
            {
                co = new MySqlConnection(connection_data);
                co.Open();
                Console.Write("NIF: " + user.Nif + "\n");
                mostrarDatos(colCuentasBancarias, "SELECT accountNumber, balance, nif FROM customer JOIN " 
                + "particular USING (nif) JOIN customerXAccount USING(nif) JOIN eburyAccount "
                + "USING(accountNumber) WHERE nif = " + user.Nif);
            }
            catch (Exception e)
            {
                throw new Error("Error al recuperar los datos de las cuentas bancarias.");
            }
            finally
            {
                if (co != null)
                {
                    co.Close();
                }
            }
        }

        private void disconnected()
        {
            //Oculto
            labelUser.Visible = false;
            labelHello.Visible = false;
            bAlemania.Visible = false;
            bHolanda.Visible = false;
            pictureDefault.Visible = false;
            panelLeft.Visible = false;
            bHome.Visible = false;
            bDisconnect.Visible = false;
            panelHome1.Visible = false;
            panelHome2.Visible = false;

            //Muestro
            labelPassword.Visible = true;
            labelUsername.Visible = true;
            panelRight.Visible = true;
            bLogin.Visible = true;
            pictureLeft.Visible = true;
            pictureRight.Visible = true;
            tUsername.Visible = true;
            tPassword.Visible = true;
        }

        private void bDisconnect_Click(object sender, EventArgs e)
        {
            disconnected();
        }

        private void bAlemania_Click(object sender, EventArgs e)
        {
            
           GermanyInfrom GI = new GermanyInfrom(user);
           this.Visible = false;
           GI.ShowDialog();
           this.Visible = true; 
        }

        private void bHolanda_Click(object sender, EventArgs e)
        {
            NetherlandsInform NI = new NetherlandsInform(user);
            this.Visible = false;
            NI.ShowDialog();
            this.Visible = true;
        }

        private void mostrarDatos(string[] columns, string command)
        {
            string connStr = "server=eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com;user=grupo03;database=grupo03DB;port=3306;password=2zzd92Xe7sr4BRxW";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                dataGridView.ColumnCount = columns.Length;
                for (int i = 0; i < columns.Length; i++)
                    dataGridView.Columns[i].Name = columns[i];

                MySqlDataReader rdr = new MySqlCommand(command, conn).ExecuteReader();
                while (rdr.Read())
                {
                    int tam = rdr.FieldCount;
                    string[] lect = new string[tam];
                    for (int i = 0; i < tam; i++)
                    {
                        string str = rdr[i].ToString();
                        lect[i] = !String.Equals(str, "") ? str : "no existente";
                    }
                    dataGridView.Rows.Add(lect);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

    }
}
