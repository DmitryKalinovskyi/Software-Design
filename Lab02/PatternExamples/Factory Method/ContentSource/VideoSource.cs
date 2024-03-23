using System.Text;

namespace Factory_Method.ContentSource
{
    public class VideoSource : IContentSource
    {
        private Uri _uri;

        public VideoSource(Uri uri)
        {
            _uri = uri;
        }

        public byte[] GetContent(int bitOffset = -1, int length = -1)
        {
            return GetContentAsync(bitOffset, length).Result;
        }

        public async Task<byte[]> GetContentAsync(int bitOffset, int length)
        {
            // suppose you return video content here :)
            return Encoding.ASCII.GetBytes("Hellow :)");
        }
    }
}
