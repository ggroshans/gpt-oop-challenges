# Challenge: Pet Shop System

## Overview
Create a basic Pet Shop system where customers can adopt pets. The system should consist of at least three classes: Pet, Customer, and PetShop.

## Details

### Pet Class: Represents a pet that the shop can sell.

Properties: Name, Type (e.g., Dog, Cat), Price
Method: GetDetails() - returns a string description of the pet.

### Customer Class: Represents a customer who can adopt a pet.

Properties: Name, Balance (money they have to spend)
Methods:
Adopt(Pet pet) - adopts a pet if the customer has enough balance.
GetDetails() - returns a string description of the customer, including adopted pets.

### PetShop Class: Represents the pet shop.

Properties: List of Pets available for adoption.
Methods:
AddPet(Pet pet) - adds a pet to the shop.
ListPets() - lists all the pets available in the shop.
AdoptPet(Customer customer, Pet pet) - handles the adoption of a pet by a customer.

## Requirements
The AdoptPet method in PetShop should check if the pet is available in the shop and if the customer has enough balance to adopt the pet.
If the adoption is successful, the pet should be removed from the pet shop and added to the customer's list of adopted pets, and the customer's balance should be reduced by the pet's price.


**This challenge provides practice with defining classes, properties, methods, and working with objects and their relationships. It's a basic simulation of a real-world scenario, helping to solidify OOP concepts.**
