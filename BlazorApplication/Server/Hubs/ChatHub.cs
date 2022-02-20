using BlazorApplication.Server.Data;
using Microsoft.AspNetCore.SignalR;

namespace BlazorApplication.Server.Hubs
{
    public class ChatHub : Hub
    {
        private readonly PreviousChatArchive previousChatArchive;

        public ChatHub()
        {
        }

        public ChatHub(PreviousChatArchive previousChatArchive)
        {
            this.previousChatArchive = previousChatArchive;
        }

        /// <summary>
        ///SendMessage method is an asynchronous task that allows us to add chat information 
        ///to chat archive and display it for new users in the platform
        ///through SendAsync method 
        /// </summary>
        /// 
        public async Task SendMessage(string user, string message)
        {
            previousChatArchive.Chats.Add(new Shared.Data.ChatData {User = user, Message = message });
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
