using reservations_api.DTOs.Requests;
using reservations_api.DTOs.Responses;
using reservations_api.Models.Entities;

namespace reservations_api.Mappers;

public class ReservationMapper
{
    public static Reservation toEntity(CreateReservationRequest request)
    {
        return new Reservation
        {
            Id = Guid.NewGuid(),
            Date = request.Date,
            StartTime = request.StartTime,
            EndTime = request.EndTime,
            Classroom = new Classroom { Id = request.ClassroomId }
        };
    }

    public static ReservationResponse toResponse(Reservation reservation)
    {
        return new ReservationResponse
        {
            Id = reservation.Id,
            ClassroomId = reservation.Classroom.Id,
            Date = reservation.Date,
            StartTime = reservation.StartTime,
            EndTime = reservation.EndTime
        };
    }
}