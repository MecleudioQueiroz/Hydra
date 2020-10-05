namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizaPostgre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        ValorVarejo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorAtacado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CodigoBarras = c.String(),
                        CodigoReferencia = c.String(),
                        Descricao = c.String(),
                        QtdEstoque = c.Int(nullable: false),
                        ImagemUrl = c.String(),
                        Ativo = c.String(),
                        CodigoNcm = c.String(),
                        FornecedorId = c.Int(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Fornecedores", t => t.FornecedorId, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .Index(t => t.FornecedorId)
                .Index(t => t.CategoriaId)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        FornecedorId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        UF = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        ImagemUrl = c.String(),
                        DtCadastro = c.DateTime(nullable: false),
                        CNPJ = c.String(),
                        Cep = c.String(),
                        InscricaoEstadual = c.String(),
                        Suframa = c.String(),
                        NomeFantasia = c.String(),
                        Empresa_EmpresaId = c.Int(),
                    })
                .PrimaryKey(t => t.FornecedorId)
                .ForeignKey("dbo.Empresas", t => t.Empresa_EmpresaId)
                .Index(t => t.Empresa_EmpresaId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.MarcaId);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        EmpresaId = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(),
                        NomeFantasia = c.String(),
                        CNPJ = c.String(),
                        IncricaoEstadual = c.String(),
                        InscricaoMunicipal = c.String(),
                        Endereco = c.String(),
                        Bairro = c.String(),
                        Cep = c.String(),
                        UF = c.String(),
                        Telefone = c.String(),
                        Numero = c.String(),
                        Cidade = c.String(),
                        RumoDeAtividade = c.String(),
                        CnaeFiscal = c.String(),
                        NumeroJucer = c.String(),
                    })
                .PrimaryKey(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Endereco = c.String(),
                        Numero = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        UF = c.String(),
                        Email = c.String(),
                        Telefone = c.String(),
                        ImagemUrl = c.String(),
                        DtCadastro = c.DateTime(nullable: false),
                        Comissao = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Desconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CPF = c.Int(nullable: false),
                        EmpresaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FuncionarioId)
                .ForeignKey("dbo.Empresas", t => t.EmpresaId, cascadeDelete: true)
                .Index(t => t.EmpresaId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Senha = c.String(),
                        RepitaSenha = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.Fornecedores", "Empresa_EmpresaId", "dbo.Empresas");
            DropForeignKey("dbo.Produtos", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Produtos", "FornecedorId", "dbo.Fornecedores");
            DropForeignKey("dbo.Produtos", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Funcionarios", new[] { "EmpresaId" });
            DropIndex("dbo.Fornecedores", new[] { "Empresa_EmpresaId" });
            DropIndex("dbo.Produtos", new[] { "MarcaId" });
            DropIndex("dbo.Produtos", new[] { "CategoriaId" });
            DropIndex("dbo.Produtos", new[] { "FornecedorId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Funcionarios");
            DropTable("dbo.Empresas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Produtos");
            DropTable("dbo.Categorias");
        }
    }
}
