using System.Data.Entity;
using DAL.Entities.Auth;
using DAL.Entities.Components;

namespace DAL.Context
{
    public class PcpProfessionalContext : DbContext
    {

        public PcpProfessionalContext() : base("name=PcpConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<BackPlaneEntity> BackPlanes { get; set; }
        public virtual DbSet<BrandEntity> Brands { get; set; }
        public virtual DbSet<EthernetCardEntity> EthernetCards { get; set; }
        public virtual DbSet<FiberCardEntity> FiberCards { get; set; }
        public virtual DbSet<HarddiskEntity> HardDisks { get; set; }
        public virtual DbSet<HDDCadyEntity> HDDCaddys { get; set; }
        public virtual DbSet<HeatSinkEntity> HeatSinks { get; set; }
        public virtual DbSet<KVMEntity> KVMs { get; set; }
        public virtual DbSet<LEDEntity> LEDs { get; set; }
        public virtual DbSet<MemoryEntity> Memories { get; set; }
        public virtual DbSet<MotherBoardEntity> MotherBoards { get; set; }
        public virtual DbSet<PDUEntity> PDUs { get; set; }
        public virtual DbSet<PowerSupplyEntity> PowerSupplies { get; set; }
        public virtual DbSet<ProcessorEntity> Processors { get; set; }
        public virtual DbSet<RaidBatteryEntity> RaidBatteries { get; set; }
        public virtual DbSet<RaidCardEntity> RaidCards { get; set; }
        public virtual DbSet<RaidMemoryEntity> RaidMemories { get; set; }
        public virtual DbSet<RailKitEntitiy> RailKits { get; set; }
        public virtual DbSet<RiserCardEntity> RiserCards { get; set; }
        public virtual DbSet<SAASCableEntity> SAASCables { get; set; }
        public virtual DbSet<SFPEntity> SFPs { get; set; }
        public virtual DbSet<StorageEntity> Storages { get; set; }
        public virtual DbSet<SwitchEntity> Switches { get; set; }
        public virtual DbSet<TFTConsoleEntity> TFTConsoles { get; set; }
        public virtual DbSet<ThinClientEntity> ThinClients { get; set; }
        public virtual DbSet<ZeroClientEntity> ZeroClients { get; set; }
        public virtual DbSet<RackEntity> Racks { get; set; }
        public virtual DbSet<UserEntity> Users { get; set; }
        public virtual DbSet<ComponentManagerEntity> ComponentManager { get; set; }
    }
}
