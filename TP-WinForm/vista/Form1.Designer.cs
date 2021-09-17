namespace vista
{
    partial class mainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.btnBuscadorArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tabCatalagos = new System.Windows.Forms.TabPage();
            this.dgvCatalogos = new System.Windows.Forms.DataGridView();
            this.btnEliminarCatalogo = new System.Windows.Forms.Button();
            this.btnEditarCatalogo = new System.Windows.Forms.Button();
            this.btNuevoCatalogo = new System.Windows.Forms.Button();
            this.tabMarcas = new System.Windows.Forms.TabPage();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tabCatalagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogos)).BeginInit();
            this.tabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabArticulos);
            this.tabControl.Controls.Add(this.tabCatalagos);
            this.tabControl.Controls.Add(this.tabMarcas);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1041, 466);
            this.tabControl.TabIndex = 0;
            // 
            // tabArticulos
            // 
            this.tabArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabArticulos.Controls.Add(this.picArticulo);
            this.tabArticulos.Controls.Add(this.btnBuscadorArticulo);
            this.tabArticulos.Controls.Add(this.btnEliminarArticulo);
            this.tabArticulos.Controls.Add(this.btnEditarArticulo);
            this.tabArticulos.Controls.Add(this.btnNuevoArticulo);
            this.tabArticulos.Controls.Add(this.dgvArticulos);
            this.tabArticulos.Location = new System.Drawing.Point(4, 25);
            this.tabArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabArticulos.Size = new System.Drawing.Size(1033, 437);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.Text = "Articulos";
            this.tabArticulos.UseVisualStyleBackColor = true;
            // 
            // picArticulo
            // 
            this.picArticulo.Location = new System.Drawing.Point(724, 66);
            this.picArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Size = new System.Drawing.Size(268, 224);
            this.picArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArticulo.TabIndex = 5;
            this.picArticulo.TabStop = false;
            // 
            // btnBuscadorArticulo
            // 
            this.btnBuscadorArticulo.Location = new System.Drawing.Point(861, 16);
            this.btnBuscadorArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscadorArticulo.Name = "btnBuscadorArticulo";
            this.btnBuscadorArticulo.Size = new System.Drawing.Size(143, 39);
            this.btnBuscadorArticulo.TabIndex = 4;
            this.btnBuscadorArticulo.Text = "Buscar Articulo";
            this.btnBuscadorArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(311, 16);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(133, 39);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "Eliminar Articulo ";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.Location = new System.Drawing.Point(167, 16);
            this.btnEditarArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(135, 39);
            this.btnEditarArticulo.TabIndex = 2;
            this.btnEditarArticulo.Text = "Editar Articulo";
            this.btnEditarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(8, 16);
            this.btnNuevoArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(151, 39);
            this.btnNuevoArticulo.TabIndex = 1;
            this.btnNuevoArticulo.Text = "Nuevo Articulo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(8, 64);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(689, 377);
            this.dgvArticulos.TabIndex = 0;
            // 
            // tabCatalagos
            // 
            this.tabCatalagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCatalagos.Controls.Add(this.dgvCatalogos);
            this.tabCatalagos.Controls.Add(this.btnEliminarCatalogo);
            this.tabCatalagos.Controls.Add(this.btnEditarCatalogo);
            this.tabCatalagos.Controls.Add(this.btNuevoCatalogo);
            this.tabCatalagos.Location = new System.Drawing.Point(4, 25);
            this.tabCatalagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCatalagos.Name = "tabCatalagos";
            this.tabCatalagos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCatalagos.Size = new System.Drawing.Size(1033, 437);
            this.tabCatalagos.TabIndex = 1;
            this.tabCatalagos.Text = "Catalogos";
            this.tabCatalagos.UseVisualStyleBackColor = true;
            // 
            // dgvCatalogos
            // 
            this.dgvCatalogos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogos.Location = new System.Drawing.Point(18, 64);
            this.dgvCatalogos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCatalogos.Name = "dgvCatalogos";
            this.dgvCatalogos.RowHeadersWidth = 51;
            this.dgvCatalogos.Size = new System.Drawing.Size(993, 367);
            this.dgvCatalogos.TabIndex = 3;
            // 
            // btnEliminarCatalogo
            // 
            this.btnEliminarCatalogo.Location = new System.Drawing.Point(335, 16);
            this.btnEliminarCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarCatalogo.Name = "btnEliminarCatalogo";
            this.btnEliminarCatalogo.Size = new System.Drawing.Size(151, 39);
            this.btnEliminarCatalogo.TabIndex = 2;
            this.btnEliminarCatalogo.Text = "Eliminar Catalogo";
            this.btnEliminarCatalogo.UseVisualStyleBackColor = true;
            // 
            // btnEditarCatalogo
            // 
            this.btnEditarCatalogo.Location = new System.Drawing.Point(177, 16);
            this.btnEditarCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarCatalogo.Name = "btnEditarCatalogo";
            this.btnEditarCatalogo.Size = new System.Drawing.Size(151, 39);
            this.btnEditarCatalogo.TabIndex = 1;
            this.btnEditarCatalogo.Text = "Editar Catalogo";
            this.btnEditarCatalogo.UseVisualStyleBackColor = true;
            // 
            // btNuevoCatalogo
            // 
            this.btNuevoCatalogo.Location = new System.Drawing.Point(18, 16);
            this.btNuevoCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNuevoCatalogo.Name = "btNuevoCatalogo";
            this.btNuevoCatalogo.Size = new System.Drawing.Size(151, 39);
            this.btNuevoCatalogo.TabIndex = 0;
            this.btNuevoCatalogo.Text = "Nuevo Catalogo";
            this.btNuevoCatalogo.UseVisualStyleBackColor = true;
            // 
            // tabMarcas
            // 
            this.tabMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMarcas.Controls.Add(this.btnEliminarMarca);
            this.tabMarcas.Controls.Add(this.btnEditarMarca);
            this.tabMarcas.Controls.Add(this.btnNuevaMarca);
            this.tabMarcas.Controls.Add(this.dgvMarcas);
            this.tabMarcas.Location = new System.Drawing.Point(4, 25);
            this.tabMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabMarcas.Name = "tabMarcas";
            this.tabMarcas.Size = new System.Drawing.Size(1033, 437);
            this.tabMarcas.TabIndex = 2;
            this.tabMarcas.Text = "Marcas";
            this.tabMarcas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(333, 14);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(151, 39);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Location = new System.Drawing.Point(175, 14);
            this.btnEditarMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(151, 39);
            this.btnEditarMarca.TabIndex = 2;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Location = new System.Drawing.Point(16, 14);
            this.btnNuevaMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(151, 39);
            this.btnNuevaMarca.TabIndex = 1;
            this.btnNuevaMarca.Text = "Nueva Marca";
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(16, 64);
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.Size = new System.Drawing.Size(993, 367);
            this.dgvMarcas.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 506);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.Text = "TP-WinForm";
            this.tabControl.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tabCatalagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogos)).EndInit();
            this.tabMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.PictureBox picArticulo;
        private System.Windows.Forms.Button btnBuscadorArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TabPage tabCatalagos;
        private System.Windows.Forms.DataGridView dgvCatalogos;
        private System.Windows.Forms.Button btnEliminarCatalogo;
        private System.Windows.Forms.Button btnEditarCatalogo;
        private System.Windows.Forms.Button btNuevoCatalogo;
        private System.Windows.Forms.TabPage tabMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}

