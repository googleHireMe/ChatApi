using Microsoft.AspNetCore.SignalR;
using SignalrChat.Models;
using System.Threading.Tasks;

namespace SignalrChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
