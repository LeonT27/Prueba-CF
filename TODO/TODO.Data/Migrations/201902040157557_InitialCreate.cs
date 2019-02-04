namespace TODO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriasID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.CategoriasID);
            
            CreateTable(
                "dbo.List",
                c => new
                    {
                        ListID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        CategoriasID = c.Int(nullable: false),
                        Estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ListID)
                .ForeignKey("dbo.Categorias", t => t.CategoriasID, cascadeDelete: true)
                .Index(t => t.CategoriasID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.List", "CategoriasID", "dbo.Categorias");
            DropIndex("dbo.List", new[] { "CategoriasID" });
            DropTable("dbo.List");
            DropTable("dbo.Categorias");
        }
    }
}
