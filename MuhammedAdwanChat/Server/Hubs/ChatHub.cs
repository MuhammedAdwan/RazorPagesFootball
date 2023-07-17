using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MuhammedAdwanChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        
        public async Task UserTyping(string user)
        {
            await Clients.Others.SendAsync("UserTyping", user);
        }
        
        public async Task AMessage(string user)
        {
            await Clients.All.SendAsync("AMessageReceived", user);
        }


    }
}