using DAL.DatabaseObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
    public interface IComponentService
    {
        List<string> GetAllComponents();
        List<TableDetailDto> GetControllsForComponent(string selectedComponent);
        long GetComponentTotalCount(string v);
        object AddComponentToInventory(string v, Dictionary<string, string> valueHolder);
    }
}
