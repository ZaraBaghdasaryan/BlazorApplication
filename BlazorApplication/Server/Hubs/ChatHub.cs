using BlazorApplication.Server.Data;
using Microsoft.AspNetCore.SignalR;

namespace BlazorApplication.Server.Hubs
{
    public class ChatHub : Hub
    {
        private readonly PreviousChatArchive previousChatArchive;

        public ChatHub(PreviousChatArchive previousChatArchive)
        {
            this.previousChatArchive = previousChatArchive;
        }
        public async Task SendMessage(string user, string message)
        {
            previousChatArchive.Chats.Add(new Shared.Data.ChatData {User = user, Message = message });
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
