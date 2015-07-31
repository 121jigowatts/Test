namespace WebFormsWithAutocomplete.SQLServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ID", c => c.Int(nullable: false, identity: true));            
            AddColumn("dbo.Products", "Code", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.Products", "ID");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Code");
        }
    }
}
