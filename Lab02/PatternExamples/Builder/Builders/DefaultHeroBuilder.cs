using Builder.Models;
using Builder.Models.EntityParts;

namespace Builder.Builders
{
    public class DefaultHeroBuilder : DefaultHumanoidEntityBuilder, IHeroBuilder
    {
        public DefaultHeroBuilder() : base(new Hero()) { }

        public override Hero Build()
        {
            return (Hero)_humanoidEntity;
        }

        public override IHeroBuilder SetName(string name)
        {
            return (IHeroBuilder)base.SetName(name);
        }

        public override IHeroBuilder SetHair(Hair hair)
        {
            return (IHeroBuilder)base.SetHair(hair);
        }

        public override IHeroBuilder SetPants(Pants pants)
        {
            return (IHeroBuilder)base.SetPants(pants);
        }

        public override IHeroBuilder SetUpperBodyPart(UpperBodyPart part)
        {
            return (IHeroBuilder)base.SetUpperBodyPart(part);
        }

        public override IHeroBuilder SetAgility(double agility)
        {
            return (IHeroBuilder)base.SetAgility(agility);
        }

        public override IHeroBuilder SetMagicStrength(double magicStrength)
        {
            return (IHeroBuilder)base.SetMagicStrength(magicStrength);
        }

        public override IHeroBuilder SetMaxHitpoins(double maxHitpoins)
        {
            return (IHeroBuilder)base.SetMaxHitpoins(maxHitpoins);
        }

        public override IHeroBuilder SetMeeleStrength(double meeleStrength)
        {
            return (IHeroBuilder)base.SetMeeleStrength(meeleStrength);
        }

        public override IHeroBuilder ResetBuilder()
        {
            _humanoidEntity = new Hero();
            return this;
        }

        public IHeroBuilder SetListOfGoodThingsDone(List<string> listOfThings)
        {
            var hero = (Hero)_humanoidEntity;
            hero.ListOfGoodThingsDone = listOfThings;
            return this;
        }
    }
}
