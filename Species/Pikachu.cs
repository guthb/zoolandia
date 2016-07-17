//height 1'04""
//mouse
//weight 13.2 lbs

using System;

namespace Zoolandia.Species
{
    public class Pikachu : Animal  
    {
      public Pikachu(string name) :base(name)
      {//constuctor
          this.Legs = 4;
          this.Height = 1.04;
          this.Weight =13.2;
      } 

      public string Catagory()
      {
          return "mouse";
      }
      public string Swim()
      {
        return "floating agressively";
      }

      public string Fly()
      {
        return "flapping skyward";
      }

      public string Fight()
      {
        return "lighting bolts of death";
      }
    }

}