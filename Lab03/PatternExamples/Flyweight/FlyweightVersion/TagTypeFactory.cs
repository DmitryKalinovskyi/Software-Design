﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.FlyweightVersion
{
    /// <summary>
    /// Allow to receive TagType by properties.
    /// </summary>
    public class TagTypeFactory
    {
        // how this works? TagType have overriden GetHashCode and Equals methods, that used inside dictionary.
        // when we have 2 TagTypes with the same properties, they will have the same hashcode, but different references.
        private Dictionary<TagType, TagType> _cachedTagTypes;

        public TagTypeFactory() 
        {
            _cachedTagTypes = new();
        }

        public TagType GetCached(TagType tagType)
        {
            if(_cachedTagTypes.ContainsKey(tagType))
                // we already have tagType with the same properties inside cache.
                return _cachedTagTypes[tagType];

            // add to the cache
            _cachedTagTypes[tagType] = tagType;

            return tagType;
        }

        public int CountOfCachedTags => _cachedTagTypes.Count;

        public List<TagType> GetCachedTags() => _cachedTagTypes.Values.ToList();
    }
}
