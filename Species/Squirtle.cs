//height 1'08""
//tiny turtle
//weight 19.8 lbs

using System;

namespace Zoolandia.Species
{
    public class Squirtle : Animal  
    {
       public Squirtle(string name) :base(name)
      {//constuctor
          this.Legs = 4;
          this.Height = 1.08;
          this.Weight =13.2;
      } 

    public string Catagory()
      {
          return "turtle";
      }
      public string Pull()
      {
        return "rips of arms and beat opponet to death";
      }

      public string Spin()
      {
        return "legs in shell spin";
      }

      public string Attack()
      {
        return "Squirt of waterr";
      }
    }

}