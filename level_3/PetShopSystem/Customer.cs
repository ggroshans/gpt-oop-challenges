using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class Customer
    {
        public string Name { get; set; } = "John Doe";
        public double Balance { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Customer() { }
        public Customer(string name, double balance)
        {
            this.Name = name;
            this.Balance = balance;
        }

        public bool Adopt(Pet pet)
        {
            if (pet.Price < Balance)
            {
                Pets.Add(pet);
                this.Balance -= pet.Price;
                return true;
            }
            return false;
        }

        public string GetDetails()
        {
            var Sb = new StringBuilder();
            Sb.AppendLine($"Name: {Name}");
            Sb.AppendLine($"Balance: {Balance}");
            Sb.AppendLine("Adopted Pets: ");

            foreach (var pet in Pets)
            {
                Sb.AppendLine($"{pet.Name} ({pet.Type}) - {pet.Price} ");
            }
            return Sb.ToString();
        }

    }
}
