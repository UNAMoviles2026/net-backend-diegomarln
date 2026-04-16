using Microsoft.EntityFrameworkCore;
using reservations_api.Data;
using reservations_api.Models.Entities;

namespace reservations_api.Repositories;

public class ReservationRepository : IReservationRepository
{
    private readonly AppDbContext _context;

    public ReservationRepository(AppDbContext context)
    {
        _context = context;
    }  

    public async Task<Reservation> AddAsync(Reservation reservation)
    {
        await _context.Reservations.AddAsync(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }

    public async Task<Reservation> DeleteAsync(Guid ui)
    {
        var reservation = await _context.Reservations
            .FirstOrDefaultAsync(reservation => reservation.Id == ui);

        if (reservation is null)
        {
            throw new Exception("Reservation not found");
        }

        _context.Reservations.Remove(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }
}