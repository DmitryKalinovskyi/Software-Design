namespace Builder.Models.Enchantments
{
    public class RapidEnchantment : IAgilityEnchantment, IMagicStrengthEnchantment
    {
        public int MagicStrengthBoost { get; } = 10;

        public int AgilityPercentBoost { get; } = 15;
    }
}
