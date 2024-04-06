using Decorator.Heroes;
using System.Text;

namespace Decorator.Decorator
{
    public class ClothDecorator : HeroDecorator
    {
        public ClothDecorator(IHero hero) : base(hero) { }

        public override string GetInfo()
        {
            return new StringBuilder()
                .AppendLine(base.GetInfo())
                .AppendLine("Wearing Cloth.")
                .ToString();
        }
    }
}
