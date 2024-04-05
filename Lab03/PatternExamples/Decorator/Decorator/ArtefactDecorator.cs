using Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
