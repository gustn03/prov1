using System;
using System.Collections.Generic;

namespace prov1
{
    public class Bok
    {
        public int price;

        public string name;

        private int rarity = 0;

        private List<string> category = new List<string>(){
            "Spellbook",
            "Spelling book",
            "Novella",
            "Nutella recipes"
        };
        private int categoryCount;

        private int actualValue = 0;

        private bool cursed = false;

        private Random generator = new Random();

        public Bok(){
            rarity = generator.Next(1,4);
            actualValue = generator.Next(30,80) * rarity;
            categoryCount = generator.Next(0,5);
        }
        public void PrintInfo(){
            Console.WriteLine($"Name: {name} Rarity: {rarity} Catergory: {category} Price: {price} ");
        }
        public int Evaluate(){
            return actualValue * generator.Next(5,16)/10;
        }

        public string GetCategory(){ 
            return category[categoryCount];
        }
        public string GetName(){ 
            return name;
        }
        public bool IsCursed(){ //bestämmer om boken är cursed eller inte och returnerar true eller false beroende på om den är det eller inte
            int curseChance = generator.Next(101);
            if (curseChance > 80){
                cursed = true;
            }
            else{
                cursed = false;
            }
            return cursed;
        }
    }
}