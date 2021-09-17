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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.TabCatalagos = new System.Windows.Forms.TabPage();
            this.TabMarcas = new System.Windows.Forms.TabPage();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnNuevoAr = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.btNuevoCat = new System.Windows.Forms.Button();
            this.btnEditarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnNuevaMar = new System.Windows.Forms.Button();
            this.btnEditarMar = new System.Windows.Forms.Button();
            this.btnEliminarMar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            this.TabCatalagos.SuspendLayout();
            this.TabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArticulos);
            this.tabControl1.Controls.Add(this.TabCatalagos);
            this.tabControl1.Controls.Add(this.TabMarcas);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 379);
            this.tabControl1.TabIndex = 0;
            // 
            // tabArticulos
            // 
            this.tabArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabArticulos.Controls.Add(this.picArticulo);
            this.tabArticulos.Controls.Add(this.btnBuscador);
            this.tabArticulos.Controls.Add(this.btnEliminar);
            this.tabArticulos.Controls.Add(this.btnEditar);
            this.tabArticulos.Controls.Add(this.btnNuevoAr);
            this.tabArticulos.Controls.Add(this.dgvArticulos);
            this.tabArticulos.Location = new System.Drawing.Point(4, 22);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticulos.Size = new System.Drawing.Size(773, 353);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.Text = "Articulos";
            this.tabArticulos.UseVisualStyleBackColor = true;
            // 
            // TabCatalagos
            // 
            this.TabCatalagos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabCatalagos.Controls.Add(this.dataGridView1);
            this.TabCatalagos.Controls.Add(this.btnEliminarCat);
            this.TabCatalagos.Controls.Add(this.btnEditarCat);
            this.TabCatalagos.Controls.Add(this.btNuevoCat);
            this.TabCatalagos.Location = new System.Drawing.Point(4, 22);
            this.TabCatalagos.Name = "TabCatalagos";
            this.TabCatalagos.Padding = new System.Windows.Forms.Padding(3);
            this.TabCatalagos.Size = new System.Drawing.Size(773, 353);
            this.TabCatalagos.TabIndex = 1;
            this.TabCatalagos.Text = "Catalogos";
            this.TabCatalagos.UseVisualStyleBackColor = true;
            // 
            // TabMarcas
            // 
            this.TabMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TabMarcas.Controls.Add(this.btnEliminarMar);
            this.TabMarcas.Controls.Add(this.btnEditarMar);
            this.TabMarcas.Controls.Add(this.btnNuevaMar);
            this.TabMarcas.Controls.Add(this.dataGridView2);
            this.TabMarcas.Location = new System.Drawing.Point(4, 22);
            this.TabMarcas.Name = "TabMarcas";
            this.TabMarcas.Size = new System.Drawing.Size(773, 353);
            this.TabMarcas.TabIndex = 2;
            this.TabMarcas.Text = "Marcas";
            this.TabMarcas.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(1, 45);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(517, 306);
            this.dgvArticulos.TabIndex = 0;
            // 
            // btnNuevoAr
            // 
            this.btnNuevoAr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoAr.Location = new System.Drawing.Point(6, 6);
            this.btnNuevoAr.Name = "btnNuevoAr";
            this.btnNuevoAr.Size = new System.Drawing.Size(113, 32);
            this.btnNuevoAr.TabIndex = 1;
            this.btnNuevoAr.Text = "Nuevo Articulo";
            this.btnNuevoAr.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(125, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 32);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar Articulo";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(233, 6);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 32);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar Articulo ";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscador
            // 
            this.btnBuscador.Location = new System.Drawing.Point(646, 6);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(107, 32);
            this.btnBuscador.TabIndex = 4;
            this.btnBuscador.Text = "Buscar Articulo";
            this.btnBuscador.UseVisualStyleBackColor = true;
            // 
            // picArticulo
            // 
            this.picArticulo.Location = new System.Drawing.Point(543, 54);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Size = new System.Drawing.Size(201, 182);
            this.picArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArticulo.TabIndex = 5;
            this.picArticulo.TabStop = false;
            // 
            // btNuevoCat
            // 
            this.btNuevoCat.Location = new System.Drawing.Point(18, 6);
            this.btNuevoCat.Name = "btNuevoCat";
            this.btNuevoCat.Size = new System.Drawing.Size(113, 32);
            this.btNuevoCat.TabIndex = 0;
            this.btNuevoCat.Text = "Nuevo Catalogo";
            this.btNuevoCat.UseVisualStyleBackColor = true;
            // 
            // btnEditarCat
            // 
            this.btnEditarCat.Location = new System.Drawing.Point(137, 6);
            this.btnEditarCat.Name = "btnEditarCat";
            this.btnEditarCat.Size = new System.Drawing.Size(113, 32);
            this.btnEditarCat.TabIndex = 1;
            this.btnEditarCat.Text = "Editar Catalogo";
            this.btnEditarCat.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(256, 6);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(113, 32);
            this.btnEliminarCat.TabIndex = 2;
            this.btnEliminarCat.Text = "Eliminar Catalogo";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 298);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(745, 298);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnNuevaMar
            // 
            this.btnNuevaMar.Location = new System.Drawing.Point(12, 11);
            this.btnNuevaMar.Name = "btnNuevaMar";
            this.btnNuevaMar.Size = new System.Drawing.Size(113, 32);
            this.btnNuevaMar.TabIndex = 1;
            this.btnNuevaMar.Text = "Nueva Marca";
            this.btnNuevaMar.UseVisualStyleBackColor = true;
            // 
            // btnEditarMar
            // 
            this.btnEditarMar.Location = new System.Drawing.Point(131, 11);
            this.btnEditarMar.Name = "btnEditarMar";
            this.btnEditarMar.Size = new System.Drawing.Size(113, 32);
            this.btnEditarMar.TabIndex = 2;
            this.btnEditarMar.Text = "Editar Marca";
            this.btnEditarMar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMar
            // 
            this.btnEliminarMar.Location = new System.Drawing.Point(250, 11);
            this.btnEliminarMar.Name = "btnEliminarMar";
            this.btnEliminarMar.Size = new System.Drawing.Size(113, 32);
            this.btnEliminarMar.TabIndex = 3;
            this.btnEliminarMar.Text = "Eliminar marca";
            this.btnEliminarMar.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 411);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "TP-WinForm";
            this.tabControl1.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            this.TabCatalagos.ResumeLayout(false);
            this.TabMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.PictureBox picArticulo;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevoAr;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TabPage TabCatalagos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnEditarCat;
        private System.Windows.Forms.Button btNuevoCat;
        private System.Windows.Forms.TabPage TabMarcas;
        private System.Windows.Forms.Button btnEliminarMar;
        private System.Windows.Forms.Button btnEditarMar;
        private System.Windows.Forms.Button btnNuevaMar;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

