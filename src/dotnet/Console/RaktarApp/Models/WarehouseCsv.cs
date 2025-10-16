using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaktarApp.Models
{
    internal class WarehouseCsv
    {
        private readonly string _id;

        private readonly string _name;

        private readonly string _country;

        private readonly string _region;

        private readonly string _postCode;

        private readonly string _city;

        private readonly string _address;


        public WarehouseCsv(string id, string name, string country, string region, string postCode, string city, string address)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Id cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(country))
            {
                throw new ArgumentException("Country cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(region))
            {
                throw new ArgumentException("Region cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(postCode))
            {
                throw new ArgumentException("PostCode cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(city))
            {
                throw new ArgumentException("City cannot be empty");
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new ArgumentException("Address cannot be empty");
            }
            _id = id;
            _name = name;
            _address = address;
            _city = city;
            _postCode = postCode;
            _region = region;
            _country = country;
        }

    }
}
