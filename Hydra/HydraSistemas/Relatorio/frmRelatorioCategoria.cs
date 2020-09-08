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
    public partial class frmRelatorioCategoria : Form
    {
        public frmRelatorioCategoria()
        {
            InitializeComponent();
        }

        private void frmRelatorioCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBHydraDataSet.Categorias'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriasTableAdapter.Fill(this.dBHydraDataSet.Categorias);

            this.reportViewer1.RefreshReport();
        }
    }
}
