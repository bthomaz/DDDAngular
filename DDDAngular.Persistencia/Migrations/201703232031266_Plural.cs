namespace DDDAngular.Persistencia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Plural : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Carrinhoes", newName: "Carrinho");
            RenameTable(name: "dbo.Consumidors", newName: "Consumidor");
            RenameTable(name: "dbo.Produtoes", newName: "Produto");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Produto", newName: "Produtoes");
            RenameTable(name: "dbo.Consumidor", newName: "Consumidors");
            RenameTable(name: "dbo.Carrinho", newName: "Carrinhoes");
        }
    }
}
