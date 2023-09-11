using ChatLearning.Models;
using Microsoft.AspNetCore.SignalR;

namespace ChatLearning.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(Message message) => 
            await Clients.All.SendAsync("ReceiveMessage", message);
            //await Clients.Users.SendMessageAsync(message);
    }
}
