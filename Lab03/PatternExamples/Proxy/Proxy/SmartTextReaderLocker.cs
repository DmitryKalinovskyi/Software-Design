using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy.Proxy
{
    public class SmartTextReaderLocker: ISmartTextReader
    {
        private ISmartTextReader _reader;

        private Regex _securedFilesRegex;

        public SmartTextReaderLocker(ISmartTextReader reader, Regex securedFilesRegex)
        {
            _reader = reader;
            _securedFilesRegex = securedFilesRegex;
        }

        public void CloseFile()
        {
            _reader.CloseFile();
        }

        public string[] GetFileContent()
        {
            return _reader.GetFileContent();
        }

        public void OpenFile(string path)
        {
            if (_securedFilesRegex.IsMatch(path))
            {
                Console.WriteLine("Access denied!");
                return;
            }

            _reader.OpenFile(path); 
        }
    }
}
