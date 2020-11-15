using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using WebApplication8.Data;
using WebApplication8.Models;

namespace WebApplication8.Hubs
{
    [Authorize]
    public class MessageHub:Hub
    {
        private ApplicationDbContext _uctx;
        private DataContext _ctx;
        public MessageHub(ApplicationDbContext uctx,DataContext ctx)
        {
            _uctx = uctx;
            _ctx = ctx;
        }
        public async Task Send(Message msg)
        {
            var userName = Context.User.Identity.Name;
            msg.From = userName;
            if (Context.UserIdentifier != msg.To)
                await Clients.User(Context.UserIdentifier).SendAsync("Receive",msg);
            await this.Clients.User(msg.To).SendAsync("Receive",msg);
        }
    }
}
