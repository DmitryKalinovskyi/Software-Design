using System.Text;

namespace Factory_Method.ContentSource
{
    public class TextSource : IContentSource
    {
        public byte[] GetContent(int bitOffset, int length)
        {
            return GetContentAsync(bitOffset, length).Result;
        }

        public async Task<byte[]> GetContentAsync(int bitOffset, int length)
        {
            // suppose you return text content here :)
            return Encoding.ASCII.GetBytes("Hellow from text source! :)");
        }
    }
}
