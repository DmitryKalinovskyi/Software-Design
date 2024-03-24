using Builder.Builders;
using Builder.Models;
using Builder.Models.Enchantments;
using Builder.Models.EntityParts;
using Builder.Shapes;
using System.Drawing;

namespace Builder
{
    public class Director
    {
        private IHeroBuilder _heroBuilder;
        private IEnemyBuilder _enemyBuilder;

        public Director() : this(new DefaultHeroBuilder(), new DefaultEnemyBuilder()) { }

        public Director(IHeroBuilder heroBuilder) : this(heroBuilder, new DefaultEnemyBuilder()) { }

        public Director(IEnemyBuilder enemyBuilder) : this(new DefaultHeroBuilder(), enemyBuilder) { }

        public Director(IHeroBuilder heroBuilder, IEnemyBuilder enemyBuilder)
        {
            _heroBuilder = heroBuilder;
            _enemyBuilder = enemyBuilder;
        }

        public Hero BuildMyDreamHero()
        {
            var hero = _heroBuilder
                .SetHeroListOfGoodThingsDone(
                new()
                {
                    "SOLID principles are often used.",
                    "Use full names against short.",
                    "Have several patterns inside each project."
                })

                .SetName("Dmytro")
                .SetEyes(new Eyes(Color.Black, EyeType.Hunter))
                .SetHair(new Hair(Color.Purple, new Shape("Fluffy")))

                .SetBoots(new Boots("Hercules boots", new Shape("Boots"), new RapidEnchantment()))
                .SetPants(new Pants("Tesla pants", new Shape("Pants shape")))
                .SetUpperBodyPart(new UpperBodyPart("Tesla mantia", new Shape("Mantia")))
                .SetHat(new Hat("Tesla hood", new Shape("Hood")))
                // define his strength
                .SetMaxHitpoins(100)
                .SetMagicStrength(200)
                .SetMeeleStrength(15)
                .SetAgility(50)
                .Build();

            return (Hero)hero;
        }

        public Enemy BuildArchEnemy()
        {
            var enemy = _enemyBuilder
                .SetEnemyListOfBadThingsDone(
                new()
                {
                    "Ignore SOLID principles.",
                    "Use short names in code like amnt, or len",
                    "Don't use patters, because own bicycle is better."
                })

                .SetName("Zurabikus")
                .SetEyes(new Eyes(Color.Black, EyeType.Hunter))
                .SetHair(new Hair(Color.DarkRed, new Shape("Fluffy")))
                .SetPants(new Pants("Red devil pants", new Shape("Pants shape")))
                .SetUpperBodyPart(new UpperBodyPart("Red devil chestplate", new Shape("Chestplate")))

                // define his strength
                .SetMaxHitpoins(100)
                .SetMagicStrength(10)
                .SetMeeleStrength(25)
                .SetAgility(25)
                .Build();

            return (Enemy)enemy;
        }
    }
}
