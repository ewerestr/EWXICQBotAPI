using EWXICQBotAPI.Events;
using EWXICQBotAPI.Responses.AbstractResponses;
using EWXICQBotAPI.Responses.AbstractResponses.Substructs;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;

namespace EWXICQBotAPI
{
    class ICQLongpoll
    {
        private ICQBot _instance;
        private Thread _longpollThread;
        private bool _work = false;

        public ICQLongpoll(ICQBot instance)
        {
            _instance = instance;
        }

        public void Start()
        {
            _longpollThread = new Thread(Longpoll);
            _work = true;
            _longpollThread.Start();
        }

        public void Stop()
        {

        }

        private void Longpoll()
        {
            List<string> noSpot = new List<string>();
            while (_work)
            {
                string poll = _instance.Poll();
                ICQAEventsGetResponse events = JsonSerializer.Deserialize<ICQAEventsGetResponse>(poll);
                if (events != null)
                {
                    if (events.ok)
                    {
                        if (events.events.Length > 0)
                        {
                            foreach (ICQAbsEvent ev in events.events)
                            {
                                if (!noSpot.Contains(ev.payload.msgId)) _instance.GetEventHandler().Event(_instance, ev);
                                if (ev.type == "deletedMessage") noSpot.Add(ev.payload.msgId);
                            }
                            _instance.SetLastEventId(events.events.Last().eventId);
                        }
                    }
                }
                if (noSpot.Count > 0) noSpot.Clear();
                // throw exception
            }
        }

        public bool IsAlive()
        {
            if (_longpollThread != null) if (_longpollThread.IsAlive) return true;
            return false;
        }
    }
}