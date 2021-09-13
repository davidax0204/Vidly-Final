namespace Vidly_Final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rentalss : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }

        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
