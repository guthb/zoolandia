using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Blastoise : Water
    {

        
        public Blastoise (string name)
        {//constructor
            this.Name = name;
            this.Catagory =  "shellfish";
        }
        
        
        public Blastoise (double height, double weight)
        {//constuctor
            
            this.Height = 5.03;
            this.Weight =188.5;
            
        } 

        public bool battleTeeth()
        {
            return false;
        }

        public string lazerEyes()
        {
            return "you just got stinkeyed by the lazerEyesy";
        }

        public  Blastoise() :base()
        {
            
            this.Catagory =  "shellfish";
        }
            
          
        

    }

}