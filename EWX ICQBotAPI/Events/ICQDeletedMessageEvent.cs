using EWXICQBotAPI.Responses.AbstractResponses.Substructs;
using EWXICQBotAPI.Types;

namespace EWXICQBotAPI.Events
{
    public class ICQDeletedMessageEvent : ICQEvent
    {
        public ICQDeletedMessageEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {

        }

        public string GetDeletedMessageID()
        {
            return base._event.payload.msgId;
        }

        public ICQChat GetChat()
        {
            return _instance.GetChat(base._event.payload.chat.chatId);
        }
    }
}