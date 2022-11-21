namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQAEventPayload
    {
        public string msgId { get; set; }               // newMessage, editedMessage, deletedMessage, pinnedMessage, unpinnedMessage,
        public ICQAChat chat { get; set; }               // newMessage, editedMessage, deletedMessage, pinnedMessage, unpinnedMessage, newChatMembers, leftChatMembers, callbackQuery
        public ICQAUser from { get; set; }               // newMessage, editedMessage,                 pinnedMessage, callbackQuery
        public ICQAUser[] newMembers { get; set; }       // newChatMembers
        public ICQAUser addedBy { get; set; }            // newChatMembers
        public ICQAUser[] leftMembers { get; set; }      // leftChatMembers
        public ICQAUser removedBy { get; set; }          // leftChatMembers
        public ulong timestamp { get; set; }            // newMessage, editedMessage, deletedMessage, pinnedMessage, unpinnedMessage
        public string text { get; set; }                // newMessage, editedMessage,                 pinnedMessage,
        public ICQATextFormat format { get; set; }       // newMessage, editedMessage
        public ICQAEventPart[] parts { get; set; }       // newMessage, editedMessage
        public ulong editedTimestamp { get; set; }      // editedMessage
        public string queryId { get; set; }             // callbackQuery
        public ICQAMessage message { get; set; }         // callbackQuery
        public string callbackData { get; set; }        // callbackQuery
    }
}
