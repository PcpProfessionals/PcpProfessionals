namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "COMPONENT.BackPlane",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.String(),
                        Size = c.Int(nullable: false),
                        NumberOfPorts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.Brand",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.EthernetCard",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.String(),
                        NumberOfPorts = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        SlotType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.FiberCard",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ModelNumber = c.String(),
                        TransferRate = c.String(),
                        NumberOfPorts = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.Harddisk",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PartNumber = c.String(),
                        Capacity = c.Int(nullable: false),
                        RPM = c.String(),
                        Size = c.Int(nullable: false),
                        Type = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.HddCady",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.Double(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.HeatSink",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ServerModel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.KVM",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.String(),
                        NumberOfPorts = c.Int(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.LED",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.Memory",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        Rank = c.String(),
                        Ddr = c.Int(nullable: false),
                        HeatSink = c.Boolean(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.MotherBroad",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.PDU",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        NumberOfPorts = c.Int(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.PowerSupply",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ModelNumber = c.String(),
                        Watt = c.String(),
                        NumberOfPorts = c.Int(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.Processor",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ModelNumber = c.String(),
                        CacheSize = c.Int(nullable: false),
                        NumberOfPorts = c.Int(nullable: false),
                        Type = c.String(),
                        Speed = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.Rack",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.String(),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                        Depth = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.RaidBattery",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.RaidCard",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Category = c.String(),
                        Placement = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.RaidMemory",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.RailKit",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.Int(nullable: false),
                        Model = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.RiserCard",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Category = c.String(),
                        Placement = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.SAASCable",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.Double(nullable: false),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.SFP",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Model = c.String(),
                        Speed = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.Storage",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Controller = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.Switch",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Brand = c.String(),
                        NumberOfPorts = c.Int(nullable: false),
                        ModelNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "COMPONENT.TFTConsole",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Size = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.ThinClient",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Model = c.String(),
                        Ram = c.String(),
                        Processor = c.String(),
                        HardDisk = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
            CreateTable(
                "COMPONENT.ZeroClient",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Model = c.String(),
                        BrandId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("COMPONENT.Brand", t => t.BrandId, cascadeDelete: true)
                .Index(t => t.BrandId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("COMPONENT.ZeroClient", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.ThinClient", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.TFTConsole", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.Storage", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.SAASCable", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.RailKit", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.RaidMemory", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.RaidCard", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.PowerSupply", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.PDU", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.Memory", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.LED", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.KVM", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.HddCady", "BrandId", "COMPONENT.Brand");
            DropForeignKey("COMPONENT.Harddisk", "BrandId", "COMPONENT.Brand");
            DropIndex("COMPONENT.ZeroClient", new[] { "BrandId" });
            DropIndex("COMPONENT.ThinClient", new[] { "BrandId" });
            DropIndex("COMPONENT.TFTConsole", new[] { "BrandId" });
            DropIndex("COMPONENT.Storage", new[] { "BrandId" });
            DropIndex("COMPONENT.SAASCable", new[] { "BrandId" });
            DropIndex("COMPONENT.RailKit", new[] { "BrandId" });
            DropIndex("COMPONENT.RaidMemory", new[] { "BrandId" });
            DropIndex("COMPONENT.RaidCard", new[] { "BrandId" });
            DropIndex("COMPONENT.PowerSupply", new[] { "BrandId" });
            DropIndex("COMPONENT.PDU", new[] { "BrandId" });
            DropIndex("COMPONENT.Memory", new[] { "BrandId" });
            DropIndex("COMPONENT.LED", new[] { "BrandId" });
            DropIndex("COMPONENT.KVM", new[] { "BrandId" });
            DropIndex("COMPONENT.HddCady", new[] { "BrandId" });
            DropIndex("COMPONENT.Harddisk", new[] { "BrandId" });
            DropTable("COMPONENT.ZeroClient");
            DropTable("COMPONENT.ThinClient");
            DropTable("COMPONENT.TFTConsole");
            DropTable("COMPONENT.Switch");
            DropTable("COMPONENT.Storage");
            DropTable("COMPONENT.SFP");
            DropTable("COMPONENT.SAASCable");
            DropTable("COMPONENT.RiserCard");
            DropTable("COMPONENT.RailKit");
            DropTable("COMPONENT.RaidMemory");
            DropTable("COMPONENT.RaidCard");
            DropTable("COMPONENT.RaidBattery");
            DropTable("COMPONENT.Rack");
            DropTable("COMPONENT.Processor");
            DropTable("COMPONENT.PowerSupply");
            DropTable("COMPONENT.PDU");
            DropTable("COMPONENT.MotherBroad");
            DropTable("COMPONENT.Memory");
            DropTable("COMPONENT.LED");
            DropTable("COMPONENT.KVM");
            DropTable("COMPONENT.HeatSink");
            DropTable("COMPONENT.HddCady");
            DropTable("COMPONENT.Harddisk");
            DropTable("COMPONENT.FiberCard");
            DropTable("COMPONENT.EthernetCard");
            DropTable("COMPONENT.Brand");
            DropTable("COMPONENT.BackPlane");
        }
    }
}
