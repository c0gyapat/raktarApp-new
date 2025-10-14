using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Models;

namespace RaktarApp.Repos
{
    internal class WarehouseRepo
    {

        List<Warehouse> _warehouses = new List<Warehouse>();


        public List<Warehouse> Warehouses => _warehouses;

        public WarehouseRepo() { }

        public WarehouseRepo(List<Warehouse> warehouses)
        {
            _warehouses = warehouses;
        }

        public List<Warehouse> GetAllWarehouses()
        {
            return _warehouses;
        }

        public void RemoveWarehouse(int id)
        {
            Warehouse? warehouse = _warehouses.FirstOrDefault(w => w.Id == id);
            if (warehouse != null)
            {
                if(warehouse.CanDelete())
                {
                    _warehouses.Remove(warehouse);
                }
                else
                {
                    throw new InvalidOperationException("Warehouse cannot be deleted because it contains items");
                }
            }
            else
            {
                throw new ArgumentException("Warehouse not found");
            }
        }
    }
}
