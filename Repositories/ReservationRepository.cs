using Microsoft.EntityFrameworkCore;
using reservations_api.Data;
using reservations_api.DTOs.Responses;
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

    public async Task<Reservation?> DeleteAsync(Guid id)
    {
        var reservation = await _context.Reservations
        .Include(r => r.Classroom)
        .FirstOrDefaultAsync(r => r.Id == id);           
           

        if (reservation is null)
        {
            return null;
        }

        _context.Reservations.Remove(reservation);
        await _context.SaveChangesAsync();
        return reservation;
    }

    public async Task<List<Reservation>> GetByDateAsync(DateOnly date)
    {
        return await _context.Reservations
        .Include(r => r.Classroom)
        .Where(r => r.Date == date)
        .ToListAsync();
    }
}