namespace reservations_api.DTOs.Entities;

public class ReservationResponse
{
    public Guid Id { get; set; }
    public Guid ClassroomId { get; set; }
    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }     
    public TimeOnly EndTime { get; set; }
}