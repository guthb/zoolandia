
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Jigglypuff : Fairy
    {
        
        public Jigglypuff (string name)
        {//constructor
            this.Name = name;
        }
        
        
        public Jigglypuff (double height, double weight)
        {//constuctor
            
            this.Height = 1.08;
            this.Weight = 12.1;
            
        } 

        public bool battlePuff()
        {
            return false;
        }

        public string puffyCute()
        {
            return "charming you sweetly";
        }

    }

}