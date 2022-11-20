
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
            string response = SendRequest(_botApiUrl + "messages/sendText?text=" + HttpUtility.UrlEncode(text) + "&token=" + _botApiKey);
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
            string response = SendRequest(_botApiUrl + "messages/sendText?text=" + HttpUtility.UrlEncode(text) + "&token=" + _botApiKey);
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
