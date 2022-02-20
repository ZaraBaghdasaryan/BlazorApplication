using BlazorApplication.Server.Data;
using BlazorApplication.Shared.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApplication.Server.Controllers
{  
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly PreviousChatArchive previousChatArchive;

        public ChatController()
        {
        }

        public ChatController(PreviousChatArchive previousChatArchive)
        {
            this.previousChatArchive = previousChatArchive;
        }


        /// <summary>
        /// HTTP Get request recives information on previous chat data, i.e: user name and message 
        /// We use IEnumerable to loop over generic chat lists 
        /// </summary>

        [HttpGet]
        public IEnumerable<ChatData> Get()
        {
            return previousChatArchive.Chats;
        }
    }

}
