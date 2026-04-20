using Microsoft.AspNetCore.Mvc;
using Cw5.Models;

namespace Cw5.Controllers;

[ApiController]
[Route("api/[controller]")]

public class RoomsControler : ControllerBase
{
    public static List<Room> Rooms =
    [
        new Room
        {
            Id = 1,
            BuildingCode = "A",
            Capacity = 100,
            Floor = 1,
            HasProjector = false,
            IsActive = true,
            Name = "room1"
        },
        new Room
        {
            Id = 2,
            BuildingCode = "B",
            Capacity = 50,
            Floor = 2,
            HasProjector = true,
            IsActive = false,
            Name = "room2"
        },
        new Room
        {
            Id = 3,
            BuildingCode = "C",
            Capacity = 25,
            Floor = 3,
            HasProjector = true,
            IsActive = true,
            Name = "room3"
        }
    ];

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Rooms);
    }
}