using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Pet
    {
        public string Name { get; set; } = "Rescue";
        public string? Type { get; set; }
        public double Price { get; set; }

        public Pet() { }
        public Pet(string name, string type, double price)
        {
            this.Name = name;
            this.Type = type;
            this.Price = price;
        }

        public string GetDetails()
        {
            return $"Name: {Name}, Type: {Type}, Price: {Price} ";
        }
    }
}
