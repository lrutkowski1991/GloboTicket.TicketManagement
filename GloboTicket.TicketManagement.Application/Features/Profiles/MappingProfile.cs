using AutoMapper;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVM>().ReverseMap();
            CreateMap<Event, EventDetailVM>().ReverseMap();
            CreateMap<Category, CategoryDto>();
        }
    }
}
