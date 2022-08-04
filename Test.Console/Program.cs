using System;
using System.Collections;
using System.Collections.Generic;
using Model;

namespace Test.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Canvas canvas = new Canvas();
            canvas.AddRedCircle();
            canvas.AddGreenLine();
            canvas.AddGreenLine();
            canvas.Paint();

            System.Console.WriteLine("Press any key to exist!!");
            System.Console.ReadLine();
        }
    }
}
