﻿namespace ebury_client
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.lBienvenido = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lNombre = new System.Windows.Forms.Label();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bHolanda = new System.Windows.Forms.Button();
            this.bAlemania = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.pictureDefault = new System.Windows.Forms.PictureBox();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHome2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lTusCuentas = new System.Windows.Forms.Label();
            this.panelHome3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkRegistro = new System.Windows.Forms.LinkLabel();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            this.panelHome1.SuspendLayout();
            this.panelHome2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelHome3.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(57, 162);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(79, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Usuario";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(57, 226);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(114, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Contraseña";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(59, 190);
            this.tUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(269, 22);
            this.tUsername.TabIndex = 3;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(59, 254);
            this.tPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(269, 22);
            this.tPassword.TabIndex = 4;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLogin.Location = new System.Drawing.Point(133, 315);
            this.bLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(129, 44);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "Iniciar Sesión";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelRight.Controls.Add(this.linkRegistro);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.pictureRight);
            this.panelRight.Controls.Add(this.labelUsername);
            this.panelRight.Controls.Add(this.bLogin);
            this.panelRight.Controls.Add(this.tUsername);
            this.panelRight.Controls.Add(this.tPassword);
            this.panelRight.Controls.Add(this.labelPassword);
            this.panelRight.Location = new System.Drawing.Point(457, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(380, 496);
            this.panelRight.TabIndex = 7;
            // 
            // pictureRight
            // 
            this.pictureRight.Image = global::ebury_client.Properties.Resources.EburyLogo;
            this.pictureRight.Location = new System.Drawing.Point(133, 71);
            this.pictureRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(140, 47);
            this.pictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRight.TabIndex = 0;
            this.pictureRight.TabStop = false;
            // 
            // lBienvenido
            // 
            this.lBienvenido.AutoSize = true;
            this.lBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBienvenido.Location = new System.Drawing.Point(88, 9);
            this.lBienvenido.Name = "lBienvenido";
            this.lBienvenido.Size = new System.Drawing.Size(114, 25);
            this.lBienvenido.TabIndex = 9;
            this.lBienvenido.Text = "Bienvenido,";
            this.lBienvenido.Visible = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft.Controls.Add(this.lNombre);
            this.panelLeft.Controls.Add(this.bDisconnect);
            this.panelLeft.Controls.Add(this.bHolanda);
            this.panelLeft.Controls.Add(this.bAlemania);
            this.panelLeft.Controls.Add(this.bHome);
            this.panelLeft.Controls.Add(this.pictureDefault);
            this.panelLeft.Controls.Add(this.lBienvenido);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(288, 527);
            this.panelLeft.TabIndex = 10;
            this.panelLeft.Visible = false;
            // 
            // lNombre
            // 
            this.lNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(116, 34);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 20);
            this.lNombre.TabIndex = 14;
            this.lNombre.Text = "$user";
            this.lNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bDisconnect
            // 
            this.bDisconnect.BackColor = System.Drawing.Color.DarkRed;
            this.bDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDisconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDisconnect.Location = new System.Drawing.Point(69, 408);
            this.bDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(145, 46);
            this.bDisconnect.TabIndex = 11;
            this.bDisconnect.Text = "Desconectarse";
            this.bDisconnect.UseVisualStyleBackColor = false;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bHolanda
            // 
            this.bHolanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHolanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHolanda.Location = new System.Drawing.Point(12, 315);
            this.bHolanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bHolanda.Name = "bHolanda";
            this.bHolanda.Size = new System.Drawing.Size(263, 45);
            this.bHolanda.TabIndex = 13;
            this.bHolanda.Text = "Informe Holanda";
            this.bHolanda.UseVisualStyleBackColor = true;
            this.bHolanda.Visible = false;
            this.bHolanda.Click += new System.EventHandler(this.bHolanda_Click);
            // 
            // bAlemania
            // 
            this.bAlemania.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAlemania.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAlemania.Location = new System.Drawing.Point(12, 254);
            this.bAlemania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAlemania.Name = "bAlemania";
            this.bAlemania.Size = new System.Drawing.Size(263, 45);
            this.bAlemania.TabIndex = 12;
            this.bAlemania.Text = "Informe Alemania";
            this.bAlemania.UseVisualStyleBackColor = true;
            this.bAlemania.Visible = false;
            this.bAlemania.Click += new System.EventHandler(this.bAlemania_Click);
            // 
            // bHome
            // 
            this.bHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bHome.Location = new System.Drawing.Point(12, 190);
            this.bHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(263, 45);
            this.bHome.TabIndex = 11;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Visible = false;
            // 
            // pictureDefault
            // 
            this.pictureDefault.Image = global::ebury_client.Properties.Resources.Default;
            this.pictureDefault.Location = new System.Drawing.Point(93, 71);
            this.pictureDefault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureDefault.Name = "pictureDefault";
            this.pictureDefault.Size = new System.Drawing.Size(100, 100);
            this.pictureDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDefault.TabIndex = 10;
            this.pictureDefault.TabStop = false;
            this.pictureDefault.Visible = false;
            // 
            // pictureLeft
            // 
            this.pictureLeft.Image = global::ebury_client.Properties.Resources.EburyPic;
            this.pictureLeft.Location = new System.Drawing.Point(0, 0);
            this.pictureLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(467, 496);
            this.pictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLeft.TabIndex = 8;
            this.pictureLeft.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "HOME";
            // 
            // panelHome1
            // 
            this.panelHome1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelHome1.Controls.Add(this.label2);
            this.panelHome1.Controls.Add(this.label1);
            this.panelHome1.Location = new System.Drawing.Point(294, 0);
            this.panelHome1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHome1.Name = "panelHome1";
            this.panelHome1.Size = new System.Drawing.Size(536, 83);
            this.panelHome1.TabIndex = 13;
            this.panelHome1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tus cuentas y últimas transacciones en un mismo lugar.";
            // 
            // panelHome2
            // 
            this.panelHome2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelHome2.Controls.Add(this.dataGridView);
            this.panelHome2.Controls.Add(this.lTusCuentas);
            this.panelHome2.Location = new System.Drawing.Point(294, 87);
            this.panelHome2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHome2.Name = "panelHome2";
            this.panelHome2.Size = new System.Drawing.Size(536, 310);
            this.panelHome2.TabIndex = 14;
            this.panelHome2.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 62);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(457, 228);
            this.dataGridView.TabIndex = 15;
            // 
            // lTusCuentas
            // 
            this.lTusCuentas.AutoSize = true;
            this.lTusCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTusCuentas.Location = new System.Drawing.Point(19, 17);
            this.lTusCuentas.Name = "lTusCuentas";
            this.lTusCuentas.Size = new System.Drawing.Size(183, 29);
            this.lTusCuentas.TabIndex = 14;
            this.lTusCuentas.Text = "TUS CUENTAS";
            // 
            // panelHome3
            // 
            this.panelHome3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelHome3.Controls.Add(this.label3);
            this.panelHome3.Location = new System.Drawing.Point(294, 401);
            this.panelHome3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHome3.Name = "panelHome3";
            this.panelHome3.Size = new System.Drawing.Size(536, 93);
            this.panelHome3.TabIndex = 15;
            this.panelHome3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ebury Client App, Todos los derechos reservados.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "¿No estás registrado aún?";
            // 
            // linkRegistro
            // 
            this.linkRegistro.AutoSize = true;
            this.linkRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkRegistro.Location = new System.Drawing.Point(161, 401);
            this.linkRegistro.Name = "linkRegistro";
            this.linkRegistro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.linkRegistro.Size = new System.Drawing.Size(73, 17);
            this.linkRegistro.TabIndex = 7;
            this.linkRegistro.TabStop = true;
            this.linkRegistro.Text = "Regístrate";
            this.linkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistro_LinkClicked);
            // 
            // Index
            // 
            this.AcceptButton = this.bLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(832, 476);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelHome3);
            this.Controls.Add(this.panelHome1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHome2);
            this.Controls.Add(this.pictureLeft);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 523);
            this.MinimumSize = new System.Drawing.Size(850, 523);
            this.Name = "Index";
            this.Text = "Ebury Client APP";
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).EndInit();
            this.panelHome1.ResumeLayout(false);
            this.panelHome1.PerformLayout();
            this.panelHome2.ResumeLayout(false);
            this.panelHome2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelHome3.ResumeLayout(false);
            this.panelHome3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.Label lBienvenido;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureDefault;
        private System.Windows.Forms.Button bHolanda;
        private System.Windows.Forms.Button bAlemania;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHome1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelHome2;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelHome3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lTusCuentas;
        private System.Windows.Forms.LinkLabel linkRegistro;
        private System.Windows.Forms.Label label4;
    }
}

