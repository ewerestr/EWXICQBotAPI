using EWXICQBotAPI.Responses.AbstractResponses;
using EWXICQBotAPI.Types;

namespace EWXICQBotAPI.Responses
{
    public class ICQChatsGetInfoResponse
    {
        // service fields
        private ICQBot _instance;

        // common fields
        private bool _status;
        private ICQChatType _chattype;
        private string _about;
        private string _chatId;

        // Chat.Private fields
        private string _firstname;
        private string _lastname;
        private string _username;
        private bool _bot;
        private string _language;


        // Chat.Group & Chat.Channel fields
        private string _chatTitle;
        private string _chatRules;
        private string _chatInviteLink;
        private bool _public;
        private bool _moderation;

        public ICQChatsGetInfoResponse(ICQBot instance, ICQAChatsGetInfoResponse abstractResponse, string chatId)
        {
            _instance = instance;
            _status = abstractResponse.ok;
            _chattype = abstractResponse.type.Equals("private") ? ICQChatType.Private : (abstractResponse.type.Equals("group") ? ICQChatType.Group : ICQChatType.Channel);
            if (_chattype.Equals(ICQChatType.Private))
            {
                _firstname = abstractResponse.firstName;
                _lastname = abstractResponse.lastName;
                _username = abstractResponse.nick;
                _about = abstractResponse.about;
                _bot = abstractResponse.isBot;
                _language = abstractResponse.language;
            }
            else
            {
                _about = abstractResponse.about;
                _chatTitle = abstractResponse.title;
                _chatRules = abstractResponse.rules;
                _chatInviteLink = abstractResponse.inviteLink;
                _public = abstractResponse.isPublic;
                _moderation = abstractResponse.joinModeration;
            }
            _chatId = chatId;
        }

        public bool GetStatus()
        {
            return _status;
        }

        public ICQChatType GetChatType()
        {
            return _chattype;
        }

        public string GetAbout()
        {
            return _about;
        }

        public string GetFirstname()
        {
            return _firstname;
        }

        public string GetLastname()
        {
            return _lastname;
        }

        public string GetFullname()
        {
            return _firstname + " " + _lastname;
        }

        public string GetUsername()
        {
            return _username;
        }

        public bool IsBot()
        {
            return _bot;
        }

        public string GetLanguage()
        {
            return _language;
        }

        public string GetChatTitle()
        {
            return _chatTitle;
        }

        public string GetChatRules()
        {
            return _chatRules;
        }

        public string GetChatInviteLink()
        {
            return _chatInviteLink;
        }

        public bool IsPublic()
        {
            return _public;
        }

        public bool IsJoinModeration()
        {
            return _moderation;
        }

        public ICQChat ToICQChat()
        {
            if (_chattype.Equals(ICQChatType.Private))
                return new ICQChat(
                    _chattype,
                    _chatId,
                    _firstname,
                    _lastname,
                    _username,
                    _language,
                    _bot
                );

            //ICQChat(ICQChatType chatType, string aboutChat, string chatTitle, string chatRules, string chatInviteLink, bool isChatPublic, bool isJoinModeration)
            return new ICQChat(
                _chattype,
                _chatId,
                _about,
                _chatTitle,
                _chatRules,
                _chatInviteLink,
                _public,
                _moderation
            );
        }
    }
}