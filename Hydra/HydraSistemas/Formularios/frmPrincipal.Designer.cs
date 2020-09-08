namespace HydraSistemas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balançoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadatroCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosSemEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.metroCompras = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroPDV = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroBuscarFornecedor = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroBuscarCliente = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroEntradaXML = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroCaixa = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroOrdemServico = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroOrcamento = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroProdutoLista = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.tmDataHora = new System.Windows.Forms.Timer(this.components);
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.menuVertical = new System.Windows.Forms.Panel();
            this.btnContas = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.btnCompras = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.painelCentro = new System.Windows.Forms.Panel();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.menuVertical.SuspendLayout();
            this.painelCentro.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaXMLToolStripMenuItem,
            this.entradaToolStripMenuItem,
            this.saidaToolStripMenuItem,
            this.balançoToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // entradaXMLToolStripMenuItem
            // 
            this.entradaXMLToolStripMenuItem.Name = "entradaXMLToolStripMenuItem";
            this.entradaXMLToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.entradaXMLToolStripMenuItem.Text = "Entrada XML";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.saidaToolStripMenuItem.Text = "Saida";
            // 
            // balançoToolStripMenuItem
            // 
            this.balançoToolStripMenuItem.Name = "balançoToolStripMenuItem";
            this.balançoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.balançoToolStripMenuItem.Text = "Balanço";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroProduto,
            this.menuCadatroCategoria,
            this.MenuCadastroMarca,
            this.menuCadastroFornecedor,
            this.menuCadastroFuncionario,
            this.empresaToolStripMenuItem,
            this.serviçoToolStripMenuItem,
            this.ordemDeServiçoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuCadastroProduto
            // 
            this.menuCadastroProduto.Name = "menuCadastroProduto";
            this.menuCadastroProduto.Size = new System.Drawing.Size(167, 22);
            this.menuCadastroProduto.Text = "Produtos";
            this.menuCadastroProduto.Click += new System.EventHandler(this.menuCadastroProduto_Click);
            // 
            // menuCadatroCategoria
            // 
            this.menuCadatroCategoria.Name = "menuCadatroCategoria";
            this.menuCadatroCategoria.Size = new System.Drawing.Size(167, 22);
            this.menuCadatroCategoria.Text = "Categoria";
            this.menuCadatroCategoria.Click += new System.EventHandler(this.menuCadatroCategoria_Click);
            // 
            // MenuCadastroMarca
            // 
            this.MenuCadastroMarca.Name = "MenuCadastroMarca";
            this.MenuCadastroMarca.Size = new System.Drawing.Size(167, 22);
            this.MenuCadastroMarca.Text = "Marca";
            this.MenuCadastroMarca.Click += new System.EventHandler(this.MenuCadastroMarca_Click);
            // 
            // menuCadastroFornecedor
            // 
            this.menuCadastroFornecedor.Name = "menuCadastroFornecedor";
            this.menuCadastroFornecedor.Size = new System.Drawing.Size(167, 22);
            this.menuCadastroFornecedor.Text = "Fornecedor";
            this.menuCadastroFornecedor.Click += new System.EventHandler(this.menuCadastroFornecedor_Click);
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(167, 22);
            this.menuCadastroFuncionario.Text = "Funcionario";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.menuCadastroFuncionario_Click);
            // 
            // empresaToolStripMenuItem
            // 
            this.empresaToolStripMenuItem.Name = "empresaToolStripMenuItem";
            this.empresaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.empresaToolStripMenuItem.Text = "Empresa";
            this.empresaToolStripMenuItem.Click += new System.EventHandler(this.empresaToolStripMenuItem_Click);
            // 
            // serviçoToolStripMenuItem
            // 
            this.serviçoToolStripMenuItem.Name = "serviçoToolStripMenuItem";
            this.serviçoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.serviçoToolStripMenuItem.Text = "Serviço";
            // 
            // ordemDeServiçoToolStripMenuItem
            // 
            this.ordemDeServiçoToolStripMenuItem.Name = "ordemDeServiçoToolStripMenuItem";
            this.ordemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ordemDeServiçoToolStripMenuItem.Text = "Ordem de serviço";
            this.ordemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.ordemDeServiçoToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosCadastradosToolStripMenuItem,
            this.produtosPorToolStripMenuItem,
            this.produtosSemEstoqueToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // produtosCadastradosToolStripMenuItem
            // 
            this.produtosCadastradosToolStripMenuItem.Name = "produtosCadastradosToolStripMenuItem";
            this.produtosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.produtosCadastradosToolStripMenuItem.Text = "Produtos Cadastrados";
            this.produtosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.produtosCadastradosToolStripMenuItem_Click);
            // 
            // produtosPorToolStripMenuItem
            // 
            this.produtosPorToolStripMenuItem.Name = "produtosPorToolStripMenuItem";
            this.produtosPorToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.produtosPorToolStripMenuItem.Text = "Produtos por Grupo/Categoria";
            // 
            // produtosSemEstoqueToolStripMenuItem
            // 
            this.produtosSemEstoqueToolStripMenuItem.Name = "produtosSemEstoqueToolStripMenuItem";
            this.produtosSemEstoqueToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.produtosSemEstoqueToolStripMenuItem.Text = "Produtos sem estoque";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Location = new System.Drawing.Point(13, 3);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 31);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 6;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1272, -3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(30, 27);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // metroCompras
            // 
            this.metroCompras.Image = ((System.Drawing.Image)(resources.GetObject("metroCompras.Image")));
            this.metroCompras.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroCompras.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroCompras.Name = "metroCompras";
            this.metroCompras.SymbolColor = System.Drawing.Color.Empty;
            this.metroCompras.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange;
            this.metroCompras.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroCompras.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroCompras.TitleText = "Compras";
            this.metroCompras.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroPDV
            // 
            this.metroPDV.Image = global::HydraSistemas.Properties.Resources.pdvNovo;
            this.metroPDV.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroPDV.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroPDV.Name = "metroPDV";
            this.metroPDV.SymbolColor = System.Drawing.Color.Empty;
            this.metroPDV.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkOlive;
            this.metroPDV.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroPDV.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroPDV.TitleText = "PDV";
            this.metroPDV.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroPDV.TitleTextColor = System.Drawing.Color.White;
            // 
            // metroBuscarFornecedor
            // 
            this.metroBuscarFornecedor.Image = global::HydraSistemas.Properties.Resources.buscarcnpj;
            this.metroBuscarFornecedor.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroBuscarFornecedor.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroBuscarFornecedor.Name = "metroBuscarFornecedor";
            this.metroBuscarFornecedor.SymbolColor = System.Drawing.Color.Empty;
            this.metroBuscarFornecedor.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            this.metroBuscarFornecedor.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroBuscarFornecedor.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroBuscarFornecedor.TitleText = " Fornecedor";
            this.metroBuscarFornecedor.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroBuscarFornecedor.Click += new System.EventHandler(this.metroBuscarFornecedor_Click);
            // 
            // metroBuscarCliente
            // 
            this.metroBuscarCliente.Image = global::HydraSistemas.Properties.Resources.consulta_cpf;
            this.metroBuscarCliente.ImageIndent = new System.Drawing.Point(-1, 1);
            this.metroBuscarCliente.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroBuscarCliente.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.metroBuscarCliente.Name = "metroBuscarCliente";
            this.metroBuscarCliente.SymbolColor = System.Drawing.Color.Empty;
            this.metroBuscarCliente.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            this.metroBuscarCliente.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroBuscarCliente.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroBuscarCliente.TitleText = "Cliente";
            this.metroBuscarCliente.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroBuscarCliente.Click += new System.EventHandler(this.metroBuscarCliente_Click);
            // 
            // metroEntradaXML
            // 
            this.metroEntradaXML.Image = global::HydraSistemas.Properties.Resources.entrada_XML2;
            this.metroEntradaXML.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroEntradaXML.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroEntradaXML.Name = "metroEntradaXML";
            this.metroEntradaXML.SymbolColor = System.Drawing.Color.Empty;
            this.metroEntradaXML.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            this.metroEntradaXML.TileSize = new System.Drawing.Size(250, 120);
            // 
            // 
            // 
            this.metroEntradaXML.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroEntradaXML.TitleText = "Entrada XML";
            this.metroEntradaXML.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroCaixa
            // 
            this.metroCaixa.Image = global::HydraSistemas.Properties.Resources.caixa1;
            this.metroCaixa.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroCaixa.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroCaixa.Name = "metroCaixa";
            this.metroCaixa.SymbolColor = System.Drawing.Color.Empty;
            this.metroCaixa.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray;
            this.metroCaixa.TileSize = new System.Drawing.Size(250, 120);
            // 
            // 
            // 
            this.metroCaixa.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroCaixa.TitleText = "Caixa";
            this.metroCaixa.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroCaixa.Click += new System.EventHandler(this.metroCaixa_Click);
            // 
            // metroOrdemServico
            // 
            this.metroOrdemServico.Image = global::HydraSistemas.Properties.Resources.ordem_de_serviço;
            this.metroOrdemServico.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroOrdemServico.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroOrdemServico.Name = "metroOrdemServico";
            this.metroOrdemServico.SymbolColor = System.Drawing.Color.Empty;
            this.metroOrdemServico.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            this.metroOrdemServico.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroOrdemServico.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroOrdemServico.TitleText = "Ordem de Serviço";
            this.metroOrdemServico.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroOrdemServico.Click += new System.EventHandler(this.metroOrdemServico_Click);
            // 
            // metroOrcamento
            // 
            this.metroOrcamento.Image = global::HydraSistemas.Properties.Resources.orçamento;
            this.metroOrcamento.ImageIndent = new System.Drawing.Point(0, -7);
            this.metroOrcamento.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroOrcamento.Name = "metroOrcamento";
            this.metroOrcamento.SymbolColor = System.Drawing.Color.Empty;
            this.metroOrcamento.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroOrcamento.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroOrcamento.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroOrcamento.TitleText = "Orçamento";
            this.metroOrcamento.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroOrcamento.Click += new System.EventHandler(this.metroOrcamento_Click);
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem1.Image")));
            this.metroTileItem1.ImageIndent = new System.Drawing.Point(0, -6);
            this.metroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            this.metroTileItem1.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleText = "Configuração";
            this.metroTileItem1.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // metroProdutoLista
            // 
            this.metroProdutoLista.Image = global::HydraSistemas.Properties.Resources.produto;
            this.metroProdutoLista.ImageIndent = new System.Drawing.Point(8, 16);
            this.metroProdutoLista.Name = "metroProdutoLista";
            this.metroProdutoLista.SymbolColor = System.Drawing.Color.Empty;
            this.metroProdutoLista.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            this.metroProdutoLista.TileSize = new System.Drawing.Size(120, 120);
            // 
            // 
            // 
            this.metroProdutoLista.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroProdutoLista.TitleText = "Produto";
            this.metroProdutoLista.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroProdutoLista.Click += new System.EventHandler(this.metroProdutoLista_Click);
            // 
            // tmDataHora
            // 
            this.tmDataHora.Enabled = true;
            this.tmDataHora.Tick += new System.EventHandler(this.tmDataHora_Tick);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(1242, -8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(24, 30);
            this.btnMinimizar.TabIndex = 7;
            this.btnMinimizar.Text = "-";
            this.btnMinimizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // menuVertical
            // 
            this.menuVertical.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuVertical.Controls.Add(this.btnMenu);
            this.menuVertical.Controls.Add(this.btnContas);
            this.menuVertical.Controls.Add(this.btnCompras);
            this.menuVertical.Controls.Add(this.btnVendas);
            this.menuVertical.Controls.Add(this.btnClientes);
            this.menuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuVertical.Location = new System.Drawing.Point(0, 24);
            this.menuVertical.Name = "menuVertical";
            this.menuVertical.Size = new System.Drawing.Size(176, 608);
            this.menuVertical.TabIndex = 10;
            // 
            // btnContas
            // 
            this.btnContas.FlatAppearance.BorderSize = 0;
            this.btnContas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnContas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContas.ForeColor = System.Drawing.Color.White;
            this.btnContas.Image = ((System.Drawing.Image)(resources.GetObject("btnContas.Image")));
            this.btnContas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContas.Location = new System.Drawing.Point(11, 275);
            this.btnContas.Name = "btnContas";
            this.btnContas.Size = new System.Drawing.Size(148, 39);
            this.btnContas.TabIndex = 1;
            this.btnContas.Text = "           Contas";
            this.btnContas.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            this.lblData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblData.Location = new System.Drawing.Point(903, 575);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(224, 20);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Lunes, 26 de septiembre 2018";
            // 
            // btnCompras
            // 
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(13, 206);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(153, 39);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "           Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHora.Location = new System.Drawing.Point(907, 515);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "21:49:45";
            // 
            // btnVendas
            // 
            this.btnVendas.FlatAppearance.BorderSize = 0;
            this.btnVendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendas.ForeColor = System.Drawing.Color.White;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVendas.Location = new System.Drawing.Point(10, 137);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(148, 39);
            this.btnVendas.TabIndex = 3;
            this.btnVendas.Text = "           Vendas";
            this.btnVendas.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(10, 68);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(148, 39);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "           Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // painelCentro
            // 
            this.painelCentro.BackColor = System.Drawing.SystemColors.Window;
            this.painelCentro.Controls.Add(this.metroTilePanel1);
            this.painelCentro.Controls.Add(this.lblHora);
            this.painelCentro.Controls.Add(this.lblData);
            this.painelCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelCentro.Location = new System.Drawing.Point(176, 24);
            this.painelCentro.Name = "painelCentro";
            this.painelCentro.Size = new System.Drawing.Size(1124, 608);
            this.painelCentro.TabIndex = 6;
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTilePanel1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.EnableDragDrop = true;
            this.metroTilePanel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(145, 22);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ReserveLeftSpace = false;
            this.metroTilePanel1.Size = new System.Drawing.Size(869, 468);
            this.metroTilePanel1.TabIndex = 0;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.ItemSpacing = 10;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroCompras,
            this.metroPDV,
            this.metroBuscarFornecedor,
            this.metroBuscarCliente,
            this.metroEntradaXML,
            this.metroCaixa,
            this.metroOrdemServico,
            this.metroOrcamento,
            this.metroTileItem1,
            this.metroProdutoLista});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.TitleText = "Menu Inicial";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1300, 632);
            this.Controls.Add(this.painelCentro);
            this.Controls.Add(this.menuVertical);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.menuVertical.ResumeLayout(false);
            this.painelCentro.ResumeLayout(false);
            this.painelCentro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem menuCadatroCategoria;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroMarca;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ToolStripMenuItem empresaToolStripMenuItem;
        private System.Windows.Forms.Timer tmDataHora;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem balançoToolStripMenuItem;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroCaixa;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroProdutoLista;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroBuscarCliente;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroOrdemServico;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroCompras;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroBuscarFornecedor;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroPDV;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroEntradaXML;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroOrcamento;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.ToolStripMenuItem produtosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosSemEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.Panel menuVertical;
        private System.Windows.Forms.Button btnContas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Panel painelCentro;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
    }
}

