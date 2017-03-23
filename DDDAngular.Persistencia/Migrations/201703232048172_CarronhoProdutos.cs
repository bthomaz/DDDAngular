namespace DDDAngular.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarronhoProdutos : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Carrinho", "IdCarrinho", "dbo.Produto");
            DropIndex("dbo.Carrinho", new[] { "IdCarrinho" });
            DropPrimaryKey("dbo.Carrinho");
            CreateTable(
                "dbo.ProdutosCarrinho",
                c => new
                    {
                        IdProdutosCarrinho = c.Int(nullable: false, identity: true),
                        Carrinho_IdCarrinho = c.Int(nullable: false),
                        Produto_IdProduto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdProdutosCarrinho)
                .ForeignKey("dbo.Carrinho", t => t.Carrinho_IdCarrinho, cascadeDelete: true)
                .ForeignKey("dbo.Produto", t => t.Produto_IdProduto, cascadeDelete: true)
                .Index(t => t.Carrinho_IdCarrinho)
                .Index(t => t.Produto_IdProduto);
            
            AlterColumn("dbo.Carrinho", "IdCarrinho", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Carrinho", "IdCarrinho");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProdutosCarrinho", "Produto_IdProduto", "dbo.Produto");
            DropForeignKey("dbo.ProdutosCarrinho", "Carrinho_IdCarrinho", "dbo.Carrinho");
            DropIndex("dbo.ProdutosCarrinho", new[] { "Produto_IdProduto" });
            DropIndex("dbo.ProdutosCarrinho", new[] { "Carrinho_IdCarrinho" });
            DropPrimaryKey("dbo.Carrinho");
            AlterColumn("dbo.Carrinho", "IdCarrinho", c => c.Int(nullable: false));
            DropTable("dbo.ProdutosCarrinho");
            AddPrimaryKey("dbo.Carrinho", "IdCarrinho");
            CreateIndex("dbo.Carrinho", "IdCarrinho");
            AddForeignKey("dbo.Carrinho", "IdCarrinho", "dbo.Produto", "IdProduto");
        }
    }
}
