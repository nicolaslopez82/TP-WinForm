namespace SeriePokemon
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
            this.dgvPokemons = new System.Windows.Forms.DataGridView();
            this.PicPokemon = new System.Windows.Forms.PictureBox();
            this.dgvElemento = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemons
            // 
            this.dgvPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemons.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemons.Location = new System.Drawing.Point(25, 73);
            this.dgvPokemons.MultiSelect = false;
            this.dgvPokemons.Name = "dgvPokemons";
            this.dgvPokemons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemons.Size = new System.Drawing.Size(593, 272);
            this.dgvPokemons.TabIndex = 0;
            this.dgvPokemons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgPokemons_CellContentClick);
            this.dgvPokemons.SelectionChanged += new System.EventHandler(this.dgvPokemons_SelectionChanged);
            // 
            // PicPokemon
            // 
            this.PicPokemon.Location = new System.Drawing.Point(732, 73);
            this.PicPokemon.Name = "PicPokemon";
            this.PicPokemon.Size = new System.Drawing.Size(314, 262);
            this.PicPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPokemon.TabIndex = 1;
            this.PicPokemon.TabStop = false;
            // 
            // dgvElemento
            // 
            this.dgvElemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElemento.Location = new System.Drawing.Point(78, 410);
            this.dgvElemento.Name = "dgvElemento";
            this.dgvElemento.Size = new System.Drawing.Size(443, 207);
            this.dgvElemento.TabIndex = 2;
            this.dgvElemento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElemento_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(59, 351);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(74, 44);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(166, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 44);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 675);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvElemento);
            this.Controls.Add(this.PicPokemon);
            this.Controls.Add(this.dgvPokemons);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemons;
        private System.Windows.Forms.PictureBox PicPokemon;
        private System.Windows.Forms.DataGridView dgvElemento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
    }
}

