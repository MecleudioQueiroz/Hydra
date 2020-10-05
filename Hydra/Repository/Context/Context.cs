using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Repository.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Repository.Context
{
   public class Context:DbContext
    {
        
        public Context( ):base("DB")
        {
            
        }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Fornecedores> fornecedor { get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Produtos> produtos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }


        public static SqlConnection con()
        {
            try
            {
                SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ToString());
                conectar.Open();
                return conectar;
            }
            catch (Exception)
            {

                throw new Exception("Erro ao se Conectar"); ;
            }
        }

    }
}
