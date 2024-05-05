namespace Composite.Core.Elements.Image
{
    public class ImageNode : LightElementNode
    {
        private IImageSource _imageSource;
        public string Href { get; set; } = string.Empty;


        public ImageNode(string href) : this(href, new NetworkImageSource()) { }

        public ImageNode(string href, IImageSource imageSource)
        {
            Href = href;
            _imageSource = imageSource;
        }

        public void SetImageSource(IImageSource imageSource)
        {
            _imageSource = imageSource;
        }

        public override string GetInnerHTML()
        {
            return _imageSource.GetImage(Href);
        }

        public override IEnumerable<string> GetLazyInnerHTML()
        {
            yield return _imageSource.GetImage(Href);
        }

        public override IEnumerable<string> GetLazyOuterHTML()
        {
            yield return $"<img href=\"{Href}\">";
            foreach (var line in GetLazyInnerHTML())
                yield return line;

            yield return $"</img>";
        }

        public override string GetOuterHTML()
        {
            return string.Join("", GetLazyInnerHTML());
        }
    }
}
