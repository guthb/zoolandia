//height 2'04"
//Rat
//weight 40.8 lbs




namespace Zoolandia.Species
{
    public class Radicate : Animal  
    {
      public Radicate(string name) :base(name)
      {//constuctor
          this.Legs = 4;
          this.Height = 2.04;
          this.Weight = 40.8;
          
      } //methods

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

      public override string Eat(int numberOfFoodz)
       { //Virtual for excercise 2
             
          if (numberOfFoodz <=0)
          {
              return base.Eat(numberOfFoodz) +  "G ive me some Corn!!";
          }
          else
          {
              return base.Eat(numberOfFoodz) + " Can i swallow " + numberOfFoodz + " kernals yet?";
          }
                
        }
    }

}