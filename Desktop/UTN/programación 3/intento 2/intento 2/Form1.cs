using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intento_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("nos vimos");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
             * MouseEventArgs Click = (MouseEventArgs)e;
              if (Click.Button == MouseButtons.Left)
                  MessageBox.Show("Alto click izuierdo");
              else if (Click.Button == MouseButtons.Right)
                  MessageBox.Show("Alto Click Derecho");
            */
            if (Cajaapellido.Text == "")
                Cajaapellido.BackColor = Color.Red;
            else
                Cajaapellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, EventArgs e)
        {
            label1.BackColor = Color.Cyan;
            label1.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
            label1.Cursor = Cursors.Arrow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cajaedad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cajaedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Cajaapellido.Text == "")
            {
                Cajaapellido.BackColor = Color.Red;
            }
            else
            {
                Cajaapellido.BackColor = System.Drawing.SystemColors.Control;
            }
            if (Cajanombre.Text == "")
            {
                Cajanombre.BackColor = Color.Red;
            }
            else
            {
                Cajanombre.BackColor = System.Drawing.SystemColors.Control;
            }
            if (Cajaedad.Text == "")
            {
                Cajaedad.BackColor = Color.Red;
            }
            else
            {
                Cajaedad.BackColor = System.Drawing.SystemColors.Control;
            }
            if (Cajadireccion.Text == "")
            {
                Cajadireccion.BackColor = Color.Red;
            }
            else
            {
                Cajadireccion.BackColor = System.Drawing.SystemColors.Control;
            }

            RESULTADO.Text = "Nombre Y Apellido: " + Cajanombre.Text + " " + Cajaapellido.Text + " " +
             "Edad: " + Cajaedad.Text + " " +  "Dirección: " + Cajadireccion.Text;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            MessageBox.Show("Apellido"+ Cajaapellido);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            
        }
    }
}
