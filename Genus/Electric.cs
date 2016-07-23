
//Pikachu and Raichu

namespace Zoolandia.Genus
{
    public class Electric : Animal
    {//constructor
        public Electric() : base()
        {
            
        }
    //overloaded constructor of Animal
    public Electric(string elecName ) :base(){
            this.Name = elecName;
            
        }

    // example of constructor ^^^
    // Electric(string elecName)   :base(elecName){
    // }
    public string Catagory()
        {
            return "mouse";
            
        }
    
    
    }


}