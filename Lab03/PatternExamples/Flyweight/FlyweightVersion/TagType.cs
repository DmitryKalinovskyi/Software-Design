using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.FlyweightVersion
{
    public class TagType
    {
        public static TagType Undefined = new();

        private string _tagName = "";
        public string TagName
        {
            get => _tagName;
            set
            {
                _tagName = value.ToLower();
            }
        }

        public bool IsSelfClosing { get; set; }

        public TagType()
        {
            TagName = "?";
            IsSelfClosing = false;
        }

        public TagType(string tagName, bool isSelfClosing = false)
        {
            TagName = tagName;
            IsSelfClosing = isSelfClosing;
        }

        public string GetInfo()
        {
            return $"Tag: {_tagName} - {(IsSelfClosing ? "Self-Closing" : "Not self-closing")}";
        }

        // especially for cache factory
        public override int GetHashCode()
        {
            return _tagName.GetHashCode() * 17
                ^ IsSelfClosing.GetHashCode() * 31;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (!(obj is TagType)) return false;

            var otherTag = (TagType)obj;

            return otherTag.IsSelfClosing == IsSelfClosing &&
                otherTag._tagName == _tagName;
        }
    }
}
