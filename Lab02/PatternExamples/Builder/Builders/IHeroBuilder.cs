namespace Builder.Builders
{
    public interface IHeroBuilder : IHumanoidEntityBuilder
    {
        public IHeroBuilder SetHeroListOfGoodThingsDone(List<string> listOfThings);
    }
}
