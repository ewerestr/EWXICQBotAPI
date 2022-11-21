using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Responses.AbstractResponses
{
    public class ICQAEventsGetResponse
    {
        public bool ok { get; set; } = false;
        public ICQAEvent[] events { get; set; }
    }
}