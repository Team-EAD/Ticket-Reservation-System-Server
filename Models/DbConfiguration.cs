namespace Ticket_Reservation_System_Server.Models
{
    public class DbConfiguration
    {

        public string CollectionName { get; set; }
        public string ConnectionURI { get; set; }
        public string DatabaseName { get; set; }
        public string? TravelersCollectionName { get; set; }
    }
}
