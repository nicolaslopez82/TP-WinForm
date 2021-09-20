namespace vista
{
    partial class AltaArticulo
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
            this.components = new System.ComponentModel.Container();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.LabelCod = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDes = new System.Windows.Forms.Label();
            this.labelidMar = new System.Windows.Forms.Label();
            this.labelidCat = new System.Windows.Forms.Label();
            this.labelImagen = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(101, 389);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(128, 46);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(333, 389);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 46);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // LabelCod
            // 
            this.LabelCod.AutoSize = true;
            this.LabelCod.Location = new System.Drawing.Point(97, 58);
            this.LabelCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelCod.Name = "LabelCod";
            this.LabelCod.Size = new System.Drawing.Size(56, 17);
            this.LabelCod.TabIndex = 2;
            this.LabelCod.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(197, 54);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(201, 22);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 98);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(97, 102);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 17);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre :";
            // 
            // labelDes
            // 
            this.labelDes.AutoSize = true;
            this.labelDes.Location = new System.Drawing.Point(97, 139);
            this.labelDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDes.Name = "labelDes";
            this.labelDes.Size = new System.Drawing.Size(90, 17);
            this.labelDes.TabIndex = 6;
            this.labelDes.Text = "Descripcion :";
            // 
            // labelidMar
            // 
            this.labelidMar.AutoSize = true;
            this.labelidMar.Location = new System.Drawing.Point(97, 176);
            this.labelidMar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidMar.Name = "labelidMar";
            this.labelidMar.Size = new System.Drawing.Size(55, 17);
            this.labelidMar.TabIndex = 7;
            this.labelidMar.Text = "Marca :";
            // 
            // labelidCat
            // 
            this.labelidCat.AutoSize = true;
            this.labelidCat.Location = new System.Drawing.Point(97, 215);
            this.labelidCat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidCat.Name = "labelidCat";
            this.labelidCat.Size = new System.Drawing.Size(77, 17);
            this.labelidCat.TabIndex = 8;
            this.labelidCat.Text = "Categoria :";
            // 
            // labelImagen
            // 
            this.labelImagen.AutoSize = true;
            this.labelImagen.Location = new System.Drawing.Point(97, 256);
            this.labelImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImagen.Name = "labelImagen";
            this.labelImagen.Size = new System.Drawing.Size(94, 17);
            this.labelImagen.TabIndex = 9;
            this.labelImagen.Text = "URL Imagen :";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(97, 295);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(56, 17);
            this.labelPrecio.TabIndex = 10;
            this.labelPrecio.Text = "Precio :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(197, 139);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(201, 22);
            this.txtDesc.TabIndex = 12;
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(197, 252);
            this.txtUrlImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(201, 22);
            this.txtUrlImagen.TabIndex = 15;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(197, 295);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(201, 22);
            this.txtPrecio.TabIndex = 16;
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(197, 176);
            this.cboMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(201, 24);
            this.cboMarca.TabIndex = 17;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(197, 215);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(201, 24);
            this.cboCategoria.TabIndex = 18;
            // 
            // AltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 465);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelImagen);
            this.Controls.Add(this.labelidCat);
            this.Controls.Add(this.labelidMar);
            this.Controls.Add(this.labelDes);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.LabelCod);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AltaArticulo";
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.AltaArticulo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label LabelCod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDes;
        private System.Windows.Forms.Label labelidMar;
        private System.Windows.Forms.Label labelidCat;
        private System.Windows.Forms.Label labelImagen;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
    }
}