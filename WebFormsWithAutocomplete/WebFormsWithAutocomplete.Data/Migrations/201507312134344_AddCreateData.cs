namespace WebFormsWithAutocomplete.SQLServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreateData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CreateData", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CreateData");
        }
    }
}
