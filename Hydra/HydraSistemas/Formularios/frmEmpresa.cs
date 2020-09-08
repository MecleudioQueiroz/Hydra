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
using System.Windows.Forms;

namespace HydraSistemas.Formularios
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
            ListarEmpresa();
            DesabilitarCampos();
        }

        public void ListarEmpresa()
        {
            dataGridViewEmpresa.DataSource = new Context().empresas.ToList();
        }

        public void LimparCampos()
        {
            txtRazaoSocial.Clear();
            txtNomeFantasia.Clear();
            txtCNPJ.Clear();
            txtInscricaoEstatual.Clear();
            txtInscricaoMunicipal.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtUF.Clear();
            txtTelefone.Clear();
            txtNumero.Clear();
            txtCidade.Clear();
            txtRumoAtividade.Clear();
            txtCanaFiscal.Clear();
            txtNumeroJucer.Clear();
        }

        public void DesabilitarCampos()
        {          
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            txtRazaoSocial.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtCNPJ.Enabled = false;
            txtInscricaoEstatual.Enabled = false;
            txtInscricaoMunicipal.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtUF.Enabled = false;
            txtTelefone.Enabled = false;
            txtNumero.Enabled = false;
            txtCidade.Enabled = false;
            txtRumoAtividade.Enabled = false;
            txtCanaFiscal.Enabled = false;
            txtNumeroJucer.Enabled = false;
        }

        public void HabilitarCampos()
        {
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            txtRazaoSocial.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtCNPJ.Enabled = true;
            txtInscricaoEstatual.Enabled = true;
            txtInscricaoMunicipal.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtUF.Enabled = true;
            txtTelefone.Enabled = true;
            txtNumero.Enabled = true;
            txtCidade.Enabled = true;
            txtRumoAtividade.Enabled = true;
            txtCanaFiscal.Enabled = true;
            txtNumeroJucer.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                context.empresas.Add(new Empresa
                {
                    RazaoSocial = txtRazaoSocial.Text,
                    NomeFantasia = txtNomeFantasia.Text,
                    CNPJ = txtCNPJ.Text,
                    IncricaoEstadual = txtInscricaoEstatual.Text,
                    InscricaoMunicipal = txtInscricaoMunicipal.Text,
                    Endereco = txtEndereco.Text,
                    Bairro = txtBairro.Text,
                    Cep = txtCep.Text,
                    UF = txtUF.Text,
                    Telefone = txtTelefone.Text,
                    Numero = txtNumero.Text,
                    Cidade = txtCidade.Text,
                    RumoDeAtividade = txtRumoAtividade.Text,
                    CnaeFiscal = txtCanaFiscal.Text,
                    NumeroJucer = txtNumeroJucer.Text,                  
                });
                context.SaveChanges();
                MessageBox.Show("Empresa cadastrada com Sucesso!", "Aviso!");
                ListarEmpresa();
                LimparCampos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            btnNovaEmpresa.Enabled = true;
        }

        private void btnNovaEmpresa_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            btnNovaEmpresa.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
