using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Types
{
    class ICQChatUser : ICQUser
    {
        private bool _admin = false;
        private bool _creator = false;

        public ICQChatUser(ICQBot instance, ICQAUser absUser)
            : base(instance, absUser)
        {
            _admin = absUser.admin;
            _creator = absUser.creator;
        }

        // get/set block
        public new bool IsAdmin() // deprecated
        {
            return _admin;
        }

        public new bool IsCreator() // deprecated
        {
            return _creator;
        }
    }
}