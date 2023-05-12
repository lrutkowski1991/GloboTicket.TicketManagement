namespace GloboTicket.TicketManagement.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = String.Empty;
        public ICollection<Event>? Events { get; set; }
    }
}