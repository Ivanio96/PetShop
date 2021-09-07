using System;
using System.Runtime.InteropServices;
using PetShop.Core.IServices;
using PetShop.Core.Models;

namespace PetShop.UI
{
    internal class Menu
    {
        private IPetService _service;

        public Menu(IPetService service)
        {
            _service = service;
        }

        public void Start()
        {
            ShowWelcomeGreeting();
            StartLoop();
        }

        private void StartLoop()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0)
            {
                if (choice == 1)
                {
                    CreatePet();
                }else if (choice == 2)
                {
                    ReadAll();
                }else if (choice == 5)
                {
                    SearchPet();
                }else if (choice == -1)
                {
                    PleaseTryAgain();
                }
            }
        }

        private void ReadAll()
        {
            Print("Here are all our Pets");
            var pets = _service.ReadAll();
            foreach (var pet in pets)
            {
                Print($"{pet.Id},{pet.Name},{pet.Type},{pet.BirthDate},{pet.SoldTime},{pet.Color},{pet.Price}");
            }
        }

        private void Clear()
        {
            Console.Clear();
        }

        private void SearchPet()
        {
            Print(StringConstants.WhatToSearchFor);
            int choice;
            while ((choice = GetPetSearchMenuSelection()) != 0)
            {
                if (choice == 1)
                {
                    Print("Type Pet Type to search for");
                    var petTypeToSearchFor = Console.ReadLine();
                    Print($"You searched for Pet Type {petTypeToSearchFor}");
                }else if (choice == -1)
                {
                    Print(StringConstants.PleaseSelectCorrectSearchOptions);
                }
            }
        }

        private int GetPetSearchMenuSelection()
        {
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
        
        private void CreatePet()
        {
            Print(StringConstants.CreatePetGreeting);
            Print(StringConstants.PetName);
            var petName = Console.ReadLine();
            Print(StringConstants.PetType);
            var petType = Console.ReadLine();
            Print(StringConstants.PetBirthDate);
            var petBirthDate = DateTime.Parse(Console.ReadLine());
            Print(StringConstants.PetSoldDate);
            var petSoldDate = DateTime.Parse(Console.ReadLine());
            Print(StringConstants.PetColor);
            var petColor = Console.ReadLine();
            Print(StringConstants.PetPrice);
            var petPrice = Double.Parse(Console.ReadLine());

            var pet = new Pet
            {
                Name = petName,
                //PetType.Name = petType,
                BirthDate = petBirthDate,
                SoldTime = petSoldDate,
                Color = petColor,
                Price = petPrice
            };
            pet = _service.Create(pet);
            Print($"Pet with Following Properties Created - Id: {pet.Id.Value} Name: {pet.Name} PetType: {pet.Type} " +
                  $"BirthDate: {pet.BirthDate} SoldDate: {pet.SoldTime} Color {pet.Color} Price {pet.Price}");
            PrintNewLine();
        }

        private void PleaseTryAgain()
        {
            Print(StringConstants.PleaseSelectCorrectItem);
        }

        private int GetMainMenuSelection()
        {
            ShowMainMenu();
            PrintNewLine();
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }

            return -1;
        }

        private void ShowMainMenu()
        {
            PrintNewLine();
            Print(StringConstants.PleaseSelectionMenu);
            Print(StringConstants.CreatePetMenuText);
            Print(StringConstants.ShowAllPetsMenuText);
            Print(StringConstants.ExitMainMenuText);
        }


        private void PrintNewLine()
        {
            Console.WriteLine("");
        }
        private void Print(string value)
        {
            Console.WriteLine(value);
        }

        private void ShowWelcomeGreeting()
        {
            Console.WriteLine(StringConstants.WelcomeGreeting);
        }
        
        
        
    }
}