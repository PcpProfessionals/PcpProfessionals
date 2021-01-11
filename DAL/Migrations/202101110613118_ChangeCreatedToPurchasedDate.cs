namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCreatedToPurchasedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("COMPONENT.BackPlane", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Brand", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Manager", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.EthernetCard", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.FiberCard", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Harddisk", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.HddCady", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.HeatSink", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.KVM", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.LED", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Memory", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.MotherBroad", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.PDU", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.PowerSupply", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Processor", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Rack", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RaidBattery", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RaidCard", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RaidMemory", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RailKit", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RiserCard", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.SAASCable", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.SFP", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Storage", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Switch", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.TFTConsole", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.ThinClient", "PurchaseDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.ZeroClient", "PurchaseDate", c => c.DateTime(nullable: false));
            DropColumn("COMPONENT.BackPlane", "CreatedDate");
            DropColumn("COMPONENT.Brand", "CreatedDate");
            DropColumn("COMPONENT.Manager", "CreatedDate");
            DropColumn("COMPONENT.EthernetCard", "CreatedDate");
            DropColumn("COMPONENT.FiberCard", "CreatedDate");
            DropColumn("COMPONENT.Harddisk", "CreatedDate");
            DropColumn("COMPONENT.HddCady", "CreatedDate");
            DropColumn("COMPONENT.HeatSink", "CreatedDate");
            DropColumn("COMPONENT.KVM", "CreatedDate");
            DropColumn("COMPONENT.LED", "CreatedDate");
            DropColumn("COMPONENT.Memory", "CreatedDate");
            DropColumn("COMPONENT.MotherBroad", "CreatedDate");
            DropColumn("COMPONENT.PDU", "CreatedDate");
            DropColumn("COMPONENT.PowerSupply", "CreatedDate");
            DropColumn("COMPONENT.Processor", "CreatedDate");
            DropColumn("COMPONENT.Rack", "CreatedDate");
            DropColumn("COMPONENT.RaidBattery", "CreatedDate");
            DropColumn("COMPONENT.RaidCard", "CreatedDate");
            DropColumn("COMPONENT.RaidMemory", "CreatedDate");
            DropColumn("COMPONENT.RailKit", "CreatedDate");
            DropColumn("COMPONENT.RiserCard", "CreatedDate");
            DropColumn("COMPONENT.SAASCable", "CreatedDate");
            DropColumn("COMPONENT.SFP", "CreatedDate");
            DropColumn("COMPONENT.Storage", "CreatedDate");
            DropColumn("COMPONENT.Switch", "CreatedDate");
            DropColumn("COMPONENT.TFTConsole", "CreatedDate");
            DropColumn("COMPONENT.ThinClient", "CreatedDate");
            DropColumn("COMPONENT.ZeroClient", "CreatedDate");
        }
        
        public override void Down()
        {
            AddColumn("COMPONENT.ZeroClient", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.ThinClient", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.TFTConsole", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Switch", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Storage", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.SFP", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.SAASCable", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RiserCard", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RailKit", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RaidMemory", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RaidCard", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.RaidBattery", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Rack", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Processor", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.PowerSupply", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.PDU", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.MotherBroad", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Memory", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.LED", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.KVM", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.HeatSink", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.HddCady", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Harddisk", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.FiberCard", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.EthernetCard", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Manager", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.Brand", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("COMPONENT.BackPlane", "CreatedDate", c => c.DateTime(nullable: false));
            DropColumn("COMPONENT.ZeroClient", "PurchaseDate");
            DropColumn("COMPONENT.ThinClient", "PurchaseDate");
            DropColumn("COMPONENT.TFTConsole", "PurchaseDate");
            DropColumn("COMPONENT.Switch", "PurchaseDate");
            DropColumn("COMPONENT.Storage", "PurchaseDate");
            DropColumn("COMPONENT.SFP", "PurchaseDate");
            DropColumn("COMPONENT.SAASCable", "PurchaseDate");
            DropColumn("COMPONENT.RiserCard", "PurchaseDate");
            DropColumn("COMPONENT.RailKit", "PurchaseDate");
            DropColumn("COMPONENT.RaidMemory", "PurchaseDate");
            DropColumn("COMPONENT.RaidCard", "PurchaseDate");
            DropColumn("COMPONENT.RaidBattery", "PurchaseDate");
            DropColumn("COMPONENT.Rack", "PurchaseDate");
            DropColumn("COMPONENT.Processor", "PurchaseDate");
            DropColumn("COMPONENT.PowerSupply", "PurchaseDate");
            DropColumn("COMPONENT.PDU", "PurchaseDate");
            DropColumn("COMPONENT.MotherBroad", "PurchaseDate");
            DropColumn("COMPONENT.Memory", "PurchaseDate");
            DropColumn("COMPONENT.LED", "PurchaseDate");
            DropColumn("COMPONENT.KVM", "PurchaseDate");
            DropColumn("COMPONENT.HeatSink", "PurchaseDate");
            DropColumn("COMPONENT.HddCady", "PurchaseDate");
            DropColumn("COMPONENT.Harddisk", "PurchaseDate");
            DropColumn("COMPONENT.FiberCard", "PurchaseDate");
            DropColumn("COMPONENT.EthernetCard", "PurchaseDate");
            DropColumn("COMPONENT.Manager", "PurchaseDate");
            DropColumn("COMPONENT.Brand", "PurchaseDate");
            DropColumn("COMPONENT.BackPlane", "PurchaseDate");
        }
    }
}
