using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace GroupChatServiceWithSignalR.Models
{
    public class CustomerUserIdProvider : IUserIdProvider
    {
        public string? GetUserId(HubConnectionContext connection)
        {
            return connection.User?.FindFirst(ClaimTypes.Email)?.Value;
        }
    }
}
