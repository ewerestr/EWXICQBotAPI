using EWXICQBotAPI.Responses.AbstractResponses;
using EWXICQBotAPI.Responses.AbstractResponses.Substructs;
using System.Text.Json;

namespace EWXICQBotAPI.Types
{
    public class ICQUser
    {
        private ICQBot _instance;
        private string _userId;
        private string _firstName;
        private string _lastName;
        private bool _admin = false;
        private bool _creator = false;

        public ICQUser(ICQBot instance, ICQAUser absUser)
        {
            _instance = instance;
            _userId = absUser.userId;
            _firstName = absUser.firstName;
            _lastName = absUser.lastName;
            _admin = absUser.admin;
            _creator = absUser.creator;
        }

        // method block
        public bool SendMessage(string text)
        {
            ICQAActionResultResponse response = JsonSerializer.Deserialize<ICQAActionResultResponse>(_instance.SendRequest(_instance.GetRequestGenerator().MessagesSendText(_userId, text)));
            return response.ok;
        }

        // get/set block
        public string GetUserId()
        {
            return _userId;
        }

        public string GetFirstName()
        {
            return _firstName;
        }

        public string GetLastName()
        {
            return _lastName;
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        public bool IsAdmin() // deprecated
        {
            return _admin;
        }

        public bool IsCreator() // deprecated
        {
            return _creator;
        }
    }
}