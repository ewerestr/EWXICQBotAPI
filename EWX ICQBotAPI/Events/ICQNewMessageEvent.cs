using EWXICQBotAPI.Responses.AbstractResponses.Substructs;
using EWXICQBotAPI.Types;

namespace EWXICQBotAPI.Events
{
    public class ICQNewMessageEvent : ICQEvent
    {
        public ICQNewMessageEvent(ICQBot instance, ICQAEvent ev) : base(instance, ev)
        {

        }

        public string GetMessage()
        {
            return base._event.payload.text;
        }

        public ICQUser GetSender()
        {
            return new ICQUser(base._instance, base._event.payload.from);
        }

        public ICQChat GetChat()
        {
            return _instance.GetChat(base._event.payload.chat.chatId);
        }
    }
}