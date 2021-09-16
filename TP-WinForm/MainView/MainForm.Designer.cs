
namespace Dominio
{
    partial class mainForm
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
            this.tabArticulos = new System.Windows.Forms.TabControl();
            this.Articulos = new System.Windows.Forms.TabPage();
            this.Marcas = new System.Windows.Forms.TabPage();
            this.Catalogos = new System.Windows.Forms.TabPage();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarCatalogo = new System.Windows.Forms.Button();
            this.btnEditarCatalogo = new System.Windows.Forms.Button();
            this.btnNuevoCatalogo = new System.Windows.Forms.Button();
            this.dtvCatalogo = new System.Windows.Forms.DataGridView();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.tabArticulos.SuspendLayout();
            this.Articulos.SuspendLayout();
            this.Marcas.SuspendLayout();
            this.Catalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabArticulos
            // 
            this.tabArticulos.Controls.Add(this.Articulos);
            this.tabArticulos.Controls.Add(this.Catalogos);
            this.tabArticulos.Controls.Add(this.Marcas);
            this.tabArticulos.Location = new System.Drawing.Point(3, 2);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.SelectedIndex = 0;
            this.tabArticulos.Size = new System.Drawing.Size(561, 331);
            this.tabArticulos.TabIndex = 0;
            // 
            // Articulos
            // 
            this.Articulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Articulos.Controls.Add(this.btnBuscarArticulo);
            this.Articulos.Controls.Add(this.btnEliminarArticulo);
            this.Articulos.Controls.Add(this.btnEditarArticulo);
            this.Articulos.Controls.Add(this.btnNuevoArticulo);
            this.Articulos.Controls.Add(this.dgvArticulos);
            this.Articulos.Location = new System.Drawing.Point(4, 22);
            this.Articulos.Name = "Articulos";
            this.Articulos.Padding = new System.Windows.Forms.Padding(3);
            this.Articulos.Size = new System.Drawing.Size(553, 305);
            this.Articulos.TabIndex = 0;
            this.Articulos.Text = "Articulos";
            this.Articulos.UseVisualStyleBackColor = true;
            // 
            // Marcas
            // 
            this.Marcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Marcas.Controls.Add(this.btnEliminarMarca);
            this.Marcas.Controls.Add(this.btnEditarMarca);
            this.Marcas.Controls.Add(this.btnNuevaMarca);
            this.Marcas.Controls.Add(this.dgvMarcas);
            this.Marcas.Location = new System.Drawing.Point(4, 22);
            this.Marcas.Name = "Marcas";
            this.Marcas.Padding = new System.Windows.Forms.Padding(3);
            this.Marcas.Size = new System.Drawing.Size(553, 305);
            this.Marcas.TabIndex = 1;
            this.Marcas.Text = "Marcas";
            this.Marcas.UseVisualStyleBackColor = true;
            // 
            // Catalogos
            // 
            this.Catalogos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Catalogos.Controls.Add(this.btnEliminarCatalogo);
            this.Catalogos.Controls.Add(this.btnEditarCatalogo);
            this.Catalogos.Controls.Add(this.btnNuevoCatalogo);
            this.Catalogos.Controls.Add(this.dtvCatalogo);
            this.Catalogos.Location = new System.Drawing.Point(4, 22);
            this.Catalogos.Name = "Catalogos";
            this.Catalogos.Size = new System.Drawing.Size(553, 305);
            this.Catalogos.TabIndex = 2;
            this.Catalogos.Text = "Catalogos";
            this.Catalogos.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 39);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(544, 256);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Location = new System.Drawing.Point(3, 6);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(91, 23);
            this.btnNuevoArticulo.TabIndex = 1;
            this.btnNuevoArticulo.Text = "Nuevo Articulo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.Location = new System.Drawing.Point(100, 6);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(85, 23);
            this.btnEditarArticulo.TabIndex = 2;
            this.btnEditarArticulo.Text = "Editar Articulo";
            this.btnEditarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(191, 6);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.Location = new System.Drawing.Point(453, 6);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(90, 23);
            this.btnBuscarArticulo.TabIndex = 4;
            this.btnBuscarArticulo.Text = "Buscar Articulo";
            this.btnBuscarArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCatalogo
            // 
            this.btnEliminarCatalogo.Location = new System.Drawing.Point(212, 6);
            this.btnEliminarCatalogo.Name = "btnEliminarCatalogo";
            this.btnEliminarCatalogo.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarCatalogo.TabIndex = 7;
            this.btnEliminarCatalogo.Text = "Eliminar Catalogo";
            this.btnEliminarCatalogo.UseVisualStyleBackColor = true;
            this.btnEliminarCatalogo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarCatalogo
            // 
            this.btnEditarCatalogo.Location = new System.Drawing.Point(110, 6);
            this.btnEditarCatalogo.Name = "btnEditarCatalogo";
            this.btnEditarCatalogo.Size = new System.Drawing.Size(96, 23);
            this.btnEditarCatalogo.TabIndex = 6;
            this.btnEditarCatalogo.Text = "Editar Catalogo";
            this.btnEditarCatalogo.UseVisualStyleBackColor = true;
            this.btnEditarCatalogo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevoCatalogo
            // 
            this.btnNuevoCatalogo.Location = new System.Drawing.Point(2, 6);
            this.btnNuevoCatalogo.Name = "btnNuevoCatalogo";
            this.btnNuevoCatalogo.Size = new System.Drawing.Size(104, 23);
            this.btnNuevoCatalogo.TabIndex = 5;
            this.btnNuevoCatalogo.Text = "Nuevo Catalogo";
            this.btnNuevoCatalogo.UseVisualStyleBackColor = true;
            this.btnNuevoCatalogo.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtvCatalogo
            // 
            this.dtvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvCatalogo.Location = new System.Drawing.Point(2, 39);
            this.dtvCatalogo.Name = "dtvCatalogo";
            this.dtvCatalogo.Size = new System.Drawing.Size(544, 256);
            this.dtvCatalogo.TabIndex = 4;
            this.dtvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(212, 6);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarMarca.TabIndex = 11;
            this.btnEliminarMarca.Text = "Eliminar Marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Location = new System.Drawing.Point(110, 6);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(96, 23);
            this.btnEditarMarca.TabIndex = 10;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Location = new System.Drawing.Point(2, 6);
            this.btnNuevaMarca.Name = "btnNuevaMarca";
            this.btnNuevaMarca.Size = new System.Drawing.Size(104, 23);
            this.btnNuevaMarca.TabIndex = 9;
            this.btnNuevaMarca.Text = "Nueva Marca";
            this.btnNuevaMarca.UseVisualStyleBackColor = true;
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Location = new System.Drawing.Point(2, 39);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.Size = new System.Drawing.Size(544, 256);
            this.dgvMarcas.TabIndex = 8;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 340);
            this.Controls.Add(this.tabArticulos);
            this.Name = "mainForm";
            this.Text = "TP-WinForm";
            this.tabArticulos.ResumeLayout(false);
            this.Articulos.ResumeLayout(false);
            this.Marcas.ResumeLayout(false);
            this.Catalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabArticulos;
        private System.Windows.Forms.TabPage Articulos;
        private System.Windows.Forms.TabPage Marcas;
        private System.Windows.Forms.TabPage Catalogos;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnEliminarCatalogo;
        private System.Windows.Forms.Button btnEditarCatalogo;
        private System.Windows.Forms.Button btnNuevoCatalogo;
        private System.Windows.Forms.DataGridView dtvCatalogo;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}

