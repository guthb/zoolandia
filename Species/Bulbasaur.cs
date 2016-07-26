using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Bulbasaur : Grass
    {
        public Bulbasaur(int legs) : base(legs)
        {
            this.Legs = legs;
        }
    
        public Bulbasaur (string name)
        {//constructor
            this.Name = name;
        }
    
    
    
    }

}