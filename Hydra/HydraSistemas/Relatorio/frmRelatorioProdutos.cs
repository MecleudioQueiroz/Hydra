using Repository.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HydraSistemas.Relatorio
{
    public partial class frmRelatorioProdutos : Form
    {
        public frmRelatorioProdutos()
        {
            InitializeComponent();
        }

        private void frmRelatorioProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBHydraDataSet.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            this.produtosTableAdapter.Fill(this.dBHydraDataSet.Produtos);
            this.reportViewer1.RefreshReport();
        }
    }
}
