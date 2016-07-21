//height 1'04"
//penguin
//weight 11.5 lbs

using System;

namespace Zoolandia.Species
{
    public class Piplup : Animal  
    {
      public Piplup(string name) :base(name)
      {//constuctor
          this.Legs = 2;
          this.Height = 1.04;
          this.Weight =11.5;
      } 

    public string Catagory()
      {
          return "penguin";
      }

      public string Skip()
      {
        return "one legged hop";
      }

      public string Waddle()
      {
        return "slow shuffle";
      }

      public string Honk()
      {
        return "Blast of audio death";
      }
   
      public override string Eat(int numberOfFoodz)
       {//Virtual for excercise 2
           
          if (numberOfFoodz <=0)
          {
              return base.Eat(numberOfFoodz) +  "Give me some Fish!!";
          }
          else
          {
              return base.Eat(numberOfFoodz) + "Can i swallow these " + numberOfFoodz + " fish heads ";
          }

       }
   
    }

}