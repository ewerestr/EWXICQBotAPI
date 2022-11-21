namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQAPartPayload
    {
        public string fileId { get; set; }          // sticker, voice, file

        public string userId { get; set; }          // mention
        public string firstName { get; set; }       // mention
        public string lastName { get; set; }        // mention

        public string type { get; set; }            // file
        public string caption { get; set; }         // file
        public ICQATextFormat format { get; set; }   // file

        public ICQAMessage message { get; set; }     // forward, reply
    }
}
