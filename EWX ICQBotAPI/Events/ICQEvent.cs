using EWXICQBotAPI.Responses.AbstractResponses.Substructs;
using EWXICQBotAPI.Types;

namespace EWXICQBotAPI.Events
{
    public class ICQEvent
    {
        protected ICQBot _instance;
        protected ICQEventType _type;
        protected ICQAEvent _event;

        public ICQEvent(ICQBot instance, ICQAEvent ev)
        {
            _instance = instance;
            _event = ev;
            //_type = _instance.ParseEventType(_event.type);
        }

        public ICQEventType GetEventType()
        {
            return _type;
        }

        public ICQAEvent GetAbstractEvent()
        {
            return _event;
        }
    }
}