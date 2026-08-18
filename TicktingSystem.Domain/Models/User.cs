using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TicktingSystem.Domain.Models
{
    public class User:IdentityUser<int>
    {
        public string? FullName { get; set; }

        
        public ICollection<Ticket> AgentTickets { get; set; }
        public ICollection<Ticket> CustomerTickets { get; set; }

        public ICollection<TicketComment> TicketComments { get; set; } 


    }
}
