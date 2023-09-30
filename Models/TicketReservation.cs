using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Ticket_Reservation_System_Server.Models
{
    public class TicketReservation
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("referenceID")]
        public string ReferenceID { get; set; }

        [BsonElement("reservationDate")]
        public DateTime ReservationDate { get; set; }

        [BsonElement("tripDate")]
        public DateTime TripDate { get; set; }

        [BsonElement("numberOfTicktes")]
        public int NumberOfTickets { get; set; }

        [BsonElement("departureLocation")]
        public string DepartureLocation { get; set; }

        [BsonElement("destination")]
        public string Destination { get; set; }

        [BsonElement("price")]
        public string Price { get; set; }

    }
}
