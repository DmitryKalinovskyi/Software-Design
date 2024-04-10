namespace Flyweight.FlyweightVersion
{
    public class TagType
    {
        public static TagType Undefined = new();

        public readonly string TagName;

        public readonly bool IsSelfClosing;

        public readonly bool IsSemantic;

        public TagType()
        {
            TagName = "?";
            IsSelfClosing = false;
            IsSemantic = false;
        }

        public TagType(string tagName, bool isSelfClosing = false, bool isSemantic = false)
        {
            TagName = tagName.ToLower();
            IsSelfClosing = isSelfClosing;
            IsSemantic = isSemantic;
        }

        public string GetInfo()
        {
            return $"Tag: {TagName} - {(IsSelfClosing ? "Self-Closing" : "Not self-closing")}, semantic - {IsSemantic}";
        }

        // especially for cache factory
        public override int GetHashCode()
        {
            return TagName.GetHashCode() * 17
                ^ IsSelfClosing.GetHashCode() * 31
                ^ IsSemantic.GetHashCode() * 37;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (!(obj is TagType)) return false;

            var otherTag = (TagType)obj;

            return otherTag.IsSelfClosing == IsSelfClosing &&
                otherTag.TagName == TagName &&
                otherTag.IsSemantic == IsSemantic;
        }
    }
}
