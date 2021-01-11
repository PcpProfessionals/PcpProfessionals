using BL.Services.Interfaces;
using DAL.DatabaseObjects;
using DAL.Repositories;
using DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ComponentService : IComponentService
    {
        private IComponentRepository _componentRepo;

        public ComponentService() 
        {
            _componentRepo = new ComponentRepository();
        }

        public object AddComponentToInventory(string componentName, Dictionary<string, string> valueHolder)
        {
            var typeOfEntity = FetchEntityType(componentName);

            
            var mappedEntity = MapEntityValues(typeOfEntity, valueHolder);

            return new object();

        }

        private object MapEntityValues(Type entityType, Dictionary<string, string> valueHolder)
        {

            return new object();

        }

        private Type FetchEntityType(string componentName)
        {
            return _componentRepo.GetEntityType(componentName);
        }

        public List<string> GetAllComponents()
        {
            var componentList = _componentRepo.GetAllComponents();

            return componentList; 
        }

        public long GetComponentTotalCount(string selectedComponent)
        {
            var componentCount = _componentRepo.GetComponentCount(selectedComponent);

            return componentCount;
        }

        public List<TableDetailDto> GetControllsForComponent(string selectedComponent)
        {
            var entityDetail = _componentRepo.GetComponentDetails(selectedComponent);

            return entityDetail;
        }
    }
}
