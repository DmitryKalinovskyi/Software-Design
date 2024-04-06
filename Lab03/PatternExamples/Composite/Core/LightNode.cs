namespace Composite.Core
{
    public abstract class LightNode
    {
        public abstract string GetInnerHTML();

        public abstract string GetOuterHTML();

        public abstract IEnumerable<string> GetLazyInnerHTML();

        public abstract IEnumerable<string> GetLazyOuterHTML();
    }
}
