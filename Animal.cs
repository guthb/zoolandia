using System;

namespace Zoolandia
{
    public class Animal
    //list generic animal properties
    {
       public string name {get; set;}
       public string legs {get; set;}
       public string height {get; set;}
       public string weight {get; set;}


       public string sleep()
       {
           return "Zzzzz";
           
       }

       public string eat (int numberOfFoodz)
       {
           if (numberOfFoodz <= 5 )
           {
               return "CHOMP";
           }
           else if (numberOfFoodz <= 10 )
           {
                return "normal chew";
           }
           else if (numberOfFoodz <= 20)
           {
               return "swallow already";
           }
           
          
       }

       private string scratch ()
       {
           return "itch itch itch";
       }

    }
}