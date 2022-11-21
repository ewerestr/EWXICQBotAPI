
using System.IO;
using System.Net;
using System.Threading;
using System.Web;

namespace EWXICQBotAPI
{
    public class ICQBot
    {
        ////    Main fields to work with API
        private string _botApiKey;
        private const string _botApiUrl = "https://api.icq.net/bot/v1/";

        public BotAPI _api = new BotAPI();

        ////    Main bot constructor
        public ICQBot(string token)
        {
            _botApiKey = token;
        }

        ////    API methods block 
        //  Self
        public string APISelfGet()
        {
            string response = SendRequest(_botApiUrl + "self/get?token=" + _botApiKey);
            //convert to obj;
            return null;
        }
        //  Messages
        public string APIMessagesSendText(string chatId, string text) // just text without formats, attachments and others
        {
            string response = SendRequest(_botApiUrl + "messages/sendText?chatId=" + chatId + "&text=" + HttpUtility.UrlEncode(text) + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }
        
        /* 
         * Here will be methods for message generator soon
         * Messages.SendFile    (GET,POST)
         * Messages.SendVoice   (GET,POST)
         */ 
        
        public string APIMessagesEditText(string chatId, int msgId, string text, string inlineKeyboardMarkup = null)
        {
            string response = SendRequest(_botApiUrl + "messages/sendText?chatId=" + chatId + "&msgId=" + msgId + "&text=" + HttpUtility.UrlEncode(text) + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIMessagesDeleteMessage(string chatId, int msgId)
        {
            string response = SendRequest(_botApiUrl + "messages/deleteMessages?chatId=" + chatId + "&msgId=" + msgId+ "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        // APIMessagesDeleteMessages for a few messages

        public string APIMessagesAnswerCallbackQuery(string queryId, string text, bool showAlert, string url)
        {
            string response = SendRequest(_botApiUrl + "messages/answerCallbackQuery?queryId=" + queryId + "&text=" + text + "&showAlert=" + showAlert.ToString() + "&url=" + url + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }
        //  Messages
        public string APIChatsMembersDelete(string chatId, string members)
        {
            string response = SendRequest(_botApiUrl + "chats/members/delete?chatId=" + chatId + "&members=" + members + "&token=" + _botApiKey);
            //convert to obj;
            return null;

        }

        public string APIChatsAvatarSet(string chatId, string image) // POSTnaya huynya
        {
            string response = SendRequest(_botApiUrl + "chats/avatar/set?chatId=" + chatId + "&token=" + _botApiKey + "&image=" /* + multipart */);
            //convert to obj;
            return null;
        }

        public string APIChatsSendActions(string chatId, string[] actions)
        {
            string response = SendRequest(_botApiUrl + "chats/sendActions?chatId=" + chatId + "&actions=" + actions + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsGetInfo(string chatId)
        {
            string response = SendRequest(_botApiUrl + "chats/getInfo?chatId=" + chatId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsGetAdmins(string chatId)
        {
            string response = SendRequest(_botApiUrl + "chats/getAdmins?chatId=" + chatId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsGetMembers(string chatId, string cursor = null)
        {
            string response = SendRequest(_botApiUrl + "chats/getMembers?chatId=" + chatId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsGetBlockedUsers(string chatId)
        {
            string response = SendRequest(_botApiUrl + "chats/getBlockedUsers?chatId=" + chatId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsGetPendingUsers(string chatId)
        {
            string response = SendRequest(_botApiUrl + "chats/getPendingUsers?chatId=" + chatId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsBlockUser(string chatId, string userId, bool delLastMassages = false)
        {
            string response = SendRequest(_botApiUrl + "chats/blockUser?chatId=" + chatId + "&userId=" + userId + "&delLastmessages=" + delLastMassages.ToString() + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsUnblockUser(string chatId, string userId, bool delLastMassages = false)
        {
            string response = SendRequest(_botApiUrl + "chats/unblockUser?chatId=" + chatId + "&userId=" + userId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsResolvePending(string chatId, bool approve, string userId)
        {
            string response = SendRequest(_botApiUrl + "chats/resolvePending?chatId=" + chatId + "&approve=" + approve.ToString() + "&userId=" + userId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsResolvePendingForAll(string chatId, bool approve)
        {
            string response = SendRequest(_botApiUrl + "chats/resolvePending?chatId=" + chatId + "&approve=" + approve.ToString() + "everyone=true&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsSetTitle(string chatId, string title)
        {
            string response = SendRequest(_botApiUrl + "chats/setTitle?chatId=" + chatId + "&title=" + HttpUtility.UrlEncode(title) + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsSetAbout(string chatId, string about)
        {
            string response = SendRequest(_botApiUrl + "chats/setAbout?chatId=" + chatId + "&about=" + HttpUtility.UrlEncode(about) + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsSetRules(string chatId, string rules)
        {
            string response = SendRequest(_botApiUrl + "chats/setRules?chatId=" + chatId + "&rules=" + HttpUtility.UrlEncode(rules) + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsPinMessage(string chatId, int msgId)
        {
            string response = SendRequest(_botApiUrl + "chats/pinMessage?chatId=" + chatId + "&msgId=" + msgId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }

        public string APIChatsUnpinMessage(string chatId, int msgId)
        {
            string response = SendRequest(_botApiUrl + "chats/unpinMessage?chatId=" + chatId + "&msgId=" + msgId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }
        //  Files
        public string APIFilesGetInfo(string fileId)
        {
            string response = SendRequest(_botApiUrl + "files/getInfo?fileId=" + fileId + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }
        //  Events
        public string APIEventsGet(int lastEventId, int pollTime)
        {
            string response = SendRequest(_botApiUrl + "events/get?lastEventId=" + lastEventId + "&pollTime=" + pollTime + "&token=" + _botApiKey);
            //convert to obj;
            return null;
        }


        ////    Network interract methods block
        public string SendRequest(string url)
        {
            Thread.Sleep(100);
            string web_response;
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    web_response = reader.ReadToEnd();
                }
                response.Close();
            }
            catch (WebException e)
            {
                //# Print("Method :: sendRequest :: Exception: " + e.Message + "; ServerResponse: " + e.Response, true, true);
                System.Console.WriteLine(e.StackTrace);
                return e.Message;
            }
            return web_response;
        }

        ////    Utils methods block


    }

    
}
