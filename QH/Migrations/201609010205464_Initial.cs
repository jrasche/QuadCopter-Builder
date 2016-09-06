namespace QH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Batteries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Capacity = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Length = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Config = c.Int(nullable: false),
                        MaxDischarge = c.Double(nullable: false),
                        MaxCharge = c.Double(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Batteries");
        }
    }
}
