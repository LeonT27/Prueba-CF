namespace TODO.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Limites : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categorias", "Nombre", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.List", "Nombre", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.List", "Descripcion", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.List", "Descripcion", c => c.String());
            AlterColumn("dbo.List", "Nombre", c => c.String());
            AlterColumn("dbo.Categorias", "Nombre", c => c.String());
        }
    }
}
