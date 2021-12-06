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
    public partial class Index : Form
    {

        private User user = null;

        public Index()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            user = new User(tUsername.Text, tPassword.Text);
            showButtons();
        }

        private void showButtons()
        {
            labelConnected.Visible = false;
        }
    }
}
