namespace ebury_client
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.bPersonaFisica = new System.Windows.Forms.Button();
            this.bEmpresa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 138);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(426, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione si usted quiere crear una cuenta\r\npara una persona física o para una e" +
    "mpresa.";
            // 
            // bPersonaFisica
            // 
            this.bPersonaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPersonaFisica.Location = new System.Drawing.Point(226, 222);
            this.bPersonaFisica.Name = "bPersonaFisica";
            this.bPersonaFisica.Size = new System.Drawing.Size(163, 82);
            this.bPersonaFisica.TabIndex = 1;
            this.bPersonaFisica.Text = "Persona Física";
            this.bPersonaFisica.UseVisualStyleBackColor = true;
            this.bPersonaFisica.Click += new System.EventHandler(this.bPersonaFisica_Click);
            // 
            // bEmpresa
            // 
            this.bEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEmpresa.Location = new System.Drawing.Point(427, 222);
            this.bEmpresa.Name = "bEmpresa";
            this.bEmpresa.Size = new System.Drawing.Size(163, 82);
            this.bEmpresa.TabIndex = 2;
            this.bEmpresa.Text = "Empresa";
            this.bEmpresa.UseVisualStyleBackColor = true;
            this.bEmpresa.Click += new System.EventHandler(this.bEmpresa_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 476);
            this.Controls.Add(this.bEmpresa);
            this.Controls.Add(this.bPersonaFisica);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(850, 523);
            this.MinimumSize = new System.Drawing.Size(850, 523);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ebury Client App - Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bPersonaFisica;
        private System.Windows.Forms.Button bEmpresa;
    }
}