using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class zarpado : Form
    {
        public zarpado()
        {
            InitializeComponent();
        }

        private void zarpado_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Que pasa larva");
        }
        private void zarpado_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }




    }
}
