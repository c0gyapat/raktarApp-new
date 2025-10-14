using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Models
{
    internal class WarehouseItem
    {
        private int _nextId = 1;
        private readonly int _id;
        public string _name;
        public int _quantity;

        public WarehouseItem() { }

        public WarehouseItem(string name, int quantity)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            if(quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative");
            }

            _id = _nextId++;
            _name = name;
            _quantity = quantity;
        }


        public int Id  => _id;
        public string Name {
            get => _name;
            set => _name = value;
        }

        public int Quantity {
            get => _quantity;
            set => _quantity = value;
        }


        public int SetQuantity(int quantity)
        {

            if(quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative");
            }

            Quantity = quantity;
            return _quantity;
        }

        public string SetName( string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            Name = name;
            return _name;
        }

        public override string ToString()
        {
            return $"ID: {_id}, Name: {_name}, Quantity: {_quantity}";
        }

    }
}
