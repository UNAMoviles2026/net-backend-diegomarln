using reservations_api.Models.Entities;

namespace reservations_api.Repositories;

public interface IReservationRepository
{    
    Task<List<Reservation>> GetAllAsync();
    Task<Reservation?> GetByIdAsync(Guid id);   
    Task<Reservation> AddAsync(Reservation reservation);    
    Task<Reservation> DeleteAsync(Guid id);
}