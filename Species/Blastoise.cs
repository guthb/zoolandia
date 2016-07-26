using System;
using Zoolandia.Genus;

namespace Zoolandia.Species
{
    public class Blastoise: Animal, IBlast , ISwimming
    {
        public void watercannon()
        {
            Console.WriteLine("You have been hit by the water cannons");
        }

        public void breaststroke()
        {
            Console.WriteLine("fastest swimmer in the turtle group");
        }
        
        public Blastoise (string name)
        {//constructor
            this.Name = name;
        }

        public void butterfly()
        {
            Console.WriteLine("");
        }
    
        public bool battleTeeth()
        {
            return false;
        }

        public string lazerEyes()
        {
            return "you just got stinkeyed by the lazerEyes";
        }

        // public  Blastoise() :base()
        // {
            
        //     this.Catagory =  "shellfish";
        // }
            
        //   public Blastoise (string name) 
        // {//constructor
        //     this.Name = name;
        //     this.Catagory =  "shellfish";
        // }
        
        // public Blastoise (double height, double weight)
        // {//constuctor
            
        //     this.Height = 5.03;
        //     this.Weight =188.5;
            
        // }  
        

    }

}