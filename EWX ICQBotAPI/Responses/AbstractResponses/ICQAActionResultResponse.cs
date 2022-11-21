namespace EWXICQBotAPI.Responses.AbstractResponses
{
    public class ICQAActionResultResponse
    {
        public bool ok { get; set; } = false;
        public string msgId { get; set; }
        public string fileId { get; set; }
    }
}