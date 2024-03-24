using Builder.CustomProperties;
using Builder.Models;
using Builder.Models.EntityParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public abstract class DefaultHumanoidEntityBuilder: IHumanoidEntityBuilder
    {
        protected HumanoidEntity _humanoidEntity;

        protected DefaultHumanoidEntityBuilder(HumanoidEntity humanoidEntity)
        {
            _humanoidEntity = humanoidEntity;
        }

        public virtual IHumanoidEntityBuilder SetName(string name)
        {
            _humanoidEntity.Name = name;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetHair(Hair hair)
        {
            _humanoidEntity.Hair = hair;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetUpperBodyPart(UpperBodyPart part)
        {
            _humanoidEntity.UpperBody = part;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetPants(Pants pants)
        {
            _humanoidEntity.Pants = pants;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetMaxHitpoins(double maxHitpoins) 
        {
            _humanoidEntity.MaxHitPoints.BaseValue = maxHitpoins;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetAgility(double agility)
        {
            _humanoidEntity.Agility.BaseValue = agility;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetMeeleStrength(double meeleStrength)
        {
            _humanoidEntity.MeeleStrength.BaseValue = meeleStrength;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetMagicStrength(double magicStrength)
        {
            _humanoidEntity.MagicStrength.BaseValue = magicStrength;
            return this;
        }

        public abstract IHumanoidEntityBuilder ResetBuilder();

        public abstract HumanoidEntity Build();

        public virtual IHumanoidEntityBuilder SetEyes(Eyes eyes)
        {
            _humanoidEntity.Eyes = eyes;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetBoots(Boots boots)
        {
            _humanoidEntity.Boots = boots;
            return this;
        }

        public virtual IHumanoidEntityBuilder SetHat(Hat hat)
        {
            _humanoidEntity.Hat = hat;
            return this;
        }
    }
}
