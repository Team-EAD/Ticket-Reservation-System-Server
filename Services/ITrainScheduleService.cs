using Ticket_Reservation_System_Server.Models;

namespace Ticket_Reservation_System_Server.Services
{
    public interface ITrainScheduleService
    {
        Task<IEnumerable<TrainSchedule>> GetAllAsyc();
        Task<TrainSchedule> GetById(string id);
        Task CreateAsync(TrainSchedule trainSchedule);
        Task UpdateAsync(string id, TrainSchedule trainSchedule);
        Task DeleteAysnc(string id);

        Task PublishTrainSchedule(String id);




    }
}
