﻿using System;
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
    public partial class GestionCorporateClient : Form
    {
        private User u;

        public GestionCorporateClient(User u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void GestionCorporateClient_Load(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
