namespace ebury_client
{
    partial class NetherlandsInform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bConexion = new System.Windows.Forms.Button();
            this.lEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pClientes = new System.Windows.Forms.Panel();
            this.lFiltro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tFiltro = new System.Windows.Forms.TextBox();
            this.bFiltrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bDescargar = new System.Windows.Forms.Button();
            this.cSeleccion = new System.Windows.Forms.ComboBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.bHome = new System.Windows.Forms.Button();
            this.pictureDefault = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.pCuentas = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cInactivas = new System.Windows.Forms.CheckBox();
            this.cActivas = new System.Windows.Forms.CheckBox();
            this.bAlemania = new System.Windows.Forms.Button();
            this.bHolanda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pClientes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefault)).BeginInit();
            this.pCuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bConexion);
            this.panel1.Controls.Add(this.lEstado);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(242, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 109);
            this.panel1.TabIndex = 2;
            // 
            // bConexion
            // 
            this.bConexion.Location = new System.Drawing.Point(19, 83);
            this.bConexion.Name = "bConexion";
            this.bConexion.Size = new System.Drawing.Size(93, 23);
            this.bConexion.TabIndex = 2;
            this.bConexion.Text = "Health Check";
            this.bConexion.UseVisualStyleBackColor = true;
            this.bConexion.Click += new System.EventHandler(this.bConexion_Click);
            // 
            // lEstado
            // 
            this.lEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEstado.Location = new System.Drawing.Point(19, 44);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(93, 18);
            this.lEstado.TabIndex = 1;
            this.lEstado.Text = "...";
            this.lEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estado";
            // 
            // pClientes
            // 
            this.pClientes.Controls.Add(this.lFiltro);
            this.pClientes.Controls.Add(this.label3);
            this.pClientes.Controls.Add(this.tFiltro);
            this.pClientes.Controls.Add(this.bFiltrar);
            this.pClientes.Location = new System.Drawing.Point(242, 139);
            this.pClientes.Name = "pClientes";
            this.pClientes.Size = new System.Drawing.Size(401, 109);
            this.pClientes.TabIndex = 3;
            // 
            // lFiltro
            // 
            this.lFiltro.AutoSize = true;
            this.lFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFiltro.Location = new System.Drawing.Point(23, 41);
            this.lFiltro.Name = "lFiltro";
            this.lFiltro.Size = new System.Drawing.Size(57, 16);
            this.lFiltro.TabIndex = 4;
            this.lFiltro.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtrar por:";
            // 
            // tFiltro
            // 
            this.tFiltro.Location = new System.Drawing.Point(92, 41);
            this.tFiltro.Name = "tFiltro";
            this.tFiltro.Size = new System.Drawing.Size(215, 20);
            this.tFiltro.TabIndex = 1;
            this.tFiltro.Click += new System.EventHandler(this.tFiltro_Click);
            // 
            // bFiltrar
            // 
            this.bFiltrar.Location = new System.Drawing.Point(22, 83);
            this.bFiltrar.Name = "bFiltrar";
            this.bFiltrar.Size = new System.Drawing.Size(75, 23);
            this.bFiltrar.TabIndex = 0;
            this.bFiltrar.Text = "Filtrar";
            this.bFiltrar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bDescargar);
            this.panel3.Location = new System.Drawing.Point(511, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(132, 111);
            this.panel3.TabIndex = 4;
            // 
            // bDescargar
            // 
            this.bDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDescargar.Location = new System.Drawing.Point(3, 31);
            this.bDescargar.Name = "bDescargar";
            this.bDescargar.Size = new System.Drawing.Size(126, 46);
            this.bDescargar.TabIndex = 0;
            this.bDescargar.Text = "Descargar";
            this.bDescargar.UseVisualStyleBackColor = true;
            // 
            // cSeleccion
            // 
            this.cSeleccion.FormattingEnabled = true;
            this.cSeleccion.Items.AddRange(new object[] {
            "Clientes",
            "Cuentas bancarias"});
            this.cSeleccion.Location = new System.Drawing.Point(242, 101);
            this.cSeleccion.Name = "cSeleccion";
            this.cSeleccion.Size = new System.Drawing.Size(254, 21);
            this.cSeleccion.TabIndex = 6;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLeft.Controls.Add(this.bHolanda);
            this.panelLeft.Controls.Add(this.bAlemania);
            this.panelLeft.Controls.Add(this.bHome);
            this.panelLeft.Controls.Add(this.pictureDefault);
            this.panelLeft.Controls.Add(this.labelHello);
            this.panelLeft.Controls.Add(this.labelUser);
            this.panelLeft.Location = new System.Drawing.Point(0, -1);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(218, 416);
            this.panelLeft.TabIndex = 12;
            this.panelLeft.Visible = false;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(0, 155);
            this.bHome.Margin = new System.Windows.Forms.Padding(2);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(216, 71);
            this.bHome.TabIndex = 11;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Visible = false;
            this.bHome.Click += new System.EventHandler(this.bHome_Click_1);
            // 
            // pictureDefault
            // 
            this.pictureDefault.Image = global::ebury_client.Properties.Resources.Default;
            this.pictureDefault.Location = new System.Drawing.Point(70, 58);
            this.pictureDefault.Margin = new System.Windows.Forms.Padding(2);
            this.pictureDefault.Name = "pictureDefault";
            this.pictureDefault.Size = new System.Drawing.Size(75, 81);
            this.pictureDefault.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDefault.TabIndex = 10;
            this.pictureDefault.TabStop = false;
            this.pictureDefault.Visible = false;
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(56, 23);
            this.labelHello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(49, 20);
            this.labelHello.TabIndex = 9;
            this.labelHello.Text = "Hello,";
            this.labelHello.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(100, 23);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(49, 20);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "name";
            this.labelUser.Visible = false;
            // 
            // pCuentas
            // 
            this.pCuentas.Controls.Add(this.label2);
            this.pCuentas.Controls.Add(this.cInactivas);
            this.pCuentas.Controls.Add(this.cActivas);
            this.pCuentas.Location = new System.Drawing.Point(242, 139);
            this.pCuentas.Name = "pCuentas";
            this.pCuentas.Size = new System.Drawing.Size(401, 109);
            this.pCuentas.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtro por:";
            // 
            // cInactivas
            // 
            this.cInactivas.AutoSize = true;
            this.cInactivas.Location = new System.Drawing.Point(269, 60);
            this.cInactivas.Name = "cInactivas";
            this.cInactivas.Size = new System.Drawing.Size(69, 17);
            this.cInactivas.TabIndex = 1;
            this.cInactivas.Text = "Inactivas";
            this.cInactivas.UseVisualStyleBackColor = true;
            // 
            // cActivas
            // 
            this.cActivas.AutoSize = true;
            this.cActivas.Location = new System.Drawing.Point(51, 60);
            this.cActivas.Name = "cActivas";
            this.cActivas.Size = new System.Drawing.Size(61, 17);
            this.cActivas.TabIndex = 0;
            this.cActivas.Text = "Activas";
            this.cActivas.UseVisualStyleBackColor = true;
            // 
            // bAlemania
            // 
            this.bAlemania.Location = new System.Drawing.Point(0, 231);
            this.bAlemania.Margin = new System.Windows.Forms.Padding(2);
            this.bAlemania.Name = "bAlemania";
            this.bAlemania.Size = new System.Drawing.Size(216, 71);
            this.bAlemania.TabIndex = 12;
            this.bAlemania.Text = "Informe Alemania";
            this.bAlemania.UseVisualStyleBackColor = true;
            this.bAlemania.Visible = false;
            // 
            // bHolanda
            // 
            this.bHolanda.Location = new System.Drawing.Point(0, 306);
            this.bHolanda.Margin = new System.Windows.Forms.Padding(2);
            this.bHolanda.Name = "bHolanda";
            this.bHolanda.Size = new System.Drawing.Size(216, 71);
            this.bHolanda.TabIndex = 13;
            this.bHolanda.Text = "Informe Holanda";
            this.bHolanda.UseVisualStyleBackColor = true;
            this.bHolanda.Visible = false;
            // 
            // NetherlandsInform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 412);
            this.Controls.Add(this.pCuentas);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.cSeleccion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pClientes);
            this.Controls.Add(this.panel1);
            this.Name = "NetherlandsInform";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pClientes.ResumeLayout(false);
            this.pClientes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDefault)).EndInit();
            this.pCuentas.ResumeLayout(false);
            this.pCuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bConexion;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pClientes;
        private System.Windows.Forms.Button bFiltrar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bDescargar;
        private System.Windows.Forms.ComboBox cSeleccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tFiltro;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button bHome;
        private System.Windows.Forms.PictureBox pictureDefault;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label lFiltro;
        private System.Windows.Forms.Panel pCuentas;
        private System.Windows.Forms.CheckBox cInactivas;
        private System.Windows.Forms.CheckBox cActivas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bHolanda;
        private System.Windows.Forms.Button bAlemania;
    }
}