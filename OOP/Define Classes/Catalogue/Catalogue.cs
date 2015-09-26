using System;
using System.Collections.Generic;

class Catalogue
{
    static void Main()
    {
        var computerOne = new Computer("Pentagon 4", new List<Component>()
        {
            new Component("processor", 4532.4321), 
            new Component("graphics card", 459, "Intel HD Graphics 4400" ), 
            new Component("screen", 200, "13.3 (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display")
        });
        var computerTwo = new Computer("Pentagon 2 test", new List<Component>());
        try
        {
            var computerThree = new Computer("Pentagon 3 experiments", new List<Component>()
            {

            //    new Component("", 341.432),
              //  new Component("Processor", - 2142.435, "perfect condition" ),
                new Component(null, 2512, "good condition"),
                new Component("graphics", 241, "")
            });
          
            Console.WriteLine(computerThree);
        }
     catch(ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine(computerOne);
        Console.WriteLine(computerTwo);
    }
}

