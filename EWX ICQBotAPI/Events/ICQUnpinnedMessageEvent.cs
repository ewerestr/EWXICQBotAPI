using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Events
{
    public class ICQUnpinnedMessageEvent : ICQEvent
    {
        public ICQUnpinnedMessageEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {

        }
    }
}