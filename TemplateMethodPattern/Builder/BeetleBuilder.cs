using System;

namespace TemplateMethodPattern.Builder
{
    public class BeetleBuilder : CarBuilder
    {
        protected override void BuildSkeleton()
        {
            Console.WriteLine("Building Beetle Skeleton");
        }

        protected override void InstallEngine()
        {
            Console.WriteLine("Installing Beetle Engine");
        }

        protected override void InstallDoor()
        {
            Console.WriteLine("Installing Beetle Door");
        }
    }
}