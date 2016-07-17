using System;

namespace Zoolandia
{
    public class Animal
    //list generic animal properties
    {
       public string Name {get; set;}
       public string Legs {get; set;}
       public string Height {get; set;}
       public string Weight {get; set;}


       public string Sleep()
       {
           return "Zzzzz";
           
       }

       public virtual string Eat(int numberOfFoodz)
       {
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