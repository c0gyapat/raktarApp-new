using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaktarApp.Models;

namespace RaktarApp.Repos
{
    internal class WarehouseCsvRepo
    {

        List<WarehouseCsv> _warehouses = new List<WarehouseCsv>();


        public List<WarehouseCsv> Warehouses => _warehouses;

        public WarehouseCsvRepo() { }

        public WarehouseCsvRepo(List<WarehouseCsv> warehouses)
        {
            _warehouses = warehouses;
        }
    }
}
