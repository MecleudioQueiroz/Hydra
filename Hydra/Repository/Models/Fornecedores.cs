using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
   public class Fornecedores
    {
        [Key]
        public int FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string ImagemUrl { get; set; }
        public DateTime DtCadastro { get; set; }
        public string CNPJ { get; set; }
        public string Cep { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Suframa { get; set; }
        public string NomeFantasia { get; set; }
    }
}
