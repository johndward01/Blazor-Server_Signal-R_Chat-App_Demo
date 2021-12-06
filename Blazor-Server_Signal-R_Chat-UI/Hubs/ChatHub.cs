using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Blazor_Server_Signal_R_Chat_UI.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    
    }
}
