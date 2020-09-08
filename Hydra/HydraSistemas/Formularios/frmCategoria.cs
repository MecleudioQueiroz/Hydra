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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
            listaCategoria();
        }

        public void listaCategoria()
        {
            using (var context = new Context())
            {
                dtGridCategoria.DataSource = context.categorias.ToList();
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            using (var context = new Context())
            {              
                    context.categorias.Add(new Categoria
                    {
                        Nome = txtNomeCategoria.Text
                    });
                              
                context.SaveChanges();
                MessageBox.Show("Cadastro com Sucesso", "Aviso");
                listaCategoria();
                txtNomeCategoria.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
