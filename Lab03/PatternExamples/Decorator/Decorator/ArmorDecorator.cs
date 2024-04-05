using Decorator.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public class ArmorDecorator : HeroDecorator
    {
        public ArmorDecorator(IHero hero) : base(hero) { }

        public override string GetInfo()
        {
            return new StringBuilder()
                .AppendLine(base.GetInfo())
                .AppendLine("Wearing Armor.")
                .ToString();
        }
    }
}
