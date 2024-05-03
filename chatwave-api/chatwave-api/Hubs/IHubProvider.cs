using chatwave_api.Model;
using System.Threading.Tasks;

namespace chatwave_api.Hubs
{
    public interface IHubProvider
    {
        Task ReceivedMessage(Message message);
    }
}
