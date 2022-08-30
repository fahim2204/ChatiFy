using ChatiFy.Hubs.Clients;
using ChatiFy.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatiFy.Hubs
{
    public class ChatHub:Hub<IChatClient>
    {
      
    }
}
