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
            this.viewListarArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cATALOGO_DBDataSet = new vista.CATALOGO_DBDataSet();
            this.viewListarArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewListarArticulosTableAdapter = new vista.CATALOGO_DBDataSetTableAdapters.ViewListarArticulosTableAdapter();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.adgvBusquedaArticulos = new Zuby.ADGV.AdvancedDataGridView();
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
            this.tabArticulos = new System.Windows.Forms.TabPage();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.btnBuscadorArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnEditarArticulo = new System.Windows.Forms.Button();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGO_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource)).BeginInit();
            this.tabBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adgvBusquedaArticulos)).BeginInit();
            this.tabArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewListarArticulosBindingSource1
            // 
            this.viewListarArticulosBindingSource1.DataMember = "ViewListarArticulos";
            this.viewListarArticulosBindingSource1.DataSource = this.cATALOGO_DBDataSet;
            // 
            // cATALOGO_DBDataSet
            // 
            this.cATALOGO_DBDataSet.DataSetName = "CATALOGO_DBDataSet";
            this.cATALOGO_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewListarArticulosBindingSource
            // 
            this.viewListarArticulosBindingSource.DataMember = "ViewListarArticulos";
            // 
            // viewListarArticulosTableAdapter
            // 
            this.viewListarArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabBusqueda.Controls.Add(this.adgvBusquedaArticulos);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 25);
            this.tabBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(4);
            this.tabBusqueda.Size = new System.Drawing.Size(1425, 538);
            this.tabBusqueda.TabIndex = 1;
            this.tabBusqueda.Text = "Busqueda Articulos";
            this.tabBusqueda.UseVisualStyleBackColor = true;
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
            this.adgvBusquedaArticulos.Location = new System.Drawing.Point(7, 7);
            this.adgvBusquedaArticulos.Name = "adgvBusquedaArticulos";
            this.adgvBusquedaArticulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adgvBusquedaArticulos.RowHeadersWidth = 51;
            this.adgvBusquedaArticulos.RowTemplate.Height = 24;
            this.adgvBusquedaArticulos.Size = new System.Drawing.Size(1149, 380);
            this.adgvBusquedaArticulos.TabIndex = 3;
            this.adgvBusquedaArticulos.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.adgvBusquedaArticulos_SortStringChanged);
            this.adgvBusquedaArticulos.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.adgvBusquedaArticulos_FilterStringChanged);
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
            this.codigoDataGridViewTextBoxColumn.Width = 125;
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
            this.desmarDataGridViewTextBoxColumn.Width = 125;
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
            this.descatDataGridViewTextBoxColumn.Width = 125;
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
            this.btnBuscadorArticulo.Click += new System.EventHandler(this.btnBuscadorArticulo_Click);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabArticulos);
            this.tabControl.Controls.Add(this.tabBusqueda);
            this.tabControl.Location = new System.Drawing.Point(16, 15);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1433, 567);
            this.tabControl.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATALOGO_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewListarArticulosBindingSource)).EndInit();
            this.tabBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adgvBusquedaArticulos)).EndInit();
            this.tabArticulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource viewListarArticulosBindingSource;
        private CATALOGO_DBDataSet cATALOGO_DBDataSet;
        private System.Windows.Forms.BindingSource viewListarArticulosBindingSource1;
        private CATALOGO_DBDataSetTableAdapters.ViewListarArticulosTableAdapter viewListarArticulosTableAdapter;
        private System.Windows.Forms.TabPage tabBusqueda;
        private Zuby.ADGV.AdvancedDataGridView adgvBusquedaArticulos;
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
        private System.Windows.Forms.TabPage tabArticulos;
        private System.Windows.Forms.PictureBox picArticulo;
        private System.Windows.Forms.Button btnBuscadorArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnEditarArticulo;
        private System.Windows.Forms.Button btnNuevoArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TabControl tabControl;
    }
}

