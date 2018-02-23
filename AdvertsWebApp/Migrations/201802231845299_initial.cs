namespace AdvertsWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adverts",
                c => new
                    {
                        AdvertId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Text = c.String(),
                        Price = c.Double(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AdvertId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adverts");
        }
    }
}
