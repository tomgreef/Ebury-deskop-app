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
    public partial class NetherlandsInform : Form
    {
        private User mainUser;
        private string[] colClientes = { "username", "startDate", "endDate" , "nif"},
            colCuentasBancarias = { "accountNumber" , "balance", "currency" };

        public NetherlandsInform(User u)
        {
            InitializeComponent();
            this.mainUser = u;
            showLeftPannel();
        }

        private void showLeftPannel()
        {
            bAlemania.Visible = false;
            bHolanda.Visible = false;
            pictureDefault.Visible = true;
            panelLeft.Visible = true;
            bHome.Visible = true;
            labelUser.Visible = true;
            labelHello.Visible = true;
            labelUser.Text = mainUser.userName;
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tFiltro_Click(object sender, EventArgs e)
        {
            tFiltro.Text = "";
        }

        private void bAlemania_Click(object sender, EventArgs e)
        {
            Visible = false;
            Close();
            GermanyInfrom GI = new GermanyInfrom(mainUser);
            GI.ShowDialog();
        }

        private void bConexion_Click(object sender, EventArgs e)
        {
            string connStr = "server=eburyrequisitos.cobadwnzalab.eu-central-1.rds.amazonaws.com;user=grupo03;database=grupo03DB;port=3306;password=2zzd92Xe7sr4BRxW";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                lEstado.Text = "Conectado";
                lEstado.ForeColor = System.Drawing.Color.Green;
            }
            catch
            {
                lEstado.Text = "Desconectado";
                lEstado.ForeColor = System.Drawing.Color.Red;
            }
            conn.Close();
        }

        private void bHome_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
