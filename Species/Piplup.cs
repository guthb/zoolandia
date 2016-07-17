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
    }

}