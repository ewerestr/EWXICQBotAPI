using System.Text.Json.Serialization;

namespace EWXICQBotAPI.Responses.AbstractResponses
{
    public class ICQAChatsGetInfoResponse
    {
        public bool ok { get; set; } = false;  // common
        public string type { get; set; }           // private, group, channel
        public string firstName { get; set; }           // private
        public string lastName { get; set; }           // private
        public string nick { get; set; }           // private
        public string about { get; set; }           // private, group, channel
        public bool isBot { get; set; }           // private
        public string language { get; set; }           // private
        public string title { get; set; }           // group, channel
        public string rules { get; set; }           // group, channel
        public string inviteLink { get; set; }           // group, channel
        [JsonPropertyName("public")]
        public bool isPublic { get; set; }           // group, channel
        public bool joinModeration { get; set; }           // group, channel
    }
}