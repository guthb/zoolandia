# Zoolandia 1 - Defining Your Favorite Species

## Setup

Create a new workspace sub-directory in your Windows home directory, initialize it as a git repo and create a boilerplate README.

```bash
cd && mkdir -p workspace/zoolandia && cd $_
git init
echo `# Zoolandia` > README.md
```

Next, create a new repository on Github, copy the git URL and add it as a remote origin. Then commit and push your README. Lastly, create a branch for this first exercise.

```bash
git remote add origin {paste URL here}
git add .
git commit -m "Initial commit"
git push origin master
git checkout -b version-1
touch Zoolandia.cs
```

## Instructions

1. Visit [C# Pad](http://www.csharppad.com) and create your first C# class - the Animal class. Create some simple properties and methods on Animal. You are going to create some derived classes that inherit from Animal, so make sure that the properties/methods you add are general to **all** Animals (e.g. name, height, weight, etc).

    ##### Example property/method definition

    ```cs
    class Animal
    {
        public string name { get; set; }

        public static void sleep ()
        {
            Console.WriteLine("Animal is now sleeping");
        }
    }
    ```

1. After you are happy with your Animal class, create a derived class that defines a particular species of Animal. Create some properties that apply **only** to that species.

    ```cs
    // The species for a Red Pana
    class AilurusFulgens : Animal
    {
        // Define simple properties for a Red Panda
    }
    ```

1. Create three more classes for species of animals of your choosing. Wikipedia is a great tool to discover species names. Make sure you use a mix of native C# types for your properties.
1. Create some instances of your species.
1. Assign values to the properties of each.
1. Use `Console.WriteLine();` to output the property values of your animals to the console.

    ```
    Console.WriteLine("I have a Squirrel named Nutsy who makes a noise 
    that sounds like {0}. I'd rate  his cuteness as a {1}.", nutsy
    .Noise, nutsy.CutenessLevel);
    ```

## Submit to Github
Once you are happy with your C# Pad code, make sure that you copy all of it into the `Zoolandia.cs` file that you created above and then commit & push it.

#Zoolandia 2- Specializing Derived Classes

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-2
```

## Instructions

### Virtual/Override

1. Choose one of the general methods that you created in the `Animal` class and make it `virtual`.
1. Override that method in all of your species classes, giving each a more specialized implementation. For example, the species may only eat certain kinds of food, or have a limit on how much food can be eaten.
1. Make sure you invoke the parent class' overridden method with the `base` reference (e.g. `base.sleep()`);

### Constructors

1. Create a constructor function for each of your animals. The constructor function should, at the very least, set the initial name of all animals of that type to a name of your choosing.
  
  ```cs
  public MyAnimal ()
  {
    this.name = "Moopsie";
  }
  ```

1. Use `Console.WriteLine();` to output the name of each of your animal instances.

  ```
  MyAnimal animalInstance = new MyAnimal();
  Console.WriteLine(animalInstance.name);
  ```

# Zoolandia 3 - Method Overloading

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-3
```

## Instructions

1. Add a new, overloaded constructor method to your animal that takes a single string as an argument.
1. Inside the new constructor, using `this`, assign the value of the `name` property with the argument value.
1. Create an instance of your animal like before, but pass in the name of the animal as an argument.

	```
	Squirrel superman = new Squirrel("Sammy");
	Console.Write(superman.name);
	```

1. Add **another** overloaded constructor method that will set the value of one of the `int` typed properties of your animal. Define an integer as an argument and then create another instance of your animal and pass it an integer.
1. Add **ONE MORE** constructor method! This method will accept both an integer and a string as arguments. Set the appropriate property values with the argument values.

# Zoolandia 4- Creating Your Zoo

## Setup

```bash
cd ~/workspace/zoolandia
git checkout -b version-4
```

## Instructions

1. Decide on at least 15 species that you would like to include in your zoo and create a class for each species. 
1. Each species should inherit from the appropriate genus (in a class that you create), and each genus should inherit from the `Animal` class.

    ```
    // Base animal class
    public class Animal 
    {
    	// add properties and methods
    }

    // Genus class, inherits from animal class
    public class Equus : Animal 
    {
    	//add properties and methods
    }

    // Species class, inherits from the corresponding genus class
    public class Quagga : Equus
    {
        string commonName = "Zebra";
    	string scientificName = "Equus quagga";
    	// add more properties and methods
    }
    ```
1. Once you've created all of your species, give them some methods and properties. Include several methods on your Animal and/or genus classes that can be overridden and then override them in your species classes.
1. Create some overloaded methods on some of your species (or genus) classes.


## Notes

This wil be the last exercise that you do in C# Pad. By the time you are done with this exercise, hopefully everyone has Windows and Visual Studio installed.