﻿using Builder.Models;
using Builder.Models.EntityParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class DefaultEnemyBuilder : DefaultHumanoidEntityBuilder, IEnemyBuilder
    {
        public DefaultEnemyBuilder() : base(new Enemy()) { }

        public override Enemy Build()
        {
            return (Enemy)_humanoidEntity;
        }

        public override IEnemyBuilder SetHair(Hair hair)
        {
            return (IEnemyBuilder)base.SetHair(hair);
        }

        public override IEnemyBuilder SetPants(Pants pants)
        {
            return (IEnemyBuilder)base.SetPants(pants);
        }

        public override IEnemyBuilder SetUpperBodyPart(UpperBodyPart part)
        {
            return (IEnemyBuilder)base.SetUpperBodyPart(part);
        }

        public override IEnemyBuilder SetName(string name)
        {
            return (IEnemyBuilder)base.SetName(name);
        }

        public override IEnemyBuilder SetAgility(double agility)
        {
            return (IEnemyBuilder)base.SetAgility(agility);
        }

        public override IEnemyBuilder SetMagicStrength(double magicStrength)
        {
            return (IEnemyBuilder)base.SetMagicStrength(magicStrength);
        }

        public override IEnemyBuilder SetMaxHitpoins(double maxHitpoins)
        {
            return (IEnemyBuilder)base.SetMaxHitpoins(maxHitpoins);
        }

        public override IEnemyBuilder SetMeeleStrength(double meeleStrength)
        {
            return (IEnemyBuilder)base.SetMeeleStrength(meeleStrength);
        }

        public override IEnemyBuilder ResetBuilder()
        {
            _humanoidEntity = new Enemy();
            return this;
        }

        public IEnemyBuilder SetEnemyListOfBadThingsDone(List<string> listOfThings)
        {
            var enemy = (Enemy)_humanoidEntity;
            enemy.ListOfBadThingsDone = listOfThings;
            return this;
        }
    }
}
