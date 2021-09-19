using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace dominio
{
    public class Catalogo
    {
        public int Id { get; set; }
        
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        public Catalogo() { }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
