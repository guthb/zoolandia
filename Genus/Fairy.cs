
//jigglypuf wiggltuf

namespace Zoolandia.Genus
{
    public class Fairy : Animal
    {
        //constructor
        public Fairy() : base()
        {
            
        }
        //constructor that set the genus
        public Fairy(string fairyName ) :base()
        {
            this.Name = fairyName;
                
        }

        public Fairy(int fairyLegs) :base()
        {
            this.Legs = fairyLegs;
        }   

        public int Weakness{get;set;}
        

        public string Catagory()
        {
            return "balloon";
            
        }


    }  

}