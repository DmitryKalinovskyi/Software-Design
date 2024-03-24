using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.Enchantments
{
    public interface IAgilityEnchantment: IEhchantment
    {
        public int AgilityPercentBoost { get; }
    }
}
