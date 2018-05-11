using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Api
{
    public class SignalRHub: Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}