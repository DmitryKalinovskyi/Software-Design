﻿using Factory_Method.ContentSource;

namespace Factory_Method.Channels
{
    public class SimpleChannel : IChannel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IContentSource Source { get; set; }

        public SimpleChannel(string name, string description, IContentSource source)
        {
            Name = name;
            Description = description;
            Source = source;
        }
    }
}
