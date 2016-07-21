//height 1'08""
//tiny turtle
//weight 19.8 lbs



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

      public override string Eat(int numberOfFoodz)
       {//Virtual for excercise 2
          

      
        if (numberOfFoodz <=0)
          {
              return base.Eat(numberOfFoodz) +  "Can i please eat!!";
          }
          else
          {
              return base.Eat(numberOfFoodz) + "of "  + numberOfFoodz + " cookies takes a long time to chew.";
          }
      
      
       }

    }

}