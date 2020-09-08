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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
            PrencherCombobox();
            PreencherGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                var v = txtBucar.Text;
               dataGridViewFuncionario.DataSource = context.funcionarios.Where(x => x.Nome == v);
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            using (var context = new Context())
            {
                context.funcionarios.Add(new Funcionario
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
                    CPF = Convert.ToInt32(txtCpf.Text),
                    EmpresaId = int.Parse(cbxEmpresa.SelectedValue.ToString()),
                });
                context.SaveChanges();
                MessageBox.Show("Salvo com Sucesso", "Aviso!");
                PreencherGrid();
            }
        }

        public void PrencherCombobox()
        {          
            cbxEmpresa.DataSource = new Context().empresas.ToList();
            cbxEmpresa.ValueMember = "EmpresaId";
            cbxEmpresa.DisplayMember = "NomeFantasia";
            cbxEmpresa.Refresh();       
        }

        public void PreencherGrid()
        {
            dataGridViewFuncionario.DataSource = new Context().funcionarios.ToList();
        }

        public void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUF.Enabled = true;
            txtEmail.Enabled = true;
            txtTelefone.Enabled = true;
            txtDataCadastro.Enabled = true;
            txtCpf.Enabled = true;
            txtNome.Enabled = true;
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
