using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using negocio;
namespace SeriePokemon
{
    public partial class Form1 : Form
    {
        private List<Pokemon> listapokemon;
        private List<Elemento> listarelemento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        
        private void dvgPokemons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listapokemon = negocio.listar();
                dgvPokemons.DataSource = listapokemon;
                dgvPokemons.Columns["UrlImagen"].Visible = false;
                dgvPokemons.Columns["Id"].Visible = false;
                PicPokemon.Load(listapokemon[0].UrlImagen);

                ElementoNegocio negocio2 = new ElementoNegocio();
                listarelemento = negocio2.listar();
                dgvElemento.DataSource = listarelemento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                PicPokemon.Load(imagen);
            }
            catch (Exception ex )
            {

                PicPokemon.Load("http://pm1.narvii.com/6198/fcfbd569c12bb211d5958ff9ac227590f0855a35_00.jpg");
            }
        }
        private void dgvElemento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaPokemon alta = new frmAltaPokemon();
            alta.ShowDialog();
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;
            frmAltaPokemon modificar = new frmAltaPokemon(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
