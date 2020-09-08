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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
            ListarMarca();
            CreateUnboundButtonColumn();
        }

        public void ListarMarca()
        {
            using (var context = new Context())
            {
                dataGridViewMarca.DataSource = context.marcas.ToList();
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            string nome = marca.Nome;
            Context context = new Context();
            context.marcas.Add(new Marca { Nome = txtNomeMarca.Text });

            context.SaveChanges();

            MessageBox.Show("Marca '"+txtNomeMarca.Text.ToString() + "' Cadastrado com Sucesso!", "Aviso!");
            ListarMarca();    
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }  

        private void CreateUnboundButtonColumn()
        {
            // Inicialize a coluna do botão.
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Op";
            buttonColumn.HeaderText = "Op";
            buttonColumn.Text = "Excluir";

            // Use a propriedade Text para o texto do botão em todas as células
            // do que usar o valor de cada célula como texto para seu próprio botão.
            buttonColumn.UseColumnTextForButtonValue = true;

            // Adicione a coluna do botão ao controle.
            dataGridViewMarca.Columns.Insert(2, buttonColumn);
            
        }

        private void dataGridViewMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewMarca.Columns["Op"].Index)
                return;
            Context c = new Context();
            dataGridViewMarca.Rows.RemoveAt(e.RowIndex);
        }
    }
}

