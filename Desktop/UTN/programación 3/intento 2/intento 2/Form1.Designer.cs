namespace intento_2
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Cajaapellido = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nombre = new System.Windows.Forms.Label();
            this.Cajanombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cajaedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cajadireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.RESULTADO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(90, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "APELLIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Cajaapellido
            // 
            this.Cajaapellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cajaapellido.Location = new System.Drawing.Point(178, 45);
            this.Cajaapellido.MaxLength = 30;
            this.Cajaapellido.Name = "Cajaapellido";
            this.Cajaapellido.Size = new System.Drawing.Size(180, 20);
            this.Cajaapellido.TabIndex = 2;
            this.Cajaapellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Cajaapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombre.Location = new System.Drawing.Point(90, 82);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(75, 18);
            this.nombre.TabIndex = 6;
            this.nombre.Text = "NOMBRE";
            this.nombre.Click += new System.EventHandler(this.label3_Click);
            // 
            // Cajanombre
            // 
            this.Cajanombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cajanombre.Location = new System.Drawing.Point(178, 80);
            this.Cajanombre.MaxLength = 30;
            this.Cajanombre.Name = "Cajanombre";
            this.Cajanombre.Size = new System.Drawing.Size(180, 20);
            this.Cajanombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(90, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "EDAD";
            // 
            // Cajaedad
            // 
            this.Cajaedad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cajaedad.Location = new System.Drawing.Point(178, 116);
            this.Cajaedad.MaxLength = 30;
            this.Cajaedad.Name = "Cajaedad";
            this.Cajaedad.Size = new System.Drawing.Size(180, 20);
            this.Cajaedad.TabIndex = 9;
            this.Cajaedad.TextChanged += new System.EventHandler(this.Cajaedad_TextChanged);
            this.Cajaedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cajaedad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(80, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "DIRECCIÓN";
            // 
            // Cajadireccion
            // 
            this.Cajadireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cajadireccion.Location = new System.Drawing.Point(178, 152);
            this.Cajadireccion.MaxLength = 30;
            this.Cajadireccion.Name = "Cajadireccion";
            this.Cajadireccion.Size = new System.Drawing.Size(180, 20);
            this.Cajadireccion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(70, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "RESULTADO";
            // 
            // botonAceptar
            // 
            this.botonAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonAceptar.Location = new System.Drawing.Point(140, 384);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 14;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RESULTADO
            // 
            this.RESULTADO.Location = new System.Drawing.Point(160, 234);
            this.RESULTADO.Multiline = true;
            this.RESULTADO.Name = "RESULTADO";
            this.RESULTADO.Size = new System.Drawing.Size(330, 112);
            this.RESULTADO.TabIndex = 15;
            this.RESULTADO.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(610, 419);
            this.Controls.Add(this.RESULTADO);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cajadireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cajaedad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cajanombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.Cajaapellido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "programazo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Cajaapellido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox Cajanombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cajaedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Cajadireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.TextBox RESULTADO;
    }
}

