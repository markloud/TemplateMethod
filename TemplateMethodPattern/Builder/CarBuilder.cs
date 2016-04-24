namespace TemplateMethodPattern.Builder
{
    public abstract class CarBuilder
    {
        protected abstract void BuildSkeleton();

        protected abstract void InstallEngine();

        protected abstract void InstallDoor();

        //Template Method that specifies the general logic
        public void BuildCar()
        {
            BuildSkeleton();
            InstallEngine();
            InstallDoor();
        }
    }
}