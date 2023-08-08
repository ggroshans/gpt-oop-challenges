using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class PetShop
    {
        public List<Pet> Pets { get; set; } = new List<Pet>();

        public PetShop() { }

        public void AddPet(Pet pet)
        {
            Pets.Add(pet);
        }

        public void AdoptPet(Customer customer, Pet pet)
        {
            if (Pets.Contains(pet) && customer.Balance >= pet.Price)
            {
                Pets.Remove(pet);
                customer.Pets.Add(pet);
                customer.Balance -= pet.Price;
            }
            else
            {
                Console.WriteLine("Not enough balance to adopt this pet!");
            }
        }

        public string ListPets()
        {
            if (Pets.Count == 0) return "No pets available in the shop.";
            var SB = new StringBuilder();

            foreach (var pet in Pets)
            {
                SB.Append($"{pet.Name} ({pet.Type}) - ${pet.Price}\n");
            }
            return SB.ToString();

        }
    }
}
