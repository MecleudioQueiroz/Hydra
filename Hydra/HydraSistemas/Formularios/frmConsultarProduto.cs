using Repository.Context;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraSistemas.Formularios
{
    public partial class frmConsultarProduto : Form
    {
        public frmConsultarProduto()
        {
            InitializeComponent();
            ListarProdutos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListarProdutos()
        {
            using (var context = new Context())
            {
                dataGridViewProdutos.DataSource = context.produtos.OrderBy(p => p.ValorVarejo).ToList();

                dataGridViewProdutos.Columns["CodigoNcm"].Visible = false;
                dataGridViewProdutos.Columns["ValorAtacado"].Visible = false;
                dataGridViewProdutos.Columns["Descricao"].Visible = false;
                dataGridViewProdutos.Columns["ImagemUrl"].Visible = false;
                dataGridViewProdutos.Columns["Fornecedor"].Visible = false;
                dataGridViewProdutos.Columns["Categoria"].Visible = false;
                dataGridViewProdutos.Columns["Marca"].Visible = false;

            }
        }

        //metodo para filtrar produto pelo nome, e exibir equanto escreve
        public void filtrar(DataGridView data, string BuscarNome)
        {
            SqlCommand sql = new SqlCommand("filtro_BuscarProduto", Context.con());
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.Add("@filtro", SqlDbType.VarChar, 200).Value = BuscarNome;

            sql.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql);
            da.Fill(dt);
            data.DataSource = dt;
        }

        private void txtNomeProduto_TextChanged_1(object sender, EventArgs e)
        {
            filtrar(dataGridViewProdutos, txtNomeProduto.Text.Trim());
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {             
                //fr.AbrirFormNoPanel<frmCadastroProduto>();
            this.Close();
            new frmCadastroProduto().Show();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
