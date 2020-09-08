using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
   public class Empresa
    {
        public int EmpresaId { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public string IncricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string UF { get; set; }
        public string Telefone { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string RumoDeAtividade { get; set; }
        public string CnaeFiscal { get; set; }
        public string NumeroJucer { get; set; }

        public List<Fornecedores>ListaFornecedores { get; set; }
        public List<Funcionario>ListaFuncionarios { get; set; }
    }
}
