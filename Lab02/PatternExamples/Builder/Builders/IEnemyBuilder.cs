namespace Builder.Builders
{
    public interface IEnemyBuilder : IHumanoidEntityBuilder
    {
        public IEnemyBuilder SetListOfBadThingsDone(List<string> listOfThings);
    }
}
