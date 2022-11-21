using EWXICQBotAPI.Responses.AbstractResponses.Substructs;

namespace EWXICQBotAPI.Responses.AbstractResponses
{
    public class ICQASelfGetResponse
    {
        public bool ok { get; set; } = false;
        public string userId { get; set; }
        public string nick { get; set; }
        public string firstName { get; set; }
        public string about { get; set; }
        public ICQAPhoto[] photo { get; set; }
    }
}