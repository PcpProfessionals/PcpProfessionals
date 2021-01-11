using DAL.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Interfaces
{
    public interface IComponentRepository
    {
        List<string> GetAllComponents();
        List<TableDetailDto> GetComponentDetails(string selectedComponent);
        int GetComponentCount(string selectedComponent);
        Type GetEntityType(string componentName);
    }
}
