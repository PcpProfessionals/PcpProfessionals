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

        public List<string> GetAllComponents()
        {
            var componentList = _componentRepo.GetAllComponents();

            return componentList; 
        }

        public List<TableDetailDto> GetControllsForComponent(string selectedComponent)
        {
            var entityDetail = _componentRepo.GetComponentDetails(selectedComponent);

            return entityDetail;
        }
    }
}
