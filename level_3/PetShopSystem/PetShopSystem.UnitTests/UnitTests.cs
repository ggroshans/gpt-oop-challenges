namespace PetShopSystem.UnitTests
{
    using Challenges;
    using Xunit;

    public class PetShopTests
    {
        [Fact]
        public void TestAddingPetsToShop()
        {
            PetShop shop = new PetShop();
            Pet dog = new Pet { Name = "Buddy", Type = "Dog", Price = 200 };
            Pet cat = new Pet { Name = "Whiskers", Type = "Cat", Price = 100 };
            shop.AddPet(dog);
            shop.AddPet(cat);

            string petsList = shop.ListPets();
            Assert.Equal("Buddy (Dog) - $200\nWhiskers (Cat) - $100\n", petsList);
        }

        [Fact]
        public void TestCustomerAdoptsPet()
        {
            PetShop shop = new PetShop();
            Pet dog = new Pet { Name = "Buddy", Type = "Dog", Price = 200 };
            shop.AddPet(dog);
            Customer john = new Customer { Name = "John", Balance = 300 };
            shop.AdoptPet(john, dog);

            string details = john.GetDetails();
            Assert.Equal("Customer: John\nBalance: $100\nAdopted Pets:\nBuddy (Dog) - $200\n", details);
        }

        [Fact]
        public void TestRemainingPetsInShopAfterAdoption()
        {
            PetShop shop = new PetShop();
            Pet dog = new Pet { Name = "Buddy", Type = "Dog", Price = 200 };
            Pet cat = new Pet { Name = "Whiskers", Type = "Cat", Price = 100 };
            shop.AddPet(dog);
            shop.AddPet(cat);
            Customer john = new Customer { Name = "John", Balance = 300 };
            shop.AdoptPet(john, dog);

            string petsList = shop.ListPets();
            Assert.Equal("Whiskers (Cat) - $100\n", petsList);
        }

        [Fact]
        public void TestCustomerAdoptsAnotherPet()
        {
            PetShop shop = new PetShop();
            Pet dog = new Pet { Name = "Buddy", Type = "Dog", Price = 200 };
            Pet cat = new Pet { Name = "Whiskers", Type = "Cat", Price = 100 };
            shop.AddPet(dog);
            shop.AddPet(cat);
            Customer john = new Customer { Name = "John", Balance = 300 };
            shop.AdoptPet(john, dog);
            shop.AdoptPet(john, cat);

            string details = john.GetDetails();
            Assert.Equal("Customer: John\nBalance: $0\nAdopted Pets:\nBuddy (Dog) - $200\nWhiskers (Cat) - $100\n", details);
        }

        // Additional test method for the scenario when the customer tries to adopt without enough balance
        // This would depend on how you've chosen to handle this case in your code
    }
}