namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQAMessage
    {
        public ICQAUser from { get; set; }
        public string msgId { get; set; }
        public string text { get; set; }
        public ICQATextFormat format { get; set; }
        public ulong timestamp { get; set; }
    }
}