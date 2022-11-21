namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQAEvent
    {
        public uint eventId { get; set; }
        public string type { get; set; }
        public ICQAEventPayload payload { get; set; }
    }
}
