namespace ebury_client
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.bLogin = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureRight = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bHolanda = new System.Windows.Forms.Button();
            this.bAlemania = new System.Windows.Forms.Button();
            this.bHome = new System.Windows.Forms.Button();
            this.pictureDefault = new System.Windows.Forms.PictureBox();
            this.pictureLeft = new System.Windows.Forms.PictureBox();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHome1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelHome2 = new System.Windows.Forms.Panel();
            this.lTusCuentas = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRight)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLeft)).BeginInit();
            this.panelHome1.SuspendLayout();
            this.panelHome2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(35, 143);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(102, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(35, 208);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(37, 170);
            this.tUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(269, 22);
            this.tUsername.TabIndex = 3;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(37, 235);
            this.tPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(269, 22);
            this.tPassword.TabIndex = 4;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bLogin.Location = new System.Drawing.Point(131, 282);
            this.bLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(84, 44);
            this.bLogin.TabIndex = 5;
            this.bLogin.Text = "LOGIN";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(133, 28);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(61, 25);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "name";
            this.labelUser.Visible = false;
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelRight.Controls.Add(this.pictureRight);
            this.panelRight.Controls.Add(this.labelUsername);
            this.panelRight.Controls.Add(this.bLogin);
            this.panelRight.Controls.Add(this.tUsername);
            this.panelRight.Controls.Add(this.tPassword);
            this.panelRight.Controls.Add(this.labelPassword);
            this.panelRight.Location = new System.Drawing.Point(411, 57);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(349, 350);
            this.panelRight.TabIndex = 7;
            // 
            // pictureRight
            // 
            this.pictureRight.Image = global::ebury_client.Properties.Resources.EburyLogo;
            this.pictureRight.Location = new System.Drawing.Point(37, 27);
            this.pictureRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureRight.Name = "pictureRight";
            this.pictureRight.Size = new System.Drawing.Size(269, 89);
            this.pictureRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureRight.TabIndex = 0;
            this.pictureRight.TabStop = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(75, 28);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(61, 25);
            this.labelHello.TabIndex = 9;
            this.labelHello.Text = "Hello,";
            this.labelHello.Visible = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft.Controls.Add(this.bHolanda);
            this.panelLeft.Controls.Add(this.bDisconnect);
            this.panelLeft.Controls.Add(this.bAlemania);
            this.panelLeft.Controls.Add(this.bHome);
            this.panelLeft.Controls.Add(this.pictureDefault);
            this.panelLeft.Controls.Add(this.labelHello);
            this.panelLeft.Controls.Add(this.labelUser);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(288, 523);
            this.panelLeft.TabIndex = 10;
            this.panelLeft.Visible = false;
            // 
            // bHolanda
            // 
            this.bHolanda.Location = new System.Drawing.Point(0, 377);
            this.bHolanda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bHolanda.Name = "bHolanda";
            this.bHolanda.Size = new System.Drawing.Size(288, 87);
            this.bHolanda.TabIndex = 13;
            this.bHolanda.Text = "Informe Holanda";
            this.bHolanda.UseVisualStyleBackColor = true;
            this.bHolanda.Visible = false;
            this.bHolanda.Click += new System.EventHandler(this.bHolanda_Click);
            // 
            // bAlemania
            // 
            this.bAlemania.Location = new System.Drawing.Point(0, 284);
            this.bAlemania.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAlemania.Name = "bAlemania";
            this.bAlemania.Size = new System.Drawing.Size(288, 87);
            this.bAlemania.TabIndex = 12;
            this.bAlemania.Text = "Informe Alemania";
            this.bAlemania.UseVisualStyleBackColor = true;
            this.bAlemania.Visible = false;
            this.bAlemania.Click += new System.EventHandler(this.bAlemania_Click);
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(0, 191);
            this.bHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(288, 87);
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
            this.pictureLeft.Location = new System.Drawing.Point(61, 57);
            this.pictureLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureLeft.Name = "pictureLeft";
            this.pictureLeft.Size = new System.Drawing.Size(349, 350);
            this.pictureLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLeft.TabIndex = 8;
            this.pictureLeft.TabStop = false;
            // 
            // bDisconnect
            // 
            this.bDisconnect.BackColor = System.Drawing.Color.DarkRed;
            this.bDisconnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDisconnect.Location = new System.Drawing.Point(93, 470);
            this.bDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(100, 40);
            this.bDisconnect.TabIndex = 11;
            this.bDisconnect.Text = "Logout";
            this.bDisconnect.UseVisualStyleBackColor = false;
            this.bDisconnect.Visible = false;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "HOME";
            // 
            // panelHome1
            // 
            this.panelHome1.Controls.Add(this.label2);
            this.panelHome1.Controls.Add(this.label1);
            this.panelHome1.Location = new System.Drawing.Point(303, 14);
            this.panelHome1.Name = "panelHome1";
            this.panelHome1.Size = new System.Drawing.Size(516, 78);
            this.panelHome1.TabIndex = 13;
            this.panelHome1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tus cuentas y últimas transacciones en el mismo lugar.";
            // 
            // panelHome2
            // 
            this.panelHome2.Controls.Add(this.dataGridView);
            this.panelHome2.Controls.Add(this.lTusCuentas);
            this.panelHome2.Location = new System.Drawing.Point(303, 99);
            this.panelHome2.Name = "panelHome2";
            this.panelHome2.Size = new System.Drawing.Size(516, 410);
            this.panelHome2.TabIndex = 14;
            this.panelHome2.Visible = false;
            // 
            // lTusCuentas
            // 
            this.lTusCuentas.AutoSize = true;
            this.lTusCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTusCuentas.Location = new System.Drawing.Point(18, 17);
            this.lTusCuentas.Name = "lTusCuentas";
            this.lTusCuentas.Size = new System.Drawing.Size(183, 29);
            this.lTusCuentas.TabIndex = 14;
            this.lTusCuentas.Text = "TUS CUENTAS";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(472, 157);
            this.dataGridView.TabIndex = 15;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 521);
            this.Controls.Add(this.panelHome2);
            this.Controls.Add(this.panelHome1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.pictureLeft);
            this.Controls.Add(this.panelRight);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Index";
            this.Text = "Index";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureRight;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox pictureLeft;
        private System.Windows.Forms.Label labelHello;
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
        private System.Windows.Forms.Label lTusCuentas;
    }
}

