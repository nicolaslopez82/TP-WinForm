namespace winform_laconchadelalora
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
            this.btnsaludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsaludar
            // 
            this.btnsaludar.Location = new System.Drawing.Point(221, 125);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(216, 63);
            this.btnsaludar.TabIndex = 0;
            this.btnsaludar.Text = "Saludar";
            this.btnsaludar.UseVisualStyleBackColor = true;
            this.btnsaludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 302);
            this.Controls.Add(this.btnsaludar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsaludar;
    }
}

