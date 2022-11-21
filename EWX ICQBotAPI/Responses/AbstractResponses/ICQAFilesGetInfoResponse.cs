namespace EWXICQBotAPI.Responses.AbstractResponses
{
    public class ICQAFilesGetInfoResponse
    {
        public bool ok { get; set; } = false;
        public string type { get; set; }
        public ulong size { get; set; }
        public string filename { get; set; }
        public string url { get; set; }
    }
}