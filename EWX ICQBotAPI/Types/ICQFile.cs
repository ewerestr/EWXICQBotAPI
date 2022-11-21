namespace EWXICQBotAPI.Types
{
    public class ICQFile
    {
        private string _type;
        private ulong _size;
        private string _filename;
        private string _downloadLink;

        public ICQFile(string type, ulong size, string filename, string url)
        {
            _type = type;
            _size = size;
            _filename = filename;
            _downloadLink = url;
        }

        new public void GetType() { }

        public void GetSize() { }

        public void GetFilename() { }

        public void Download(string path = null) { }
    }
}