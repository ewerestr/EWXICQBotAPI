using System.Web;

namespace EWXICQBotAPI
{
    public class EWXRequestGenerator
    {
        private string _icqToken;
        private string _icqApi;

        public EWXRequestGenerator(string icqToken, string icqApi)
        {
            _icqToken = icqToken;
            _icqApi = icqApi;
        }

        public string ICQSelfGet()
        {
            string url = _icqApi + "self/get?token=" + _icqToken;
            return url;
        }

        public string ICQMessagesSendText(string chatId, string text)
        {
            string url = _icqApi + "messages/sendText?token=" + _icqToken + "&chatId=" + chatId + "&text=" + HttpUtility.UrlEncode(text);
            return url;
        }

        public string ICQMessagesSendFile(string chatId, string fileId) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        public string ICQMessagesSendVoice(string chatId, string fileId) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        public string ICQMessagesEditText(string chatId, string msgId, string text) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        public string ICQMessagesDeleteMessages(string chatId, string msgId) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        public string ICQMessagesAnswerCallbackQuery(string chatId) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        public string ICQChatsMembersDelete(string chatId, string members) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        // chats avatar set

        public string ICQChatsSendActions(string chatId, string actions) // deprecated
        {
            string url = _icqApi;
            return url;
        }

        public string ICQChatsGetInfo(string chatId)
        {
            string url = _icqApi + "chats/getInfo?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ICQChatsGetAdmins(string chatId)
        {
            string url = _icqApi + "chats/getAdmins?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ICQChatsGetMembers(string chatId, string cursor = null)
        {
            string url = _icqApi + "chats/getMembers?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ICQChatsGetBlockedUsers(string chatId)
        {
            string url = _icqApi + "chats/getBlockedUsers?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ICQChatsGetPendingUsers(string chatId)
        {
            string url = _icqApi + "chats/getPendingUsers?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ChatsBlockUser(string chatId) // deprecated
        {
            string url = _icqApi + "chats/getInfo?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ChatsUnblockUser(string chatId) // deprecated
        {
            string url = _icqApi + "chats/getInfo?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ChatsResolvePending(string chatId) // deprecated
        {
            string url = _icqApi + "chats/getInfo?token=" + _icqToken + "&chatId=" + chatId;
            return url;
        }

        public string ChatsSetTitle(string chatId, string title)
        {
            string url = _icqApi + "chats/setTitle?token=" + _icqToken + "&chatId=" + chatId + "&title=" + title;
            return url;
        }

        public string ChatsSetAbout(string chatId, string about)
        {
            string url = _icqApi + "chats/setAbout?token=" + _icqToken + "&chatId=" + chatId + "&about=" + about;
            return url;
        }

        public string ChatsSetRules(string chatId, string rules)
        {
            string url = _icqApi + "chats/setRules?token=" + _icqToken + "&chatId=" + chatId + "&about=" + rules;
            return url;
        }

        public string ChatsPinMessage(string chatId, int msgId)
        {
            string url = _icqApi + "chats/pinMessage?token=" + _icqToken + "&chatId=" + chatId + "&msgId=" + msgId;
            return url;
        }

        public string ChatsUnpinMessage(string chatId, int msgId)
        {
            string url = _icqApi + "chats/unpinMessage?token=" + _icqToken + "&chatId=" + chatId + "&msgId=" + msgId;
            return url;
        }

        public string FilesGetInfo(string fileId)
        {
            string url = _icqApi + "files/getInfo?token=" + _icqToken + "&fileId=" + fileId;
            return url;
        }

        // events get ?!
    }
}
