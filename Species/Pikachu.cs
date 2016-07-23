//height 1'04""
//mouse
//weight 13.2 lbs



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

      public Pikachu(int legs) :base(legs)
      {
          this.Legs = legs;
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

      public override string Eat(int numberOfFoodz)
       {//Virtual for excercise 2
        
      
        if (numberOfFoodz <=0)
          {
              return base.Eat(numberOfFoodz) +  "Not Hungry";
          }
          else
          {
              return base.Eat(numberOfFoodz) +  numberOfFoodz + " Bubblegum takes a long time";
          }
      
       }

    }

}