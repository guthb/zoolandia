
//Squirtel Wortortle Blastoise
namespace Zoolandia.Genus
{
    public class Water : Animal
    {
        public Water() : base()
        {
            
        }//overloaded constructor of Animal
        
        public string Catagory{get;set;} 
       
        
        //overloaded constructor of Animal
        public Water(int waterLegs) :base()
        {
            this.Legs = waterLegs;
        } 

        public string Blast()
        {
            return "you just got basted by a water bullet";
        }




    }



}