using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Events
{
    public class ICQEditedMessageEvent : ICQEvent
    {
        public ICQEditedMessageEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {
        }
    }
}