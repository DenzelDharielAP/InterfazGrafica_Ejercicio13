namespace InterfazGrafica_Ejercicio14
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtContinente = new System.Windows.Forms.TextBox();
            this.cmb_Paises = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCapital
            // 
            this.txtCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCapital.Location = new System.Drawing.Point(164, 160);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(135, 24);
            this.txtCapital.TabIndex = 0;
            // 
            // txtContinente
            // 
            this.txtContinente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContinente.Location = new System.Drawing.Point(164, 226);
            this.txtContinente.Name = "txtContinente";
            this.txtContinente.Size = new System.Drawing.Size(135, 24);
            this.txtContinente.TabIndex = 1;
            // 
            // cmb_Paises
            // 
            this.cmb_Paises.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Paises.FormattingEnabled = true;
            this.cmb_Paises.Items.AddRange(new object[] {
            "República Dominicana",
            "México",
            "Venezuela",
            "Brazil"});
            this.cmb_Paises.Location = new System.Drawing.Point(332, 52);
            this.cmb_Paises.Name = "cmb_Paises";
            this.cmb_Paises.Size = new System.Drawing.Size(172, 26);
            this.cmb_Paises.TabIndex = 2;
            this.cmb_Paises.Text = "Selecciona un país";
            this.cmb_Paises.SelectedIndexChanged += new System.EventHandler(this.cmb_Paises_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Capital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Región";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Paises);
            this.Controls.Add(this.txtContinente);
            this.Controls.Add(this.txtCapital);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtContinente;
        private System.Windows.Forms.ComboBox cmb_Paises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

