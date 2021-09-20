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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.btnBuscadorArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.btnEliminarCatalogo = new System.Windows.Forms.Button();
            this.btnEditarCatalogo = new System.Windows.Forms.Button();
            this.btNuevoCatalogo = new System.Windows.Forms.Button();
            this.tabMarcas = new System.Windows.Forms.TabPage();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnEditarMarca = new System.Windows.Forms.Button();
            this.btnNuevaMarca = new System.Windows.Forms.Button();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.viewListarArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adgvBusquedaArticulos = new Zuby.ADGV.AdvancedDataGridView();
            this.cATALOGO_DBDataSet = new vista.CATALOGO_DBDataSet();
            this.viewListarArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.viewListarArticulosTableAdapter = new vista.CATALOGO_DBDataSetTableAdapters.ViewListarArticulosTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenUrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desmarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tabBusqueda.SuspendLayout();
            this.tabMarcas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvBusquedaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGO_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabArticulos);
            this.tabControl.Controls.Add(this.tabBusqueda);
            this.tabControl.Controls.Add(this.tabMarcas);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1433, 567);
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
            this.tabArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.tabArticulos.Name = "tabArticulos";
            this.tabArticulos.Padding = new System.Windows.Forms.Padding(4);
            this.tabArticulos.Size = new System.Drawing.Size(1425, 538);
            this.tabArticulos.TabIndex = 0;
            this.tabArticulos.Text = "Articulos";
            this.tabArticulos.UseVisualStyleBackColor = true;
            // 
            // picArticulo
            // 
            this.picArticulo.Location = new System.Drawing.Point(1045, 64);
            this.picArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Size = new System.Drawing.Size(309, 248);
            this.picArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArticulo.TabIndex = 5;
            this.picArticulo.TabStop = false;
            // 
            // btnBuscadorArticulo
            // 
            this.btnBuscadorArticulo.Location = new System.Drawing.Point(861, 16);
            this.btnBuscadorArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscadorArticulo.Name = "btnBuscadorArticulo";
            this.btnBuscadorArticulo.Size = new System.Drawing.Size(143, 39);
            this.btnBuscadorArticulo.TabIndex = 4;
            this.btnBuscadorArticulo.Text = "Buscar Articulo";
            this.btnBuscadorArticulo.UseVisualStyleBackColor = true;
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(311, 16);
            this.btnEliminarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(133, 39);
            this.btnEliminarArticulo.TabIndex = 3;
            this.btnEliminarArticulo.Text = "Eliminar Articulo ";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnEditarArticulo
            // 
            this.btnEditarArticulo.Location = new System.Drawing.Point(167, 16);
            this.btnEditarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarArticulo.Name = "btnEditarArticulo";
            this.btnEditarArticulo.Size = new System.Drawing.Size(135, 39);
            this.btnEditarArticulo.TabIndex = 2;
            this.btnEditarArticulo.Text = "Editar Articulo";
            this.btnEditarArticulo.UseVisualStyleBackColor = true;
            this.btnEditarArticulo.Click += new System.EventHandler(this.btnEditarArticulo_Click);
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevoArticulo.Location = new System.Drawing.Point(8, 16);
            this.btnNuevoArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(151, 39);
            this.btnNuevoArticulo.TabIndex = 1;
            this.btnNuevoArticulo.Text = "Nuevo Articulo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(8, 64);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1004, 377);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabBusqueda.Controls.Add(this.adgvBusquedaArticulos);
            this.tabBusqueda.Controls.Add(this.btnEliminarCatalogo);
            this.tabBusqueda.Controls.Add(this.btnEditarCatalogo);
            this.tabBusqueda.Controls.Add(this.btNuevoCatalogo);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tabBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.tabBusqueda.Size = new System.Drawing.Size(1425, 538);
            this.tabBusqueda.TabIndex = 1;
            this.tabBusqueda.Text = "Busqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCatalogo
            // 
            this.btnEliminarCatalogo.Location = new System.Drawing.Point(335, 16);
            this.btnEliminarCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCatalogo.Name = "btnEliminarCatalogo";
            this.btnEliminarCatalogo.Size = new System.Drawing.Size(151, 39);
            this.btnEliminarCatalogo.TabIndex = 2;
            this.btnEliminarCatalogo.Text = "Eliminar Catalogo";
            this.btnEliminarCatalogo.UseVisualStyleBackColor = true;
            // 
            // btnEditarCatalogo
            // 
            this.btnEditarCatalogo.Location = new System.Drawing.Point(177, 16);
            this.btnEditarCatalogo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarCatalogo.Name = "btnEditarCatalogo";
            this.btnEditarCatalogo.Size = new System.Drawing.Size(151, 39);
            this.btnEditarCatalogo.TabIndex = 1;
            this.btnEditarCatalogo.Text = "Editar Catalogo";
            this.btnEditarCatalogo.UseVisualStyleBackColor = true;
            // 
            // btNuevoCatalogo
            // 
            this.btNuevoCatalogo.Location = new System.Drawing.Point(18, 16);
            this.btNuevoCatalogo.Margin = new System.Windows.Forms.Padding(4);
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
            this.tabMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.tabMarcas.Name = "tabMarcas";
            this.tabMarcas.Size = new System.Drawing.Size(1425, 538);
            this.tabMarcas.TabIndex = 2;
            this.tabMarcas.Text = "Marcas";
            this.tabMarcas.UseVisualStyleBackColor = true;
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(333, 14);
            this.btnEliminarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(151, 39);
            this.btnEliminarMarca.TabIndex = 3;
            this.btnEliminarMarca.Text = "Eliminar marca";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Location = new System.Drawing.Point(175, 14);
            this.btnEditarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(151, 39);
            this.btnEditarMarca.TabIndex = 2;
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.UseVisualStyleBackColor = true;
            // 
            // btnNuevaMarca
            // 
            this.btnNuevaMarca.Location = new System.Drawing.Point(16, 14);
            this.btnNuevaMarca.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvMarcas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.Size = new System.Drawing.Size(993, 367);
            this.dgvMarcas.TabIndex = 0;
            // 
            // viewListarArticulosBindingSource
            // 
            this.viewListarArticulosBindingSource.DataMember = "ViewListarArticulos";
            // 
            // adgvBusquedaArticulos
            // 
            this.adgvBusquedaArticulos.AutoGenerateColumns = false;
            this.adgvBusquedaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adgvBusquedaArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.imagenUrlDataGridViewTextBoxColumn,
            this.desmarDataGridViewTextBoxColumn,
            this.idmarDataGridViewTextBoxColumn,
            this.descatDataGridViewTextBoxColumn,
            this.idcatDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.adgvBusquedaArticulos.DataSource = this.viewListarArticulosBindingSource1;
            this.adgvBusquedaArticulos.FilterAndSortEnabled = true;
            this.adgvBusquedaArticulos.Location = new System.Drawing.Point(18, 63);
            this.adgvBusquedaArticulos.Name = "adgvBusquedaArticulos";
            this.adgvBusquedaArticulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvBusquedaArticulos.RowHeadersWidth = 51;
            this.adgvBusquedaArticulos.RowTemplate.Height = 24;
            this.adgvBusquedaArticulos.Size = new System.Drawing.Size(1040, 380);
            this.adgvBusquedaArticulos.TabIndex = 3;
            // 
            // cATALOGO_DBDataSet
            // 
            this.cATALOGO_DBDataSet.DataSetName = "CATALOGO_DBDataSet";
            this.cATALOGO_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewListarArticulosBindingSource1
            // 
            this.viewListarArticulosBindingSource1.DataMember = "ViewListarArticulos";
            this.viewListarArticulosBindingSource1.DataSource = this.cATALOGO_DBDataSet;
            // 
            // viewListarArticulosTableAdapter
            // 
            this.viewListarArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 55;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.nombreDataGridViewTextBoxColumn.Width = 120;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // imagenUrlDataGridViewTextBoxColumn
            // 
            this.imagenUrlDataGridViewTextBoxColumn.DataPropertyName = "ImagenUrl";
            this.imagenUrlDataGridViewTextBoxColumn.HeaderText = "ImagenUrl";
            this.imagenUrlDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.imagenUrlDataGridViewTextBoxColumn.Name = "imagenUrlDataGridViewTextBoxColumn";
            this.imagenUrlDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.imagenUrlDataGridViewTextBoxColumn.Visible = false;
            this.imagenUrlDataGridViewTextBoxColumn.Width = 125;
            // 
            // desmarDataGridViewTextBoxColumn
            // 
            this.desmarDataGridViewTextBoxColumn.DataPropertyName = "Desmar";
            this.desmarDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.desmarDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.desmarDataGridViewTextBoxColumn.Name = "desmarDataGridViewTextBoxColumn";
            this.desmarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idmarDataGridViewTextBoxColumn
            // 
            this.idmarDataGridViewTextBoxColumn.DataPropertyName = "Idmar";
            this.idmarDataGridViewTextBoxColumn.HeaderText = "Idmar";
            this.idmarDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idmarDataGridViewTextBoxColumn.Name = "idmarDataGridViewTextBoxColumn";
            this.idmarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idmarDataGridViewTextBoxColumn.Visible = false;
            this.idmarDataGridViewTextBoxColumn.Width = 125;
            // 
            // descatDataGridViewTextBoxColumn
            // 
            this.descatDataGridViewTextBoxColumn.DataPropertyName = "Descat";
            this.descatDataGridViewTextBoxColumn.HeaderText = "Categorias";
            this.descatDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descatDataGridViewTextBoxColumn.Name = "descatDataGridViewTextBoxColumn";
            this.descatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // idcatDataGridViewTextBoxColumn
            // 
            this.idcatDataGridViewTextBoxColumn.DataPropertyName = "Idcat";
            this.idcatDataGridViewTextBoxColumn.HeaderText = "Idcat";
            this.idcatDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idcatDataGridViewTextBoxColumn.Name = "idcatDataGridViewTextBoxColumn";
            this.idcatDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idcatDataGridViewTextBoxColumn.Visible = false;
            this.idcatDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 595);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "TP-WinForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tabBusqueda.ResumeLayout(false);
            this.tabMarcas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adgvBusquedaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGO_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource1)).EndInit();
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
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.Button btnEliminarCatalogo;
        private System.Windows.Forms.Button btnEditarCatalogo;
        private System.Windows.Forms.Button btNuevoCatalogo;
        private System.Windows.Forms.TabPage tabMarcas;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEditarMarca;
        private System.Windows.Forms.Button btnNuevaMarca;
        private System.Windows.Forms.DataGridView dgvMarcas;   
        private System.Windows.Forms.BindingSource viewListarArticulosBindingSource;
        private Zuby.ADGV.AdvancedDataGridView adgvBusquedaArticulos;
        private CATALOGO_DBDataSet cATALOGO_DBDataSet;
        private System.Windows.Forms.BindingSource viewListarArticulosBindingSource1;
        private CATALOGO_DBDataSetTableAdapters.ViewListarArticulosTableAdapter viewListarArticulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenUrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desmarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
    }
}

