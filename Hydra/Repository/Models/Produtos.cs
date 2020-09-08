using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
   public class Produtos
    {
        [Key]
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal ValorVarejo { get; set; }
        public decimal ValorAtacado { get; set; }
        public string CodigoBarras { get; set; }
        public string CodigoReferencia { get; set; }
        public string Descricao { get; set; }
        public int QtdEstoque { get; set; }
        public string ImagemUrl { get; set; }
        public string Ativo { get; set; }
        public string CodigoNcm { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedores Fornecedor { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }

    }
}
