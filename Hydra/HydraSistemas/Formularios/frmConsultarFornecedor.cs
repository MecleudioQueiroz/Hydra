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
using System.IO;

namespace HydraSistemas.Formularios
{
    public partial class frmConsultarFornecedor : Form
    {
        public frmConsultarFornecedor()
        {
            InitializeComponent();
            ListarFornecedor();
        }

        public void ListarFornecedor()
        {
            using (var context = new Context())
            {
                dataGridViewFornecedor.DataSource = context.fornecedor.ToList();
            }
        }

        public Image ConverterImagem(byte[] Photo)
        {
            Image novaImagem;
            using (MemoryStream ms = new MemoryStream(Photo,0,Photo.Length))
            {
                ms.Write(Photo, 0, Photo.Length);
                novaImagem = Image.FromStream(ms, true);
            }
            return novaImagem;
        }

        private void txtPesquisar_Click(object sender, EventArgs e)
        {
            Context context = new Context();
            int id = Convert.ToInt32(txtId.Text);
            
            Fornecedores fo = context.fornecedor.Single(forne => forne.FornecedorId == id);
            //ptbPerfil = Convert.ToByte(fo.ImagemUrl);
            txtCPF.Text = fo.Nome;
            txtCNPJ.Text = fo.NomeFantasia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
