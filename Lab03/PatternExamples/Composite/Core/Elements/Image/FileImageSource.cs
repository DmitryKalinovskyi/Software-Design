namespace Composite.Core.Elements.Image
{
    public class FileImageSource : IImageSource
    {
        public string GetImage(string uri)
        {
            return $"Loading file with uri: {uri}";
        }
    }
}
