﻿namespace ZooManager.Commands
{
    public abstract class Command: ICloneable
    {
        public string Description { get; set; }

        public Command()
        {
            Description = "";
        }

        public Command(string description)
        {
            Description = description;
        }

        public abstract void Execute(object? parameter);

        public abstract object Clone();
    }
}
