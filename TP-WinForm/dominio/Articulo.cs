using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }    
        
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Marca")]
        public Marca Marca { get; set; }

        [DisplayName("Catalogo")]
        public Catalogo Categoria { get; set; }

        [DisplayName("Imagen")]
        public string Imagen { get; set; }

        public decimal Precio { get; set; }

        public Articulo() { }

        public override string ToString()
        {
            return "Codigo: " + Codigo + " '\n' " + 
                   " Descripcion: " + Descripcion + " '\n' " + 
                   " Nombre: " + Nombre + " '\n' " +
                   " Marca: " + Marca + " '\n' " + 
                   " Categoria: " + Categoria + " '\n' " + 
                   " Precio: " + Precio + " '\n' ";
        }
    }
} 
