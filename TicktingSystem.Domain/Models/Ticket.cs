using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TicktingSystem.Domain.Enums;

namespace TicktingSystem.Domain.Models
{
    public class Ticket
    {

        public int Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }
    

        public TicketStatus Status { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public int  CustomerId { get; set; }


        public int? AgentId { get; set; }
        public TicketPriority Priority { get; set; }
        public DateTime? ResolvedAt { get; set; }
        public DateTime? FirstRespondedAt { get; set; }
       public DateTime ResponseDueAt { get; set; }
        public DateTime ResolutionDueAt { get; set; }

        public DateTime CreatedAt { get; set; }
        public User Customer { get; set; }
        public User Agent { get; set; }

        public ICollection<TicketComment> TicketComments { get; set; }



       
    }
  
  
}
