using DAL.Context;
using DAL.DatabaseObjects;
using DAL.Entities.Components;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ComponentRepository : BaseRepository, IComponentRepository
    {
        private PcpProfessionalContext _context;

        public ComponentRepository()
        {
            _context = new PcpProfessionalContext();
        }

        public List<string> GetAllComponents()
        {
            var componentList = _context.Database.SqlQuery<string>("select name as table_name from sys.tables where schema_name(schema_id) = 'COMPONENT' order by name").ToList();

            return componentList;
        }

        public int GetComponentCount(string selectedComponent)
        {
            var componentCount = _context.Database.SqlQuery<int>($"SELECT COUNT(*) FROM COMPONENT.{selectedComponent}").ToList();

            return Convert.ToInt32(componentCount.First());
        }

        public List<TableDetailDto> GetComponentDetails(string selectedComponent)
        {
            return _context.Database.SqlQuery<TableDetailDto>($"select column_name, data_type from INFORMATION_SCHEMA.COLUMNS where Table_Name =  '{selectedComponent}'").ToList();
        }

        public Type GetEntityType(string componentName)
        {
            var test = _context.GetType().GetProperties().Where(x=>x.Name.Contains(componentName)).FirstOrDefault()
                .GetValue(_context);


            var test2 = test.GetType().GetProperties();


            var test3 = test2.First().GetValue(test);
            var test4 = test2.Last().GetValue(test);
            return typeof(BrandEntity);
        }

        //TODO[ATEEB] REFACTOR THE SWITCH !!

        //public EntityObject GetEntityType(string componentName)
        //{
        //    switch (componentName)
        //    {
        //        case "BackPlane":
        //            return new BackPlaneEntity();

        //        case "Brand":
        //            return typeof(BrandEntity);

        //        case "ComponentManager":
        //            return typeof(ComponentManagerEntity);

        //        case "EthernetCard":
        //            return typeof(EthernetCardEntity);

        //        case "FiberCard":
        //            return typeof(FiberCardEntity);

        //        case "Harddisk":
        //            return typeof(HarddiskEntity);

        //        case "HDDCady":
        //            return typeof(HDDCadyEntity);

        //        case "HeatSink":
        //            return typeof(HeatSinkEntity);

        //        case "KVM":
        //            return typeof(KVMEntity);

        //        case "LED":
        //            return typeof(LEDEntity);

        //        case "Memory":
        //            return typeof(MemoryEntity);

        //        case "MotherBoard":
        //            return typeof(MotherBoardEntity);

        //        case "PDU":
        //            return typeof(PDUEntity);

        //        case "PowerSupply":
        //            return typeof(PowerSupplyEntity);

        //        case "Processor":
        //            return typeof(ProcessorEntity);

        //        case "Rack":
        //            return typeof(RackEntity);

        //        case "RaidBattery":
        //            return typeof(RaidBatteryEntity);

        //        case "RaidCard":
        //            return typeof(RaidCardEntity);

        //        case "RaidMemory":
        //            return typeof(RaidMemoryEntity);

        //        case "RailKit":
        //            return typeof(RailKitEntitiy);

        //        case "RiserCard":
        //            return typeof(RiserCardEntity);

        //        case "SAASCable":
        //            return typeof(SAASCableEntity);

        //        case "SFP":
        //            return typeof(SFPEntity);

        //        case "Storage":
        //            return typeof(StorageEntity);

        //        case "Switch":
        //            return typeof(SwitchEntity);

        //        case "TFTConsole":
        //            return typeof(TFTConsoleEntity);

        //        case "ThinClient":
        //            return typeof(ThinClientEntity);

        //        case "ZeroClient":
        //            return typeof(ZeroClientEntity);

        //        default:
        //            throw new Exception("Component Not Found...");
        //    }
        //}
    }
}
