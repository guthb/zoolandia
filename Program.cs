using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pikachu yellowMouse = new Pikachu("Fred");
            string pikachu_response = yellowMouse.Eat(0);
            string pikachu_action = yellowMouse.Fly(); 
            Console.WriteLine(yellowMouse.Name + " says "+pikachu_response);
            Console.WriteLine("I have a Pikachu called " + yellowMouse.Name  + " who can Fly by taking his arms " + 
            pikachu_action) ;


            Piplup bluePenguin = new Piplup("Sam");
            string piplup_action = bluePenguin.Skip();
            Console.WriteLine("I have a Piplup called " + bluePenguin.Name  + "ho can skip  by doing a " + piplup_action) ;
            Console.WriteLine( bluePenguin.Name + "has how many Legs? ....." + bluePenguin.Legs); 

            Radicate redRat = new Radicate("Moe");
            string radicate_action = redRat.Fang();
            string radicate_response = redRat.Claw();
            Console.WriteLine("I have a Radicate called " + redRat.Name  + " and when provoked will " + radicate_action) ;
            Console.WriteLine( redRat.Name + " is pretty heavy at " + redRat.Weight + " lbs."); 
            
            
            Squirtle blueTurtle = new Squirtle("Chuck");
            string blueTurtle_action = blueTurtle.Spin();
            string blueTurtle_response = blueTurtle.Eat(6);
            Console.WriteLine("I have a Squirtle called " + blueTurtle.Name  + " and " + radicate_action) ;
            Console.WriteLine( blueTurtle.Name + " is ready pull " + blueTurtle_action); 
            

        }

    }
}
