namespace EWXICQBotAPI.Responses.AbstractResponses.Substructs
{
    public class ICQATextFormat
    {
        public ICQAFormatData[] bold { get; set; }
        public ICQAFormatData[] italic { get; set; }
        public ICQAFormatData[] underline { get; set; }
        public ICQAFormatData[] strikethrough { get; set; }
        public ICQAFormatData[] link { get; set; }
        public ICQAFormatData[] mention { get; set; }
        public ICQAFormatData[] inline_code { get; set; }
        public ICQAFormatData[] pre { get; set; }
        public ICQAFormatData[] ordered_list { get; set; }
        public ICQAFormatData[] unordered_list { get; set; }
        public ICQAFormatData[] quote { get; set; }
    }
}
