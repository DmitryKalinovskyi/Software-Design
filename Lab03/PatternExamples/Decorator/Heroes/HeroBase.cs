﻿namespace Decorator.Heroes
{
    public abstract class HeroBase : IHero
    {
        public string Name { get; set; }

        public HeroBase()
        {
            Name = "";
        }

        public HeroBase(string name)
        {
            Name = name;
        }

        public abstract string GetInfo();
    }
}
