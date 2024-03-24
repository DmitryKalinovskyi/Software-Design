using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models.Enchantments
{
    public interface IMagicStrengthEnchantment: IEhchantment
    {
        public int MagicStrengthBoost { get;}
    }
}
