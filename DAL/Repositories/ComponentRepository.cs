using DAL.Context;
using DAL.DatabaseObjects;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
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

        public List<TableDetailDto> GetComponentDetails(string selectedComponent)
        {
            return _context.Database.SqlQuery<TableDetailDto>($"select column_name, data_type from INFORMATION_SCHEMA.COLUMNS where Table_Name =  '{selectedComponent}'").ToList();
        }
    }
}
