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

        public ChatController(PreviousChatArchive previousChatArchive)
        {
            this.previousChatArchive = previousChatArchive;
        }

        [HttpGet]
        public IEnumerable<ChatData> Get()
        {
            return new List<ChatData>{ new ChatData { User = "Me", Message = "Hi!"} };
        }
    }

}
