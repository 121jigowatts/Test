namespace WebFormsWithAutocomplete.SQLServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteCode : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            DropColumn("dbo.Products", "Code");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Code", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
