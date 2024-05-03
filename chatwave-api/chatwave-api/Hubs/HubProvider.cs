using chatwave_api.Model;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace chatwave_api.Hubs
{
    public class HubProvider : Hub<IHubProvider>
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.ReceivedMessage(message);
        }
    }
}
