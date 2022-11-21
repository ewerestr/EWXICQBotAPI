namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQAUser
    {
        public string userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nick { get; set; }
        public bool creator { get; set; } = false;  // chats.getAdmins, chats.getMembers
        public bool admin { get; set; } = false;  // chats.getAdmins
    }
}
