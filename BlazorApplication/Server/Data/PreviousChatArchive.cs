using BlazorApplication.Shared.Data;

namespace BlazorApplication.Server.Data
{
    public class PreviousChatArchive
    {
        public List<ChatData> Chats { get; set; } = new List<ChatData>();
    }
}
