using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Ivysaur : Grass
    {
        public Ivysaur(int legs) : base(legs)
        {
            this.Legs = legs;
        }

        public Ivysaur (string name)
        {//constructor
            this.Name = name;
        }
        

    }

    


}