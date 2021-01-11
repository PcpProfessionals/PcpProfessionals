namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBaseEntityChanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("COMPONENT.BackPlane", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.BackPlane", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Brand", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Brand", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Manager", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Manager", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.EthernetCard", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.EthernetCard", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.FiberCard", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.FiberCard", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Harddisk", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Harddisk", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.HddCady", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.HddCady", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.HeatSink", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.HeatSink", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.KVM", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.KVM", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.LED", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.LED", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Memory", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Memory", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.MotherBroad", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.MotherBroad", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.PDU", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.PDU", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.PowerSupply", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.PowerSupply", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Processor", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Processor", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Rack", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Rack", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.RaidBattery", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.RaidBattery", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.RaidCard", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.RaidCard", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.RaidMemory", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.RaidMemory", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.RailKit", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.RailKit", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.RiserCard", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.RiserCard", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.SAASCable", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.SAASCable", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.SFP", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.SFP", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Storage", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Storage", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.Switch", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.Switch", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.TFTConsole", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.TFTConsole", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.ThinClient", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.ThinClient", "UnitPrice", c => c.Double(nullable: false));
            AddColumn("COMPONENT.ZeroClient", "Quantity", c => c.Int(nullable: false));
            AddColumn("COMPONENT.ZeroClient", "UnitPrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("COMPONENT.ZeroClient", "UnitPrice");
            DropColumn("COMPONENT.ZeroClient", "Quantity");
            DropColumn("COMPONENT.ThinClient", "UnitPrice");
            DropColumn("COMPONENT.ThinClient", "Quantity");
            DropColumn("COMPONENT.TFTConsole", "UnitPrice");
            DropColumn("COMPONENT.TFTConsole", "Quantity");
            DropColumn("COMPONENT.Switch", "UnitPrice");
            DropColumn("COMPONENT.Switch", "Quantity");
            DropColumn("COMPONENT.Storage", "UnitPrice");
            DropColumn("COMPONENT.Storage", "Quantity");
            DropColumn("COMPONENT.SFP", "UnitPrice");
            DropColumn("COMPONENT.SFP", "Quantity");
            DropColumn("COMPONENT.SAASCable", "UnitPrice");
            DropColumn("COMPONENT.SAASCable", "Quantity");
            DropColumn("COMPONENT.RiserCard", "UnitPrice");
            DropColumn("COMPONENT.RiserCard", "Quantity");
            DropColumn("COMPONENT.RailKit", "UnitPrice");
            DropColumn("COMPONENT.RailKit", "Quantity");
            DropColumn("COMPONENT.RaidMemory", "UnitPrice");
            DropColumn("COMPONENT.RaidMemory", "Quantity");
            DropColumn("COMPONENT.RaidCard", "UnitPrice");
            DropColumn("COMPONENT.RaidCard", "Quantity");
            DropColumn("COMPONENT.RaidBattery", "UnitPrice");
            DropColumn("COMPONENT.RaidBattery", "Quantity");
            DropColumn("COMPONENT.Rack", "UnitPrice");
            DropColumn("COMPONENT.Rack", "Quantity");
            DropColumn("COMPONENT.Processor", "UnitPrice");
            DropColumn("COMPONENT.Processor", "Quantity");
            DropColumn("COMPONENT.PowerSupply", "UnitPrice");
            DropColumn("COMPONENT.PowerSupply", "Quantity");
            DropColumn("COMPONENT.PDU", "UnitPrice");
            DropColumn("COMPONENT.PDU", "Quantity");
            DropColumn("COMPONENT.MotherBroad", "UnitPrice");
            DropColumn("COMPONENT.MotherBroad", "Quantity");
            DropColumn("COMPONENT.Memory", "UnitPrice");
            DropColumn("COMPONENT.Memory", "Quantity");
            DropColumn("COMPONENT.LED", "UnitPrice");
            DropColumn("COMPONENT.LED", "Quantity");
            DropColumn("COMPONENT.KVM", "UnitPrice");
            DropColumn("COMPONENT.KVM", "Quantity");
            DropColumn("COMPONENT.HeatSink", "UnitPrice");
            DropColumn("COMPONENT.HeatSink", "Quantity");
            DropColumn("COMPONENT.HddCady", "UnitPrice");
            DropColumn("COMPONENT.HddCady", "Quantity");
            DropColumn("COMPONENT.Harddisk", "UnitPrice");
            DropColumn("COMPONENT.Harddisk", "Quantity");
            DropColumn("COMPONENT.FiberCard", "UnitPrice");
            DropColumn("COMPONENT.FiberCard", "Quantity");
            DropColumn("COMPONENT.EthernetCard", "UnitPrice");
            DropColumn("COMPONENT.EthernetCard", "Quantity");
            DropColumn("COMPONENT.Manager", "UnitPrice");
            DropColumn("COMPONENT.Manager", "Quantity");
            DropColumn("COMPONENT.Brand", "UnitPrice");
            DropColumn("COMPONENT.Brand", "Quantity");
            DropColumn("COMPONENT.BackPlane", "UnitPrice");
            DropColumn("COMPONENT.BackPlane", "Quantity");
        }
    }
}
