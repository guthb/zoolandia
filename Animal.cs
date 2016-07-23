using System;

namespace Zoolandia
{//Base Class Animal
    public class Animal


    //list generic animal properties
    {
        
        public Animal(){
            
        }
        
        public Animal (string name)
        {//constructor
            this.Name = name;
        }
        //overload takes different inputs
        public Animal (int legs)
        {
            this.Legs = legs;
        }
        
        //another overload with int and string
        public Animal (int numberOfJumps, string southernphrase)
        {
            this.NumberOfJumps = numberOfJumps;
            this.SouthernPhrase = southernphrase;
        }

        //Genus
        // public string Electric {get;set;}
        // public string Grass {get;set;}
        // public string Normal {get;set;}
        // public string Poison {get;set;}
        // public string Water {get;set;}
        // public string Fairy{get;set;}



       public string Name {get; set;}
       public int Legs {get; set;}
       public double Height {get; set;}
       public double Weight {get; set;}

       public string SouthernPhrase {get; set;}
       public int NumberOfJumps{get; set;}



       public string Sleep()
       {
           return "Zzzzz";
           
       }

       public virtual string Eat(int numberOfFoodz)
       {//Virtual for excercise 2
           if (numberOfFoodz <=0)
           {
               return "your starving eat!!";
           }
           else
           {
               return "normal chewing";
           }
       }

       private string scratch ()
       {
           return "itch itch itch";
       }


        



    }
}