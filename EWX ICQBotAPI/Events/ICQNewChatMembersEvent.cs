using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Events
{
    public class ICQNewChatMembersEvent : ICQEvent
    {
        public ICQNewChatMembersEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {
        }
    }
}