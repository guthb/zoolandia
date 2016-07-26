using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Venusar : Grass
    {
        public Venusar(int legs) : base(legs)
        {
            this.Legs = legs;
        }

        public Venusar (string name)
        {//constructor
            this.Name = name;
        }


    }

}