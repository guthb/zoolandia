using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Wigglytuff : Fairy
    {
        
        public Wigglytuff (string name)
        {//constructor
            this.Name = name;
        }
        
        
        public Wigglytuff (double height, double weight)
        {//constuctor
            
            this.Height = 3.03;
            this.Weight = 26.5;
            
        } 

        public bool battletuff()
        {
            return false;
        }

        public string tuffyCute()
        {
            return "so cute it crying";
        }

    }

}