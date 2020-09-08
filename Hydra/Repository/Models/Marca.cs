using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
   public class Marca
    {
        public int MarcaId { get; set; }
        public string Nome { get; set; }

        public List<Produtos>ListaProtudos { get; set; }
    }
}
