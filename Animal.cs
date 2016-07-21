using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Animal


    //list generic animal properties
    {
        public Animal (string name)
        {//constructor
            this.Name = name;
        }

        public Animal (int legs)
        {
            this.Legs = legs;
        }
        


       public string Name {get; set;}
       public int Legs {get; set;}
       public double Height {get; set;}
       public double Weight {get; set;}





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