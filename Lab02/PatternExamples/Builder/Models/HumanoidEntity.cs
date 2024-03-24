using Builder.CustomProperties;
using Builder.Models.EntityParts;
using System.Text;

namespace Builder.Models
{
    public abstract class HumanoidEntity
    {
        public string Name { get; set; }

        public Hair Hair { get; set; }

        public Eyes Eyes { get; set; }

        // cloth
        public Hat? Hat { get; set; }

        public UpperBodyPart? UpperBody { get; set; }

        public Pants? Pants { get; set; }

        public Boots? Boots { get; set; }

        // stats 
        public PercentProperty MaxHitPoints { get; private set; }

        public PercentProperty Agility { get; private set; }

        public PercentProperty MeeleStrength { get; private set; }

        public PercentProperty MagicStrength { get; private set; }

        public HumanoidEntity()
        {
            Name = "";
            Hair = new Hair();
            Eyes = new Eyes();

            // initialize stats
            MaxHitPoints = new();
            Agility = new();
            MeeleStrength = new();
            MagicStrength = new();
        }

        public virtual string GetInfo()
        {
            var builder = new StringBuilder();

            builder.AppendLine($"Name: {Name}")
                .AppendLine($"Hair: {Hair.GetInfo()}")
                .AppendLine($"Eyes: {Eyes.GetInfo()}")
                .AppendLine($"Hat: {Hat?.GetInfo() ?? "Not owned"}")
                .AppendLine($"UpperBody: {UpperBody?.GetInfo() ?? "Not owned"}")
                .AppendLine($"Pants: {Pants?.GetInfo() ?? "Not owned"}")
                .AppendLine($"Boots: {Boots?.GetInfo() ?? "Not owned"}")

                .AppendLine($"MaxHitPoints: {MaxHitPoints.GetInfo()}")
                .AppendLine($"Agility: {Agility.GetInfo()}")
                .AppendLine($"Meele Strength: {MeeleStrength.GetInfo()}")
                .AppendLine($"Magic Strength: {MagicStrength.GetInfo()}");

            return builder.ToString();
        }
    }
}
