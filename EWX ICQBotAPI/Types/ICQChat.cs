namespace EWXICQBotAPI.Types
{
    public class ICQChat
    {
        // common vars
        private ICQChatType _chatType;
        private string _chatId;

        // chat.private vars
        private string _endsideFirstname;
        private string _endsideLastname;
        private string _endsideUsername;
        private string _endsideLanguage;
        private bool _endsideBot;

        // chat.group/channel vars
        private string _aboutChat;
        private string _chatTitle;
        private string _chatRules;
        private string _chatInviteLink;
        private bool _isChatPublic;
        private bool _isJoinModeration;

        // chat.private constructor
        public ICQChat(ICQChatType chatType, string chatId, string firstname, string lastname, string username, string language, bool isBot)
        {
            _chatType = chatType;
            _chatId = chatId;
            _endsideUsername = username;
            _endsideFirstname = firstname;
            _endsideLastname = lastname;
            _endsideLanguage = language;
            _endsideBot = isBot;
        }

        // chat.group/channel constructor
        public ICQChat(ICQChatType chatType, string chatId, string aboutChat, string chatTitle, string chatRules, string chatInviteLink, bool isChatPublic, bool isJoinModeration)
        {
            _chatType = chatType;
            _chatId = chatId;
            _aboutChat = aboutChat;
            _chatTitle = chatTitle;
            _chatRules = chatRules;
            _chatInviteLink = chatInviteLink;
            _isChatPublic = isChatPublic;
            _isJoinModeration = isJoinModeration;
        }

        // common getters

        public ICQChatType GetChatType()
        {
            return _chatType;
        }

        public string GetChatTypeAsString()
        {
            return _chatType.ToString();
        }

        public string GetChatID()
        {
            return _chatId;
        }

        public string GetChatName()
        {
            return _chatType == ICQChatType.Private ? _endsideUsername : _chatTitle;
        }

        // private chat getters

        public string GetUserFirstname()
        {
            return _endsideFirstname;
        }

        public string GetUserLastname()
        {
            return _endsideLastname;
        }

        public string GetUsername()
        {
            return _endsideUsername;
        }

        public string GetUserLanguage()
        {
            return _endsideLanguage;
        }

        public bool IsBot()
        {
            return _endsideBot;
        }

        // group/channel getters

        public string GetDescription()
        {
            return _aboutChat;
        }

        public string GetTitle()
        {
            return _chatTitle;
        }

        public string GetRules()
        {
            return _chatRules;
        }

        public string GetInvitationLink()
        {
            return _chatInviteLink;
        }

        public bool IsPublic()
        {
            return _isChatPublic;
        }

        public bool IsUnderModeration()
        {
            return _isJoinModeration;
        }

        //
        public void DeleteMember() { } // few overloads

        public void SetAvatar() { } // group and channel

        public void GetInfo() { }

        public void GetAdmins() { }  // group and channel

        public void GetMembers() { } // group and channel

        public void GetBlockedUsers() { } // group and channel

        public void GetPendingUsers() { } // group and channel

        public void BlockUser() { }

        public void UnblockUser() { }

        public void ResolvePending() { }

        public void SetTitle() { }

        public void SetAbout() { }

        public void SetRules() { }

        public void PinMessage() { }

        public void UnpinMessage() { }

        public void SendActions() { }

        public void SendText() { }

        public void SendFile() { }

        public void SendVoice() { }

        public void EditText() { }

        public void DeleteMessages() { }

        // public void AnswerCallbackQuery() { }
    }
}