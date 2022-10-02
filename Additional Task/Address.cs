using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__3__Data_types_
{
    class Address
    {
        int index;
        string country;
        string city;
        string street;
        int house;
        int apartment;
        //--------------------------------------

        public Address() { }
        //--------------------------------------

        public int Index 
        { 
            get { return index; } 
            set { this.index = value; } 
        }
        public string Country 
        { 
            get { return country; } 
            set { this.country = value; }
        }
        public string City 
        { 
            get { return city; }
            set { this.city = value; } 
        }
        public string Street 
        { 
            get { return street; } 
            set { this.street = value; } 
        }
        public int House 
        { 
            get { return house; } 
            set { this.house = value; }
        }
        public int Apartment 
        { 
            get { return apartment; } 
            set { this.apartment = value; }
        }

        public void ShowAddress()
        {
            Console.WriteLine($"Index:\t{Index}\n" +
               $"Country:\t{Country}\n" +
               $"City:\t{Country}\n" +
               $"Street:\t{Street}\n" +
               $"House:\t{House}\n" +
               $"Apartment:\t{Apartment}");
        }
    }
}
