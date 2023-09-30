using Microsoft.AspNetCore.Mvc;
using Ticket_Reservation_System_Server.Models;
using Ticket_Reservation_System_Server.Services;

namespace Ticket_Reservation_System_Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TicketReservationController: ControllerBase
    {


        private readonly ITicketReservationService _ticketReservationService;


        public TicketReservationController(ITicketReservationService ticketReservationService)
        {
            _ticketReservationService = ticketReservationService;
        }


        // GET: api/TicketReservation
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var reservation = await _ticketReservationService.GetAllAsyc();
            return Ok(reservation);
        }

        // GET api/TicketReservation/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var reservation = await _ticketReservationService.GetById(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return Ok(reservation);
        }

        // POST api/TicketReservation
        [HttpPost]
        public async Task<IActionResult> Post(TicketReservation ticketReservation)
        {
            await _ticketReservationService.CreateAsync(ticketReservation);
            return Ok("created successfully");
        }

        // PUT api/TicketReservation/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] TicketReservation newTicketReservation)
        {
            var reservation = await _ticketReservationService.GetById(id);
            if (reservation == null)
                return NotFound();
            await _ticketReservationService.UpdateAsync(id, newTicketReservation);
            return Ok("updated successfully");
        }

        // DELETE api/TicketReservation/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var reservation = await _ticketReservationService.GetById(id);
            if (reservation == null)
                return NotFound();
            await _ticketReservationService.DeleteAysnc(id);
            return Ok("deleted successfully");
        }



    }
}
