
namespace vista
{
    partial class BusquedaArticulo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxCodigo = new System.Windows.Forms.ComboBox();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxDescripcion = new System.Windows.Forms.ComboBox();
            this.cbxPrecio = new System.Windows.Forms.ComboBox();
            this.btnAceptarBusqueda = new System.Windows.Forms.Button();
            this.btnCancelarBusqueda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio:";
            // 
            // cbxCodigo
            // 
            this.cbxCodigo.FormattingEnabled = true;
            this.cbxCodigo.Location = new System.Drawing.Point(191, 63);
            this.cbxCodigo.Name = "cbxCodigo";
            this.cbxCodigo.Size = new System.Drawing.Size(150, 24);
            this.cbxCodigo.TabIndex = 6;
            this.cbxCodigo.Click += new System.EventHandler(this.cbxCodigo_Click);
            // 
            // cbxNombre
            // 
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(191, 107);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(150, 24);
            this.cbxNombre.TabIndex = 7;
            this.cbxNombre.Click += new System.EventHandler(this.cbxNombre_Click);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(191, 246);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(150, 24);
            this.cbxCategoria.TabIndex = 8;
            this.cbxCategoria.Click += new System.EventHandler(this.cbxCategoria_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(191, 199);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(150, 24);
            this.cbxMarca.TabIndex = 9;
            this.cbxMarca.Click += new System.EventHandler(this.cbxMarca_Click);
            // 
            // cbxDescripcion
            // 
            this.cbxDescripcion.FormattingEnabled = true;
            this.cbxDescripcion.Location = new System.Drawing.Point(191, 150);
            this.cbxDescripcion.Name = "cbxDescripcion";
            this.cbxDescripcion.Size = new System.Drawing.Size(150, 24);
            this.cbxDescripcion.TabIndex = 10;
            this.cbxDescripcion.Click += new System.EventHandler(this.cbxDescripcion_Click);
            // 
            // cbxPrecio
            // 
            this.cbxPrecio.FormattingEnabled = true;
            this.cbxPrecio.Location = new System.Drawing.Point(191, 292);
            this.cbxPrecio.Name = "cbxPrecio";
            this.cbxPrecio.Size = new System.Drawing.Size(150, 24);
            this.cbxPrecio.TabIndex = 11;
            this.cbxPrecio.Click += new System.EventHandler(this.cbxPrecio_Click);
            // 
            // btnAceptarBusqueda
            // 
            this.btnAceptarBusqueda.Location = new System.Drawing.Point(79, 377);
            this.btnAceptarBusqueda.Name = "btnAceptarBusqueda";
            this.btnAceptarBusqueda.Size = new System.Drawing.Size(110, 37);
            this.btnAceptarBusqueda.TabIndex = 12;
            this.btnAceptarBusqueda.Text = "Aceptar";
            this.btnAceptarBusqueda.UseVisualStyleBackColor = true;
            this.btnAceptarBusqueda.Click += new System.EventHandler(this.btnAceptarBusqueda_Click);
            // 
            // btnCancelarBusqueda
            // 
            this.btnCancelarBusqueda.Location = new System.Drawing.Point(292, 377);
            this.btnCancelarBusqueda.Name = "btnCancelarBusqueda";
            this.btnCancelarBusqueda.Size = new System.Drawing.Size(110, 37);
            this.btnCancelarBusqueda.TabIndex = 13;
            this.btnCancelarBusqueda.Text = "Cancelar";
            this.btnCancelarBusqueda.UseVisualStyleBackColor = true;
            this.btnCancelarBusqueda.Click += new System.EventHandler(this.btnCancelarBusqueda_Click);
            // 
            // BusquedaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 508);
            this.Controls.Add(this.btnCancelarBusqueda);
            this.Controls.Add(this.btnAceptarBusqueda);
            this.Controls.Add(this.cbxPrecio);
            this.Controls.Add(this.cbxDescripcion);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxNombre);
            this.Controls.Add(this.cbxCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BusquedaArticulo";
            this.Text = "BusquedaArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxCodigo;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxDescripcion;
        private System.Windows.Forms.ComboBox cbxPrecio;
        private System.Windows.Forms.Button btnAceptarBusqueda;
        private System.Windows.Forms.Button btnCancelarBusqueda;
    }
}