using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Events
{
    public class ICQLeftChatMembersEvent : ICQEvent
    {
        public ICQLeftChatMembersEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {

        }

    }
}