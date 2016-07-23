using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pikachu yellowMouse = new Pikachu("Fred");
            string pikachu_response = yellowMouse.Eat(5);
            string pikachu_action = yellowMouse.Fly(); 
            Console.WriteLine(yellowMouse.Name + " says "+ pikachu_response);
            Console.WriteLine("I have a Pikachu called " + yellowMouse.Name  + " who can Fly by taking his arms " + 
            pikachu_action) ;


            Piplup bluePenguin = new Piplup("Sam");
            string piplup_action = bluePenguin.Eat(3);
            string piplup_response = bluePenguin.Skip();
            Console.WriteLine("I have a Piplup called " + bluePenguin.Name  + "ho can skip  by doing a " + piplup_action) ;
            Console.WriteLine( bluePenguin.Name + "has how many Legs? ....." + bluePenguin.Legs); 

            Radicate redRat = new Radicate("Moe");
            string radicate_action = redRat.Fang();
            string radicate_response = redRat.Eat(2);
            string radicate_action2 = redRat.Fang();
            string radicate_action3 = redRat.Claw();
            Console.WriteLine("I have a Radicate called " + redRat.Name  + " and when provoked will " + radicate_action) ;
            Console.WriteLine( redRat.Name + " is pretty heavy at " + redRat.Weight + " lbs."); 
            Console.WriteLine(redRat.Name + " says " + radicate_response);
            
            
            
            Squirtle blueTurtle = new Squirtle("Chuck");
            string blueTurtle_action = blueTurtle.Spin();
            string blueTurtle_response = blueTurtle.Eat(6);
            Console.WriteLine("I have a Squirtle called " + blueTurtle.Name  + " and " + blueTurtle_response) ;
            Console.WriteLine( blueTurtle.Name + " is ready pull " + blueTurtle_action); 
            
            //excersice 3
            Console.WriteLine("enter a number of legs please");
            int numberOfLegs = Int32.Parse(Console.ReadLine());
            Pikachu leggyPikachu = new Pikachu(numberOfLegs);
            Console.WriteLine ("leggyPikachu has " + leggyPikachu.Legs + " legs");

            Console.WriteLine("enter the number of jumps");
            string squirtlePhrase;
            int numberOfJumps = Int32.Parse(Console.ReadLine());
            if (numberOfJumps <= 5){
                squirtlePhrase = "Bless your Heart";
            }
            else
            {
                squirtlePhrase = "Haven't seen you in a month of sunday's";
            }

            Squirtle jumpySquirtle = new Squirtle(numberOfJumps, squirtlePhrase);
            Console.WriteLine ("jumpySquirtle has jumped " + jumpySquirtle.NumberOfJumps +" and said " + jumpySquirtle.SouthernPhrase);
            
                
            Blastoise purpleBlastoise = new Blastoise("Sally");
            Console.WriteLine("New to the Zoo " + purpleBlastoise.Name + " the Blastoise");



            Console.ReadLine(); 

        }

    }
}
