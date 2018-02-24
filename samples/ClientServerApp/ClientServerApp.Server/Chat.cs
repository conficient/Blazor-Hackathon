using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace ClientServerApp.Server
{
    public class Chat : Hub
    {
        public const string SEND_COMMAND = "Send";

        public Task Send(string message)
        {
            return Clients.All.InvokeAsync(SEND_COMMAND, message);
        }
    }
}
