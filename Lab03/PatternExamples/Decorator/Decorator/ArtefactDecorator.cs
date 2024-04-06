using Decorator.Heroes;
using System.Text;

namespace Decorator.Decorator
{
    public class ArtefactDecorator : HeroDecorator
    {
        public ArtefactDecorator(IHero hero) : base(hero) { }

        public override string GetInfo()
        {
            return new StringBuilder()
                .AppendLine(base.GetInfo())
                .AppendLine("Carrying Artefact.")
                .ToString();
        }
    }
}
