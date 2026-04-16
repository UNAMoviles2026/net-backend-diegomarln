using Microsoft.AspNetCore.Mvc;
using reservations_api.DTOs.Requests;
using reservations_api.Services;

namespace reservations_api.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ReservationsController : ControllerBase
{
    private readonly IReservationService _reservationService;    
    public ReservationsController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        var reservation = await _reservationService.DeleteAsync(id);
        if (reservation is null)
        {
            return NotFound();
        }
        return NoContent();
    }
}