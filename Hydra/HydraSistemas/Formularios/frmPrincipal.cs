using HydraSistemas.Formularios;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using HydraSistemas.Relatorio;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace HydraSistemas
{
    public partial class frmPrincipal : Form
    {
        //definir o código para poder mover o formulário usando o 
        //mouse.Para isso vamos usar recursos de interoperabilidade 
        //que permitem que você use código nativa a partir de aplicações.NET
        //bem como permite acessar assemblies.NET como se fossem componentes COM.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Para concluir basta definir o código no evento MouseMove 
        //do panel panelCabecalho conforme a seguir:
        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public frmPrincipal()
        {
            //alerta mensagem no canto do Windows
            StyleManager.Style = eStyle.Office2016;
            InitializeComponent();
        }

  
        //metodo com evento botao, para exibir mensagem canto inferior do windows
        private long _RunningAlertId = 0;
        private void metroCaixa_Click(object sender, EventArgs e)
        {
            string text = "Bem vindo ao Caixa";
            var valorTempo = 6;

            _RunningAlertId++;
            eDesktopAlertColor color = eDesktopAlertColor.Default;
            eAlertPosition position = eAlertPosition.BottomRight;
            DesktopAlert.Show(text, "\uf005", eSymbolSet.Awesome, Color.Empty, color, position, valorTempo, _RunningAlertId, AlertClicked);

        }
        private void AlertClicked(long alertId)
        {
            //listBoxAdv1.Items.Insert(0, "Alert clicked, ID: " + alertId.ToString());
        }

        private void menuCadastroProduto_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmCadastroProduto>();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Mudando cor do fundo do formulario principal
            foreach (Control controle in this.Controls)
            {
                if (controle is MdiClient)
                {
                    controle.BackColor = Color.White;
                    break;
                }
            }
        }

        private void menuCadatroCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmCategoria>();
        }

        //Evento responsivel para o menu vertical
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 176)
            {
                menuVertical.Width = 70;
            }
            else
            {
                menuVertical.Width = 176;
            }
        }

        //Precisamos incluir um método no formulário para poder abrir os 
        //formulários no panel panelConteudo.Veja abaixo uma sugestão para
        //o código que faz esse serviço:
        //Criamos o método genérico AbrirFormNoPanel<Forms>() que vai receber os 
        //formulários a serem abertos no panelConteudo.Assim podemos ter mais de 
        //um formulário no Panel.
        public void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = painelCentro.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                painelCentro.Controls.Add(formulario);
                painelCentro.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBoxEx.Show("Deseja Sair do Sistema ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            };   
        }

        private void MenuCadastroMarca_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmMarca>();
        }

        private void menuCadastroFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmFornecedor>();
        }

        private void menuCadastroFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmFuncionario>();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmEmpresa>();
        }

        private void tmDataHora_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmRelatorioCategoria>();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            PDV.MainWindow tela = new PDV.MainWindow();
            tela.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void metroProdutoLista_Click(object sender, EventArgs e)
        {
            
            AbrirFormNoPanel<frmConsultarProduto>();
        }

        private void metroBuscarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bem Vindo Cliente");
        }

        private void metroBuscarFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmConsultarFornecedor>();
        }

        private void produtosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRelatorioProdutos().Show();
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AbrirFormNoPanel<frmOrdemDeServico>();
            new frmOrdemDeServico().ShowDialog();

        }

        private void metroOrdemServico_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<frmConsultaOrdemServico>();
        }

        private void metroOrcamento_Click(object sender, EventArgs e)
        {

        } 
    }
}
