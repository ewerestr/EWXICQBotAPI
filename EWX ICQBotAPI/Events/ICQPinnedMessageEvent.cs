using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Events
{
    public class ICQPinnedMessageEvent : ICQEvent
    {
        public ICQPinnedMessageEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {

        }
    }
}