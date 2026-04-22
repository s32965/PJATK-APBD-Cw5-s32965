using Microsoft.AspNetCore.Mvc;
using Cw5.Models;
using Cw5.Enums;

namespace Cw5.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReservationsController : ControllerBase
{
    public static List<Reservation> Reservations =
    [
        new Reservation { Id = 1, RoomId = 1, OrganizerName = "John Doe", Topic = "AI Workshop", Date = new DateOnly(2026, 5, 10), StartTime = new TimeOnly(9, 0), EndTime = new TimeOnly(11, 0), Status = ReservationStatus.CONFIRMED },
        new Reservation { Id = 2, RoomId = 3, OrganizerName = "Jane Smith", Topic = "Budget Planning", Date = new DateOnly(2026, 5, 12), StartTime = new TimeOnly(13, 30), EndTime = new TimeOnly(15, 0), Status = ReservationStatus.PLANNED },
        new Reservation { Id = 3, RoomId = 2, OrganizerName = "Mark Johnson", Topic = "Team Retrospective", Date = new DateOnly(2026, 5, 14), StartTime = new TimeOnly(10, 0), EndTime = new TimeOnly(11, 45), Status = ReservationStatus.CANCELLED },
        new Reservation { Id = 4, RoomId = 1, OrganizerName = "Emily Davis", Topic = "Client Meeting", Date = new DateOnly(2026, 5, 15), StartTime = new TimeOnly(14, 0), EndTime = new TimeOnly(15, 30), Status = ReservationStatus.CONFIRMED }
    ];
    
    [HttpGet]
    public IActionResult GetAll()
    {
        if (Reservations.Count == 0)
        {
            return NotFound($"No rooms found");
        }
        
        return Ok(Reservations);
    }
}