using EWXICQBotAPI.Events;
using EWXICQBotAPI.Responses.AbstractResponses.Substructs;
using System;

namespace EWXICQBotAPI
{
    public delegate void EventHandler(ICQEvent ev);

    public class ICQEventHandler
    {
        public event EventHandler newMessage;
        public event EventHandler editedMessage;
        public event EventHandler deletedMessage;
        public event EventHandler pinnedMessage;
        public event EventHandler unpinnedMessage;
        public event EventHandler newChatMembers;
        public event EventHandler leftChatMembers;
        public event EventHandler callbackQuery;

        public void Event(ICQBot instance, ICQAEvent ev)
        {
            switch (ev.type)
            {
                case "newMessage":
                    {
                        newMessage(new ICQNewMessageEvent(instance, ev));
                        break;
                    }
                case "editedMessage":
                    {
                        editedMessage(new ICQEditedMessageEvent(instance, ev));
                        break;
                    }
                case "deletedMessage":
                    {
                        deletedMessage(new ICQDeletedMessageEvent(instance, ev));
                        break;
                    }
                case "pinnedMessage":
                    {
                        pinnedMessage(new ICQPinnedMessageEvent(instance, ev));
                        break;
                    }
                case "unpinnedMessage":
                    {
                        unpinnedMessage(new ICQUnpinnedMessageEvent(instance, ev));
                        break;
                    }
                case "newChatMembers":
                    {
                        newChatMembers(new ICQNewChatMembersEvent(instance, ev));
                        break;
                    }
                case "leftChatMembers":
                    {
                        leftChatMembers(new ICQLeftChatMembersEvent(instance, ev));
                        break;
                    }
                case "callbackQuery":
                    {
                        callbackQuery(new ICQCallbackQueryEvent(instance, ev));
                        break;
                    }
            }
        }
    }
}