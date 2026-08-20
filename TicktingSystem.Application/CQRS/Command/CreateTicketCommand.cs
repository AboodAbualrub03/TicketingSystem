using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TicktingSystem.Domain.Enums;

namespace TicktingSystem.Application.CQRS.Command
{
    public class CreateTicketCommand:IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public int CategoryId { get; set; }

        public TicketPriority Priority { get; set; }
        public int CustomerId { get; set; }

    }
}
