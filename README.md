# Support & Ticketing System

A support ticketing system that lets customers open tickets for their issues and track them, while agents resolve those tickets within defined time limits (SLA). Built with ASP.NET Core 8 following Clean Architecture principles.

## Features

- **Ticket Management** — create, track, and manage support tickets with statuses and priorities
- **SLA Tracking** — automatic response and resolution deadlines based on ticket priority
- **Role-Based Access** — three roles: Customer, Agent, and Admin, each with different permissions
- **Real-Time Notifications** *(in progress)* — instant updates via SignalR
- **Background SLA Monitoring** *(in progress)* — Hangfire jobs that detect and escalate overdue tickets

## Tech Stack

- **ASP.NET Core 8** (Web API)
- **Entity Framework Core** with **PostgreSQL**
- **ASP.NET Core Identity** for authentication and authorization
- **Clean Architecture** (4-layer separation)
- **CQRS / MediatR** *(planned)*
- **SignalR** *(planned)* — real-time notifications
- **Hangfire** *(planned)* — background jobs
- **Redis** *(planned)* — caching and rate limiting

## Architecture

The project follows Clean Architecture with a one-directional dependency flow (outer layers depend on inner layers):

- **Domain** — entities, enums, and repository interfaces. No dependencies on other layers.
- **Application** — DTOs, business logic, and CQRS handlers.
- **Infrastructure** — EF Core DbContext, repositories, and external services.
- **Api** — controllers and the entry point (presentation layer).

## Getting Started

### Prerequisites

- .NET 8 SDK
- PostgreSQL

### Steps

1. Clone the repository:git clone https://github.com/AboodAbualrub03/TicketingSystem.git
2. Update the connection string in `appsettings.json` with your PostgreSQL credentials.
3. Apply the database migrations (from the Package Manager Console):Update-Database

4. Run the project.

## Status

🚧 This project is under active development. Core domain modeling, database setup, and Identity integration are complete. CQRS handlers, controllers, and real-time features are in progress.