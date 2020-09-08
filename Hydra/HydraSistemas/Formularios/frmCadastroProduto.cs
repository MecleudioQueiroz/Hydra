using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Context;
using Repository.Models;

namespace HydraSistemas
{
    public partial class frmCadastroProduto : Form
    {
        Produtos model = new Produtos();
        public frmCadastroProduto()
        {
            InitializeComponent();
            CarregarComboCategoria();
            CarregarComboFornecedor();
            CarregarComboMarca();
            ListaProdutos();
            DisabilitarCampo();
        }

        public void ListaProdutos()
        {
            dataGridViewProdutos.DataSource = new Context().produtos.ToList();
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            using (var context = new Context())
            {
                if (model.ProdutoId == 0)
                {
                    model.Nome = txtNome.Text;
                    model.ValorVarejo = Convert.ToDecimal(txtValorVarejo.Text);
                    model.ValorAtacado = Convert.ToDecimal(txtValorAtacado.Text);
                    model.CodigoBarras = txtCodigoBarras.Text;
                    model.CodigoReferencia = txtCodigoReferencia.Text;
                    model.Descricao = txtDescricao.Text;
                    model.QtdEstoque = Convert.ToInt32(txtQtdEstoque.Text);
                    model.Ativo = lbAtivo.Text;
                    model.CodigoNcm = txtCodigoNCM.Text;

                    model.FornecedorId = Convert.ToInt32(cbFornecedor.SelectedValue.ToString());
                    model.CategoriaId = Convert.ToInt32(cbCategoria.SelectedValue.ToString());
                    model.MarcaId = Convert.ToInt32(cbMarca.SelectedValue.ToString());
                    context.produtos.Add(model);
                }
                //context.produtos.Add(new Produtos
                //{
                //    Nome = txtNome.Text,
                //    ValorVarejo = Convert.ToDecimal(txtValorVarejo.Text),
                //    ValorAtacado = Convert.ToDecimal(txtValorAtacado.Text),
                //    CodigoBarras = txtCodigoBarras.Text,
                //    CodigoReferencia = txtCodigoReferencia.Text,
                //    Descricao = txtDescricao.Text,
                //    QtdEstoque = Convert.ToInt32(txtQtdEstoque.Text),
                //    Ativo = lbAtivo.Text,
                //    CodigoNcm = txtCodigoNCM.Text,

                //    FornecedorId = Convert.ToInt32(cbFornecedor.SelectedValue.ToString()),
                //    CategoriaId = Convert.ToInt32(cbCategoria.SelectedValue.ToString()),
                //    MarcaId = Convert.ToInt32(cbMarca.SelectedValue.ToString()),
                //});


                else
                {
                    context.Entry(model).State = EntityState.Modified;
                    MessageBox.Show("Atualizado com Sucesso");
                }

                context.SaveChanges();
                ListaProdutos();
                LimparCampos();
            }
        }
        //metodo para limpar campos apos salvar os dados
        public void LimparCampos()
        {
            txtNome.Clear();
            txtValorVarejo.Clear();
            txtValorAtacado.Clear();
            txtCodigoBarras.Clear();
            txtCodigoReferencia.Clear();
            txtDescricao.Clear();
            txtQtdEstoque.Clear();
            //Ativo = Convert.ToBoolean(txtAtivo.Text),
            txtCodigoNCM.Clear();
            cbFornecedor.Text = "";
            cbCategoria.Text = "";
            cbMarca.Text = "";
        }

        public void DisabilitarCampo()
        {
            btnCancelar.Visible = false;
            btnCadastrar.Enabled = false;
            txtNome.Enabled = false;
            txtValorVarejo.Enabled = false;
            txtValorAtacado.Enabled = false;
            txtCodigoBarras.Enabled = false;
            txtCodigoReferencia.Enabled = false;
            txtDescricao.Enabled = false;
            txtQtdEstoque.Enabled = false;
            lbAtivo.Enabled = false;
            rdAtivo.Enabled = false;
            rdInativo.Enabled = false;
            txtCodigoNCM.Enabled = false;
            cbFornecedor.Enabled = false;
            cbCategoria.Enabled = false;
            cbMarca.Enabled = false;
        }

