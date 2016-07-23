
//bulbasaur ivysaur venusaur
namespace Zoolandia.Genus
{
    public class Grass : Animal
    {
        public Grass() : base()
        {
            
        }
        //overloaded constructor of Animal
        public Grass(int pokeLegs) :base()
        {
            this.Legs = pokeLegs;
            
        }
        // propery of Grass Genus
        public int Scales{get;set;}
       
        public string Catagory()
        {
            return "seed";
            
        }


    }
}