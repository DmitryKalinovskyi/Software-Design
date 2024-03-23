using Factory_Method.ContentSource;

namespace Factory_Method.Channels
{
    public interface IChannel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IContentSource Source { get; set; }
    }
}
