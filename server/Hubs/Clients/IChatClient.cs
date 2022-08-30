using ChatiFy.Models;
using System.Threading.Tasks;

namespace ChatiFy.Hubs.Clients
{
    public interface IChatClient
    {
        Task ReceiveMessage(ChatMessage message);
    }
}
