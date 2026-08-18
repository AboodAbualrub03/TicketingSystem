using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TicktingSystem.Domain.Models
{
    public class TicketComment
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public DateTime CreatedAt  { get; set; }

        public int SenderId { get; set; }

        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }

        public User Sender { get; set; }

    }
}
