namespace WebFormsWithAutocomplete.SQLServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeProductKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AddColumn("dbo.Products", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Products", "Code", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Products", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Code", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Products", "ID");
            AddPrimaryKey("dbo.Products", "Code");
        }
    }
}
