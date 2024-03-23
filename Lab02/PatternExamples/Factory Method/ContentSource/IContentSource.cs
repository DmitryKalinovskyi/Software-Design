namespace Factory_Method.ContentSource
{
    public interface IContentSource
    {
        // here we add methods to get the content 

        public byte[] GetContent(int bitOffset, int length);

        public Task<byte[]> GetContentAsync(int bitOffset, int length);
    }
}
