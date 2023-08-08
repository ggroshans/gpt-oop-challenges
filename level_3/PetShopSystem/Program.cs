namespace Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // **TEST 1: Adding Pets to the Shop

            PetShop shop = new PetShop();
            Pet dog = new Pet { Name = "Buddy", Type = "Dog", Price = 200 };
            Pet cat = new Pet { Name = "Whiskers", Type = "Cat", Price = 100 };
            shop.AddPet(dog);
            shop.AddPet(cat);

            Console.WriteLine(shop.ListPets());

            // Expected Output:
            // Buddy (Dog) - $200
            // Whiskers (Cat) - $100


            // **TEST 2: Customer Adopts a Pet

            Customer john = new Customer { Name = "John", Balance = 300 };
            shop.AdoptPet(john, dog);

            Console.WriteLine(john.GetDetails());

            // Expected Output:
            // Customer: John
            // Balance: $100
            // Adopted Pets:
            // Buddy (Dog) - $200


            // **TEST 3: Customer Tries to Adopt a Pet Without Enough Balance

            Customer jane = new Customer { Name = "Jane", Balance = 50 };
            shop.AdoptPet(jane, cat);

            // Expected Output:
            // Not enough balance to adopt this pet!


            // **TEST 4: Check Remaining Pets in the Shop After Adoption

            Console.WriteLine(shop.ListPets());

            // Expected Output:
            // Whiskers (Cat) - $100


            // **TEST 5: Customer Adopts Another Pet

            shop.AdoptPet(john, cat);

            Console.WriteLine(john.GetDetails());

            // Expected Output:
            // Customer: John
            // Balance: $0
            // Adopted Pets:
            // Buddy (Dog) - $200
            // Whiskers (Cat) - $100

        }
    }
}