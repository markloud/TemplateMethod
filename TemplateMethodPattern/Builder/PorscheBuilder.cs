using System;

namespace TemplateMethodPattern.Builder
{
    public class PorcheBuilder : CarBuilder
    {
        protected override void BuildSkeleton()
        {
            Console.WriteLine("Building Porche Skeleton");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Installing Porche Engine");
        }

        protected override void InstallDoor()
        {
            Console.WriteLine("Installing Porche Door");
        }
    }
}