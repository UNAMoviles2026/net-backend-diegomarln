using reservations_api.Models.Entities;

namespace reservations_api.Repositories;

public interface IReservationRepository
{          
    Task<Reservation> AddAsync(Reservation reservation);    
    Task<Reservation?> DeleteAsync(Guid id);
}