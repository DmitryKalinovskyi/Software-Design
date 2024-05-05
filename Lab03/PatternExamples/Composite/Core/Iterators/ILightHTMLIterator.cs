namespace Composite.Core.Iterators
{
    public interface ILightHTMLIterator
    {
        LightNode? GetNext();

        bool HasNext();
    }
}
