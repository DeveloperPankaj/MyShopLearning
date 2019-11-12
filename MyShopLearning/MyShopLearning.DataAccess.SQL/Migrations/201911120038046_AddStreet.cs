namespace MyShopLearning.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStreet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Street", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Street");
        }
    }
}
