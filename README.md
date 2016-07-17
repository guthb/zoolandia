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

Once you are happy