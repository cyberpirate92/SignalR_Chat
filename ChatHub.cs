using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR_Chat
{
    public class ChatHub : Hub
    {
        public Task SendChatMessage(string username, string message)
        {
            return Clients.All.SendAsync("ReceiveChatMessage", username, message);
        }
    }
}