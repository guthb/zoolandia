//height 2'04"
//Rat
//weight 40.8 lbs

using System;

namespace Zoolandia.Species
{
    public class Radicate : Animal  
    {
      public Radicate(string name) :base(name)
      {//constuctor
          this.Legs = 4;
          this.Height = 1.08;
          this.Weight =40.8;
          
      } 

      public string Catagory()
      {
          return "rat";
      }

      public string Fang()
      {
        return "Bite arms";
      }

      public string Whip()
      {
        return "Tail poked out eye";
      }

      public string Claw()
      {
        return "Nails of Death";
      }
    }

}