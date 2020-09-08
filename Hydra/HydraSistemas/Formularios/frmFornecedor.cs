using Repository.Context;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HydraSistemas.Formularios
{
    public partial class frmFornecedor : Form
    {
        public frmFornecedor()
        {
            InitializeComponent();
            ListarFornecedor();
        }

        public void ListarFornecedor()
        {
           dataGridViewFornecedor.DataSource =  new Context().fornecedor.ToList();
        }      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Selecione a imagem";
            open.Filter = "JPG|*.jpg|PNG|*.png|GIF|*.gif|todos arquivos|*.*";
            open.Multiselect = false;
            if (open.ShowDialog() == DialogResult.OK)
            {
                lblCaminho.Text = open.FileName;
                ptbPerfil.ImageLocation = open.FileName;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                context.fornecedor.Add(new Fornecedores
                {
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Numero = txtNumero.Text,
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    UF = txtUF.Text,
                    Email = txtEmail.Text,
                    Telefone = txtTelefone.Text,
                    DtCadastro = Convert.ToDateTime(txtDataCadastro.Text),
                    CNPJ = txtCnpj.Text,
                    Cep = txtCep.Text,
                    InscricaoEstadual = txtInscricaoEstadual.Text,
                    Suframa = txtSuframa.Text,
                    NomeFantasia = txtNomeFantasia.Text,
                    ImagemUrl = ptbPerfil.ImageLocation
                   
                });
                //codigo para salvar imagem na pasta raiz do sistema.
                File.Copy(lblCaminho.Text, Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\Imagens", Path.GetFileName(lblCaminho.Text)));
                context.SaveChanges();
                MessageBox.Show("Fornecedor Cadastrado com Sucesso", "Aviso!");
                ListarFornecedor();
            }
        }
    }
}
