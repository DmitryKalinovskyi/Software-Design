﻿using Builder.Models;
using Builder.Models.EntityParts;

namespace Builder.Builders
{
    public interface IHumanoidEntityBuilder
    {
        public IHumanoidEntityBuilder SetName(string name);

        public IHumanoidEntityBuilder SetEyes(Eyes eyes);

        public IHumanoidEntityBuilder SetHair(Hair hair);

        public IHumanoidEntityBuilder SetBoots(Boots boots);

        public IHumanoidEntityBuilder SetHat(Hat hat);

        public IHumanoidEntityBuilder SetUpperBodyPart(UpperBodyPart part);

        public IHumanoidEntityBuilder SetPants(Pants pants);

        public IHumanoidEntityBuilder SetMaxHitpoins(double maxHitpoins);

        public IHumanoidEntityBuilder SetAgility(double agility);

        public IHumanoidEntityBuilder SetMeeleStrength(double meeleStrength);

        public IHumanoidEntityBuilder SetMagicStrength(double magicStrength);

        public IHumanoidEntityBuilder ResetBuilder();

        public HumanoidEntity Build();
    }
}
