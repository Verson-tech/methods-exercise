using MethodExercise;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MethodExercise
{
    internal class Methods
    {
        public static void MethodString()
        {
            Console.WriteLine("What is your name?"); //output
            string name = Console.ReadLine();        //input

            Console.WriteLine("What is your favourite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your string favourite animal");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favourite band?");
            string favouriteBand = Console.ReadLine();

            Console.WriteLine($"Your name is {name}, your favourite color is {color}, your favourite animal {animal} and your favourite band is {favouriteBand}." );
        }
    }
};




