using System;
using TemplateMethodPattern.Builder;

namespace TemplateMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarBuilder c = new PorcheBuilder();
            c.BuildCar();

            c = new BeetleBuilder();
            c.BuildCar();

            Console.ReadKey();
        }
    }
}