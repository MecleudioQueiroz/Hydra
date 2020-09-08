using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
   public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required(ErrorMessage ="Campo Obrigatorio")]
        public string Nome { get; set; }
        public List<Produtos>ListaProdutos { get; set; }        
    }
}
