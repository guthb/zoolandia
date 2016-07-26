using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Wartortle : Water 
    {

        
        public Wartortle (string name)
        {//constructor
            this.Name = name;
            this.Catagory =  "shellfish";
        }
        
        
        public Wartortle (double height, double weight)
        {//constuctor
            
            this.Height = 3.03;
            this.Weight =49.6;
            
        } 

        public bool battleTeeth()
        {
            return false;
        }

        public string fluffyTail()
        {
            return "you just got Tailed";
        }

        public  Wartortle() :base()
        {
            
            this.Catagory =  "Turtle";
        }
            
    
    }

}