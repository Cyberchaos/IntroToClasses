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
            public string name;
            private int width, height, length;
            private Fairy rider;

            public string Borf()
            {
                return name +  ": BORK!";
            }
        }

        static void Main(string[] args)
        {
            string[] arr;
            arr = new string[8];

            Corgi clara= new Corgi();
            Corgi basil = new Corgi();

            clara.name = "Clara";
            basil.name = "Basil";

            Console.WriteLine(clara.Borf());
            Console.WriteLine(basil.Borf());


        }
    }
}
