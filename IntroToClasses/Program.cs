using System;
using System.Runtime.InteropServices;

namespace IntroToClasses
{
    class Program
    {
       
        class Fairy
        {

        }
        class Corgi
        {
            public Corgi(string name, int width, int height, int length)
            {
                this.name = name;
                this.width = width;
                this.height = height;
                this.length = length;
                rider = new Fairy();
            }

            public Corgi(string name)
            {
                this.name = name;
                width = 50;
                height = 80;
                length = 100;
            }

            private string name;
            private int width, height, length;
            private Fairy rider;
            public static bool winner = true;

            public string Name { get => name;  }
            public int Width { get => width;  }
            public int Height { get => height;  }
            public int Length { get => length;  }

            public string Borf()
            {
                return Name +  ": BORK!";
            }
        }

        static void Main(string[] args)
        {
            string[] arr;
            arr = new string[8];

            Corgi clara= new Corgi("Clara");
            Corgi basil = new Corgi("Basil", 100, 100, 100);

            Corgi[] army = new Corgi[2];


            Console.WriteLine(clara.Borf());
            Console.WriteLine(basil.Borf());


        }
    }
}
