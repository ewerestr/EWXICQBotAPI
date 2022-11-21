using EWXICQBotAPI.Responses.AbstractResponses.Substructs;


namespace EWXICQBotAPI.Events
{
    public class ICQCallbackQueryEvent : ICQEvent
    {
        public ICQCallbackQueryEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {

        }

    }
}