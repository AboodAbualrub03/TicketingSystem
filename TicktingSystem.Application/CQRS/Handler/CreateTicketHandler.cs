using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TicktingSystem.Application.CQRS.Command;
using TicktingSystem.Domain.Enums;
using TicktingSystem.Domain.Models;
using TicktingSystem.Domain.Repository;

namespace TicktingSystem.Application.CQRS.Handler
{
    public class CreateTicketHandler : IRequestHandler<CreateTicketCommand, int>
    {
        private readonly IGenericRepository<Ticket> _ticketRepository;

        public CreateTicketHandler(IGenericRepository<Ticket> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task<int> Handle(CreateTicketCommand request, CancellationToken cancellationToken)
        {
            int responseMinutes = request.Priority switch
            {
               TicketPriority.Critical=>15,
               TicketPriority.High=>60,
               TicketPriority.Medium=>240,
               TicketPriority.Low=>1440,
               _=>1440
             
            };
            int resolutionMinutes = request.Priority switch
            {
                TicketPriority.Critical =>  240,
                TicketPriority.High => 480,
                TicketPriority.Medium => 1440,
                TicketPriority.Low => 4320,
                _ => 1440
            };

            var now = DateTime.UtcNow;
            var ticket = new Ticket { 
            
              Title = request.Title,
              Description = request.Description,
              CategoryId = request.CategoryId,
              Priority = request.Priority,
              Status = TicketStatus.Open,
              CreatedAt = now,
              ResponseDueAt = now.AddMinutes(responseMinutes),
              ResolutionDueAt = now.AddMinutes(resolutionMinutes),
              
              CustomerId = request.CustomerId,
            };
            await _ticketRepository.Add(ticket);
            return ticket.Id;
        }
    }
}
