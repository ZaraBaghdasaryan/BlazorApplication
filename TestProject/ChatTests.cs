using BlazorApplication.Server.Controllers;
using BlazorApplication.Server.Hubs;
using Xunit;

namespace TestProject
{
    public class ChatTests

        /// <summary>
        /// CanReturnPreviousChats method is an XUnit test 
        /// that is testing whether or not archived tests can be returned and displayed for the new users
        /// </summary>
    {
        [Fact]
        public void CanReturnPreviousChats()
        {
            var controller = new ChatController();

            var result = controller.Get();

            Assert.NotNull(result);
        }

        /// <summary>
        /// CanSendMessage method is an XUnit test 
        /// that is testing whether or not chat information can be added to chat archive 
        /// and displayed for new users in the platform
        /// </summary>
        [Fact]
        public void CanSendMessage() 
        {
            var chatHub = new ChatHub();

            var result = chatHub.SendMessage("", ""); 

            Assert.NotNull(result);
        }
    }
} 