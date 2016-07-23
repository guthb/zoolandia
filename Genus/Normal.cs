
//jigglypuf wigglypuf rattata radicate

namespace Zoolandia.Genus
{
    public class Normal : Animal
    {
    
        public Normal() : base()
        {
            
        }

        public Normal(int ratLegs) :base()
        {
            this.Legs = ratLegs;
            
        }
        // propery of Normal Genus
        public int RunAway{get;set;}
       
        public string Catagory()
        {
            return "rat";
            
        }

    }


}