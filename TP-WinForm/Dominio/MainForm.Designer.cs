﻿
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
            this.tabMainForm = new System.Windows.Forms.TabControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tabCatalogos = new System.Windows.Forms.TabPage();
            this.btnEliminarCatalogo = new System.Windows.Forms.Button();
            this.btnEditarCatalogo = new System.Windows.Forms.Button();
            this.btnNuevoCatalogo = new System.Windows.Forms.Button();
            this.dtvCatalogo = new System.Windows.Forms.DataGridView();
            this.tabMarcas = new System.Windows.Forms.TabPage();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.tabMainForm.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tabCatalogos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvCatalogo)).BeginInit();
            this.tabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMainForm
            // 
            this.tabMainForm.Controls.Add(this.tabArticulos);
            this.tabMainForm.Controls.Add(this.tabCatalogos);
            this.tabMainForm.Controls.Add(this.tabMarcas);
            this.tabMainForm.Location = new System.Drawing.Point(3, 2);
            this.tabMainForm.Name = "tabMainForm";
            this.tabMainForm.SelectedIndex = 0;
            this.tabMainForm.Size = new System.Drawing.Size(561, 331);
            this.tabMainForm.TabIndex = 0;
            // 
            // tabArticulos
            // 
            this.tabArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabArticulos.Controls.Add(this.btnBuscarArticulo);
            this.tabArticulos.Controls.Add(this.btnEliminarArticulo);
            this.tabArticulos.Controls.Add(this.btnEditarArticulo);
            this.tabArticulos.Controls.Add(this.btnNuevoArticulo);
            this.tabArticulos.Controls.Add(this.dgvArticulos);
            this.tabArticulos.Location = new System.Drawing.Point(4, 22);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(3);
            this.tabArticulos.Size = new System.Drawing.Size(553, 305);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.Text = "Articulos";
            this.tabArticulos.UseVisualStyleBackColor = true;
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
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(191, 6);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "Eliminar Articulo";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
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
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Location = new System.Drawing.Point(3, 6);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(91, 23);
            this.btnNuevoArticulo.TabIndex = 1;
            this.btnNuevoArticulo.Text = "Nuevo Articulo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(3, 39);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(544, 256);
            this.dgvArticulos.TabIndex = 0;
            // 
            // tabCatalogos
            // 
            this.tabCatalogos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCatalogos.Controls.Add(this.btnEliminarCatalogo);
            this.tabCatalogos.Controls.Add(this.btnEditarCatalogo);
            this.tabCatalogos.Controls.Add(this.btnNuevoCatalogo);
            this.tabCatalogos.Controls.Add(this.dtvCatalogo);
            this.tabCatalogos.Location = new System.Drawing.Point(4, 22);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.Size = new System.Drawing.Size(553, 305);
            this.tabCatalogos.TabIndex = 2;
            this.tabCatalogos.Text = "Catalogos";
            this.tabCatalogos.UseVisualStyleBackColor = true;
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
            // tabMarcas
            // 
            this.tabMarcas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMarcas.Controls.Add(this.btnEliminarMarca);
            this.tabMarcas.Controls.Add(this.btnEditarMarca);
            this.tabMarcas.Controls.Add(this.btnNuevaMarca);
            this.tabMarcas.Controls.Add(this.dgvMarcas);
            this.tabMarcas.Location = new System.Drawing.Point(4, 22);
            this.tabMarcas.Name = "tabMarcas";
            this.tabMarcas.Padding = new System.Windows.Forms.Padding(3);
            this.tabMarcas.Size = new System.Drawing.Size(553, 305);
            this.tabMarcas.TabIndex = 1;
            this.tabMarcas.Text = "Marcas";
            this.tabMarcas.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.tabMainForm);
            this.Name = "mainForm";
            this.Text = "TP-WinForm";
            this.tabMainForm.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tabCatalogos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvCatalogo)).EndInit();
            this.tabMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainForm;
        private System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.TabPage tabMarcas;
        private System.Windows.Forms.TabPage tabCatalogos;
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

