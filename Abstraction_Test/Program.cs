using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abstraction_Test
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Lion : Cat
        {
            public Lion(ColorSpectrum color)
            {
                LionColor = color.ToString();
            }
            public enum ColorSpectrum { Brown, White }
            public string LionColor { get; set; }
            public override void Eat()
            {
                Console.WriteLine($"The {LionColor} lion eats.");
            }

            public override void Hunt()
            {
                Console.WriteLine($"The {LionColor} lion hunts.");
            }

            public override void Sleep()
            {
                Console.WriteLine($"The {LionColor} lion sleeps.");
            }
        }
    }
}
