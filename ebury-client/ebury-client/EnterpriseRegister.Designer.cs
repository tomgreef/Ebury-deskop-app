namespace ebury_client
{
    partial class RegistroEmpresa
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
            this.lDatos = new System.Windows.Forms.Label();
            this.lRegistroEmpresa = new System.Windows.Forms.Label();
            this.lCIF = new System.Windows.Forms.Label();
            this.tCIF = new System.Windows.Forms.TextBox();
            this.lNombreEmpresa = new System.Windows.Forms.Label();
            this.tNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lDireccion = new System.Windows.Forms.Label();
            this.lCalle = new System.Windows.Forms.Label();
            this.lPlanta = new System.Windows.Forms.Label();
            this.lCiudad = new System.Windows.Forms.Label();
            this.lPais = new System.Windows.Forms.Label();
            this.lNumero = new System.Windows.Forms.Label();
            this.lNombre2 = new System.Windows.Forms.Label();
            this.lRegion = new System.Windows.Forms.Label();
            this.lCP = new System.Windows.Forms.Label();
            this.checkValida = new System.Windows.Forms.CheckBox();
            this.tCalle = new System.Windows.Forms.TextBox();
            this.tPlanta = new System.Windows.Forms.TextBox();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.tCiudad = new System.Windows.Forms.TextBox();
            this.tPais = new System.Windows.Forms.TextBox();
            this.tRegion = new System.Windows.Forms.TextBox();
            this.tCP = new System.Windows.Forms.TextBox();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tPassRepetir = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lPassRepetir = new System.Windows.Forms.Label();
            this.bRegistrar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lDatos
            // 
            this.lDatos.AutoSize = true;
            this.lDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDatos.Location = new System.Drawing.Point(12, 40);
            this.lDatos.Name = "lDatos";
            this.lDatos.Size = new System.Drawing.Size(134, 16);
            this.lDatos.TabIndex = 0;
            this.lDatos.Text = "Datos de la empresa";
            // 
            // lRegistroEmpresa
            // 
            this.lRegistroEmpresa.AutoSize = true;
            this.lRegistroEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRegistroEmpresa.Location = new System.Drawing.Point(203, 9);
            this.lRegistroEmpresa.Name = "lRegistroEmpresa";
            this.lRegistroEmpresa.Size = new System.Drawing.Size(223, 20);
            this.lRegistroEmpresa.TabIndex = 1;
            this.lRegistroEmpresa.Text = "REGISTRO DE EMPRESA";
            // 
            // lCIF
            // 
            this.lCIF.AutoSize = true;
            this.lCIF.Location = new System.Drawing.Point(12, 71);
            this.lCIF.Name = "lCIF";
            this.lCIF.Size = new System.Drawing.Size(36, 13);
            this.lCIF.TabIndex = 2;
            this.lCIF.Text = "CIF (*)";
            // 
            // tCIF
            // 
            this.tCIF.Location = new System.Drawing.Point(72, 68);
            this.tCIF.Name = "tCIF";
            this.tCIF.Size = new System.Drawing.Size(149, 20);
            this.tCIF.TabIndex = 3;
            // 
            // lNombreEmpresa
            // 
            this.lNombreEmpresa.AutoSize = true;
            this.lNombreEmpresa.Location = new System.Drawing.Point(12, 101);
            this.lNombreEmpresa.Name = "lNombreEmpresa";
            this.lNombreEmpresa.Size = new System.Drawing.Size(126, 13);
            this.lNombreEmpresa.TabIndex = 4;
            this.lNombreEmpresa.Text = "Nombre de la empresa (*)";
            // 
            // tNombreEmpresa
            // 
            this.tNombreEmpresa.Location = new System.Drawing.Point(144, 98);
            this.tNombreEmpresa.Name = "tNombreEmpresa";
            this.tNombreEmpresa.Size = new System.Drawing.Size(489, 20);
            this.tNombreEmpresa.TabIndex = 5;
            // 
            // lDireccion
            // 
            this.lDireccion.AutoSize = true;
            this.lDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDireccion.Location = new System.Drawing.Point(12, 161);
            this.lDireccion.Name = "lDireccion";
            this.lDireccion.Size = new System.Drawing.Size(65, 16);
            this.lDireccion.TabIndex = 6;
            this.lDireccion.Text = "Dirección";
            // 
            // lCalle
            // 
            this.lCalle.AutoSize = true;
            this.lCalle.Location = new System.Drawing.Point(12, 192);
            this.lCalle.Name = "lCalle";
            this.lCalle.Size = new System.Drawing.Size(43, 13);
            this.lCalle.TabIndex = 7;
            this.lCalle.Text = "Calle (*)";
            // 
            // lPlanta
            // 
            this.lPlanta.AutoSize = true;
            this.lPlanta.Location = new System.Drawing.Point(12, 225);
            this.lPlanta.Name = "lPlanta";
            this.lPlanta.Size = new System.Drawing.Size(124, 13);
            this.lPlanta.TabIndex = 8;
            this.lPlanta.Text = "Planta/Puerta/Oficina (*)";
            // 
            // lCiudad
            // 
            this.lCiudad.AutoSize = true;
            this.lCiudad.Location = new System.Drawing.Point(12, 254);
            this.lCiudad.Name = "lCiudad";
            this.lCiudad.Size = new System.Drawing.Size(53, 13);
            this.lCiudad.TabIndex = 9;
            this.lCiudad.Text = "Ciudad (*)";
            // 
            // lPais
            // 
            this.lPais.AutoSize = true;
            this.lPais.Location = new System.Drawing.Point(12, 280);
            this.lPais.Name = "lPais";
            this.lPais.Size = new System.Drawing.Size(42, 13);
            this.lPais.TabIndex = 10;
            this.lPais.Text = "País (*)";
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumero.Location = new System.Drawing.Point(333, 183);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(57, 13);
            this.lNumero.TabIndex = 11;
            this.lNumero.Text = "Número (*)";
            // 
            // lNombre2
            // 
            this.lNombre2.AutoSize = true;
            this.lNombre2.Location = new System.Drawing.Point(302, 196);
            this.lNombre2.Name = "lNombre2";
            this.lNombre2.Size = new System.Drawing.Size(88, 13);
            this.lNombre2.TabIndex = 12;
            this.lNombre2.Text = "Segundo nombre";
            // 
            // lRegion
            // 
            this.lRegion.AutoSize = true;
            this.lRegion.Location = new System.Drawing.Point(349, 254);
            this.lRegion.Name = "lRegion";
            this.lRegion.Size = new System.Drawing.Size(41, 13);
            this.lRegion.TabIndex = 13;
            this.lRegion.Text = "Región";
            // 
            // lCP
            // 
            this.lCP.AutoSize = true;
            this.lCP.Location = new System.Drawing.Point(350, 280);
            this.lCP.Name = "lCP";
            this.lCP.Size = new System.Drawing.Size(40, 13);
            this.lCP.TabIndex = 14;
            this.lCP.Text = "C.P. (*)";
            // 
            // checkValida
            // 
            this.checkValida.AutoSize = true;
            this.checkValida.Location = new System.Drawing.Point(72, 312);
            this.checkValida.Name = "checkValida";
            this.checkValida.Size = new System.Drawing.Size(141, 17);
            this.checkValida.TabIndex = 15;
            this.checkValida.Text = "Válida (Dirección actual)";
            this.checkValida.UseVisualStyleBackColor = true;
            // 
            // tCalle
            // 
            this.tCalle.Location = new System.Drawing.Point(71, 189);
            this.tCalle.Name = "tCalle";
            this.tCalle.Size = new System.Drawing.Size(150, 20);
            this.tCalle.TabIndex = 16;
            // 
            // tPlanta
            // 
            this.tPlanta.Location = new System.Drawing.Point(144, 222);
            this.tPlanta.Name = "tPlanta";
            this.tPlanta.Size = new System.Drawing.Size(147, 20);
            this.tPlanta.TabIndex = 17;
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(405, 189);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(167, 20);
            this.tNumero.TabIndex = 18;
            // 
            // tCiudad
            // 
            this.tCiudad.Location = new System.Drawing.Point(71, 251);
            this.tCiudad.Name = "tCiudad";
            this.tCiudad.Size = new System.Drawing.Size(150, 20);
            this.tCiudad.TabIndex = 19;
            // 
            // tPais
            // 
            this.tPais.Location = new System.Drawing.Point(71, 277);
            this.tPais.Name = "tPais";
            this.tPais.Size = new System.Drawing.Size(150, 20);
            this.tPais.TabIndex = 20;
            // 
            // tRegion
            // 
            this.tRegion.Location = new System.Drawing.Point(405, 251);
            this.tRegion.Name = "tRegion";
            this.tRegion.Size = new System.Drawing.Size(167, 20);
            this.tRegion.TabIndex = 21;
            // 
            // tCP
            // 
            this.tCP.Location = new System.Drawing.Point(405, 277);
            this.tCP.Name = "tCP";
            this.tCP.Size = new System.Drawing.Size(167, 20);
            this.tCP.TabIndex = 22;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(92, 355);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(161, 20);
            this.tPassword.TabIndex = 23;
            // 
            // tPassRepetir
            // 
            this.tPassRepetir.Location = new System.Drawing.Point(453, 355);
            this.tPassRepetir.Name = "tPassRepetir";
            this.tPassRepetir.Size = new System.Drawing.Size(159, 20);
            this.tPassRepetir.TabIndex = 24;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 358);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(74, 13);
            this.lPassword.TabIndex = 25;
            this.lPassword.Text = "Contraseña (*)";
            // 
            // lPassRepetir
            // 
            this.lPassRepetir.AutoSize = true;
            this.lPassRepetir.Location = new System.Drawing.Point(333, 358);
            this.lPassRepetir.Name = "lPassRepetir";
            this.lPassRepetir.Size = new System.Drawing.Size(114, 13);
            this.lPassRepetir.TabIndex = 26;
            this.lPassRepetir.Text = "Contraseña. Repetir (*)";
            // 
            // bRegistrar
            // 
            this.bRegistrar.Location = new System.Drawing.Point(138, 402);
            this.bRegistrar.Name = "bRegistrar";
            this.bRegistrar.Size = new System.Drawing.Size(75, 23);
            this.bRegistrar.TabIndex = 27;
            this.bRegistrar.Text = "Registrar";
            this.bRegistrar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(425, 402);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 28;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // RegistroEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 437);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bRegistrar);
            this.Controls.Add(this.lPassRepetir);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tPassRepetir);
            this.Controls.Add(this.tPassword);
            this.Controls.Add(this.tCP);
            this.Controls.Add(this.tRegion);
            this.Controls.Add(this.tPais);
            this.Controls.Add(this.tCiudad);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.tPlanta);
            this.Controls.Add(this.tCalle);
            this.Controls.Add(this.checkValida);
            this.Controls.Add(this.lCP);
            this.Controls.Add(this.lRegion);
            this.Controls.Add(this.lNombre2);
            this.Controls.Add(this.lNumero);
            this.Controls.Add(this.lPais);
            this.Controls.Add(this.lCiudad);
            this.Controls.Add(this.lPlanta);
            this.Controls.Add(this.lCalle);
            this.Controls.Add(this.lDireccion);
            this.Controls.Add(this.tNombreEmpresa);
            this.Controls.Add(this.lNombreEmpresa);
            this.Controls.Add(this.tCIF);
            this.Controls.Add(this.lCIF);
            this.Controls.Add(this.lRegistroEmpresa);
            this.Controls.Add(this.lDatos);
            this.Name = "RegistroEmpresa";
            this.Text = "Ebury Client App - Registro de empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDatos;
        private System.Windows.Forms.Label lRegistroEmpresa;
        private System.Windows.Forms.Label lCIF;
        private System.Windows.Forms.TextBox tCIF;
        private System.Windows.Forms.Label lNombreEmpresa;
        private System.Windows.Forms.TextBox tNombreEmpresa;
        private System.Windows.Forms.Label lDireccion;
        private System.Windows.Forms.Label lCalle;
        private System.Windows.Forms.Label lPlanta;
        private System.Windows.Forms.Label lCiudad;
        private System.Windows.Forms.Label lPais;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label lNombre2;
        private System.Windows.Forms.Label lRegion;
        private System.Windows.Forms.Label lCP;
        private System.Windows.Forms.CheckBox checkValida;
        private System.Windows.Forms.TextBox tCalle;
        private System.Windows.Forms.TextBox tPlanta;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.TextBox tCiudad;
        private System.Windows.Forms.TextBox tPais;
        private System.Windows.Forms.TextBox tRegion;
        private System.Windows.Forms.TextBox tCP;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tPassRepetir;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lPassRepetir;
        private System.Windows.Forms.Button bRegistrar;
        private System.Windows.Forms.Button bCancelar;
    }
}

