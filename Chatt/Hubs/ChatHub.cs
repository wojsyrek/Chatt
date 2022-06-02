using Microsoft.AspNetCore.SignalR;

namespace Chatt.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message, string sender)
        {
            await Clients.All.SendAsync("ReceiveMessage", message, sender);
        }
    }
}
