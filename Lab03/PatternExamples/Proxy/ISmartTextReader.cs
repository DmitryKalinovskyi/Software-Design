namespace Proxy
{
    public interface ISmartTextReader
    {
        public void OpenFile(string path);

        public void CloseFile();

        public string[] GetFileContent();
    }
}
