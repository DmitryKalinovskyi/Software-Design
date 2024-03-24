namespace Builder.Builders
{
    public interface IEnemyBuilder : IHumanoidEntityBuilder
    {
        public IEnemyBuilder SetEnemyListOfBadThingsDone(List<string> listOfThings);
    }
}
