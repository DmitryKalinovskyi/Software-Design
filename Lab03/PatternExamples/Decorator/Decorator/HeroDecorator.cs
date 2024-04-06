using Decorator.Heroes;

namespace Decorator.Decorator
{
    public abstract class HeroDecorator : IHero
    {
        private IHero _hero { get; set; }

        public HeroDecorator(IHero hero)
        {
            _hero = hero;
        }

        public virtual string GetInfo()
        {
            return _hero.GetInfo();
        }
    }
}
