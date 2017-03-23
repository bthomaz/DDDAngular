namespace DDDAngular.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carrinhoes",
                c => new
                    {
                        IdCarrinho = c.Int(nullable: false),
                        Consumidor_IdConsumidor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdCarrinho)
                .ForeignKey("dbo.Consumidors", t => t.Consumidor_IdConsumidor, cascadeDelete: true)
                .ForeignKey("dbo.Produtoes", t => t.IdCarrinho)
                .Index(t => t.IdCarrinho)
                .Index(t => t.Consumidor_IdConsumidor);
            
            CreateTable(
                "dbo.Consumidors",
                c => new
                    {
                        IdConsumidor = c.Int(nullable: false, identity: true),
                        NomeConsumidor = c.String(nullable: false, maxLength: 250, unicode: false),
                        IdadeConsumidor = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdConsumidor);
            
            CreateTable(
                "dbo.Produtoes",
                c => new
                    {
                        IdProduto = c.Int(nullable: false, identity: true),
                        DescricaoProduto = c.String(nullable: false, maxLength: 200, unicode: false),
                        PrecoProduto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                        DataCriacao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdProduto);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Carrinhoes", "IdCarrinho", "dbo.Produtoes");
            DropForeignKey("dbo.Carrinhoes", "Consumidor_IdConsumidor", "dbo.Consumidors");
            DropIndex("dbo.Carrinhoes", new[] { "Consumidor_IdConsumidor" });
            DropIndex("dbo.Carrinhoes", new[] { "IdCarrinho" });
            DropTable("dbo.Produtoes");
            DropTable("dbo.Consumidors");
            DropTable("dbo.Carrinhoes");
        }
    }
}
