namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComponentManager : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "COMPONENT.Manager",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ComponentName = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("COMPONENT.Manager");
        }
    }
}
