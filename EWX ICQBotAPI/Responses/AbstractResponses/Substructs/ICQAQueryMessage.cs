namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQAQueryMessage
    {
        public uint eventId { get; set; }
        public string type { get; set; }
        public ICQAEventPayload payload { get; set; }    // msgId, chat, from, timestamp, text, format, parts
    }
}
