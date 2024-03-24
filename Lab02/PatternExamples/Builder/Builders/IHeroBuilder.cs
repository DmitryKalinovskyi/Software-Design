namespace Builder.Builders
{
    public interface IHeroBuilder : IHumanoidEntityBuilder
    {
        public IHeroBuilder SetListOfGoodThingsDone(List<string> listOfThings);
    }
}
