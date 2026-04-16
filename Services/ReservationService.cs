using reservations_api.DTOs.Entities;
using reservations_api.DTOs.Requests;
using reservations_api.DTOs.Responses;
using reservations_api.Mappers;
using reservations_api.Repositories;

namespace reservations_api.Services;

public class ReservationService : IReservationService
{
    private readonly IReservationRepository _reservationRepository;

    public ReservationService(IReservationRepository reservationRepository, IClassroomRepository classroomRepository)
    {
        _reservationRepository = reservationRepository;        
    }

    public Task<ReservationResponse> CreateAsync(CreateReservationRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<ReservationResponse> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}