        public void HabilitarCampo()
        {
            btnCancelar.Visible = true;
            btnCadastrar.Enabled = true;
            txtNome.Enabled = true;
            txtValorVarejo.Enabled = true;
            txtValorAtacado.Enabled = true;
            txtCodigoBarras.Enabled = true;
            txtCodigoReferencia.Enabled = true;
            txtDescricao.Enabled = true;
            txtQtdEstoque.Enabled = true;
            lbAtivo.Enabled = true;
            rdAtivo.Enabled = true;
            rdInativo.Enabled = true;
            txtCodigoNCM.Enabled = true;
            cbFornecedor.Enabled = true;
            cbCategoria.Enabled = true;
            cbMarca.Enabled = true;
        }

        //metodo para carregar categoria no combobox
        public void CarregarComboCategoria()
        {
            using (var context = new Context())
            {
                cbCategoria.DataSource = context.categorias.ToList();
                cbCategoria.ValueMember = "CategoriaId";
                cbCategoria.DisplayMember = "Nome";
                cbCategoria.Refresh();
            }
        }

        public void CarregarComboFornecedor()
        {
            using (var context = new Context())
            {
                cbFornecedor.DataSource = context.fornecedor.ToList();
                cbFornecedor.ValueMember = "FornecedorId";
                cbFornecedor.DisplayMember = "Nome";
                cbFornecedor.Refresh();
            }
        }

        public void CarregarComboMarca()
        {
            using (var context = new Context())
            {
                cbMarca.DataSource = context.marcas.ToList();
                cbMarca.ValueMember = "MarcaId";
                cbMarca.DisplayMember = "MarcaId";
                cbMarca.Refresh();
            }
        }

        public void Ativo()
        {
            lbAtivo.Text = "";
            if (rdAtivo.Checked)
            {
                lbAtivo.Text = rdAtivo.Text;
            }
            if (rdInativo.Checked)
            {
                lbAtivo.Text = rdInativo.Text;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("deseja abandonar o formulario ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }

        } 

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DisabilitarCampo();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.CurrentRow.Index != -1)
            {
                model.ProdutoId = Convert.ToInt32(dataGridViewProdutos.CurrentRow.Cells["ProdutoId"].Value);
                using (Context db = new Context())
                {
                    model = db.produtos.Where(x => x.ProdutoId == model.ProdutoId).FirstOrDefault();
                    txtNome.Text = model.Nome;
                    txtValorVarejo.Text = model.ValorVarejo.ToString();
                    txtValorAtacado.Text = model.ValorAtacado.ToString();
                    txtCodigoBarras.Text = model.CodigoBarras;
                    txtCodigoReferencia.Text = model.CodigoReferencia;
                    txtDescricao.Text = model.Descricao;
                    txtQtdEstoque.Text = model.QtdEstoque.ToString();
                    lbAtivo.Text = model.Ativo;
                    txtCodigoNCM.Text = model.CodigoNcm;

                    cbFornecedor.SelectedValue = model.FornecedorId.ToString();
                    cbCategoria.SelectedValue = model.CategoriaId.ToString();
                    cbMarca.SelectedValue = model.Marca.ToString();

                }
                HabilitarCampo();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.CurrentRow.Index != -1)
            {
                model.ProdutoId = Convert.ToInt32(dataGridViewProdutos.CurrentRow.Cells["ProdutoId"].Value);
                using (Context db = new Context())
                {
                    model = db.produtos.Where(x => x.ProdutoId == model.ProdutoId).FirstOrDefault();
                    txtNome.Text = model.Nome;
                    txtValorVarejo.Text = model.ValorVarejo.ToString();
                    txtValorAtacado.Text = model.ValorAtacado.ToString();
                    txtCodigoBarras.Text = model.CodigoBarras;
                    txtCodigoReferencia.Text = model.CodigoReferencia;
                    txtDescricao.Text = model.Descricao;
                    txtQtdEstoque.Text = model.QtdEstoque.ToString();
                    lbAtivo.Text = model.Ativo;
                    txtCodigoNCM.Text = model.CodigoNcm;

                    cbFornecedor.SelectedValue = model.FornecedorId.ToString();
                    cbCategoria.SelectedValue = model.CategoriaId.ToString();
                    cbMarca.SelectedValue = model.Marca.ToString();

                }

            }

            if (MessageBox.Show("Deseja Remover o Produto? |"+model.Nome," Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {              
                using (var context = new Context())
                {
                    context.Entry(model).State = EntityState.Deleted;
                    context.SaveChanges();
                    MessageBox.Show("Produto Removido com Sucesso! "+model.Nome);
                    ListaProdutos();
                }

            }
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            HabilitarCampo();
        }
    }
}


