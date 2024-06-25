using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using VehicleAPI.Models;
using VehicleAPI.Services;

namespace VehicleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly VehicleRepository _vehicleRepository;

        public VehiclesController(VehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        [HttpGet("cars/color/{color}")]
        public IActionResult GetCarsByColor(string color)
        {
            var cars = _vehicleRepository.GetCarsByColor(color);
            if (!cars.Any())
            {
                return NotFound();
            }
            return Ok(cars);
        }

        [HttpGet("buses/color/{color}")]
        public IActionResult GetBusesByColor(string color)
        {
            var buses = _vehicleRepository.GetBusesByColor(color);
            if (!buses.Any())
            {
                return NotFound();
            }
            return Ok(buses);
        }

        [HttpGet("boats/color/{color}")]
        public IActionResult GetBoatsByColor(string color)
        {
            var boats = _vehicleRepository.GetBoatsByColor(color);
            if (!boats.Any())
            {
                return NotFound();
            }
            return Ok(boats);
        }

        [HttpGet("planes/modelyear/{modelYear}")]
        public IActionResult GetPlanesByModelYear(int modelYear)
        {
            var planes = _vehicleRepository.GetPlanesByModelYear(modelYear);
            if (!planes.Any())
            {
                return NotFound();
            }
            return Ok(planes);
        }

        [HttpPost("cars/{id}/headlights")]
        public IActionResult ToggleCarHeadlights(int id, [FromBody] bool turnOn)
        {
            var car = _vehicleRepository.GetAllCars().FirstOrDefault(c => c.Id == id);
            if (car == null)
            {
                return NotFound($"Car with ID {id} not found");
            }

            car.HeadlightsOn = turnOn;
            return Ok($"Headlights {(turnOn ? "turned on" : "turned off")} for car with ID {id}");
        }

        [HttpDelete("cars/{id}")]
        public IActionResult DeleteCar(int id)
        {
            _vehicleRepository.DeleteCar(id);
            return NoContent();
        }
        [HttpDelete("buses/{id}")]
        public IActionResult DeleteBus(int id)
        {
            _vehicleRepository.DeleteBus(id);
            return NoContent();
        }
        [HttpDelete("boats/{id}")]
        public IActionResult DeleteBoat(int id)
        {
            _vehicleRepository.DeleteBoat(id);
            return NoContent();
        }
        [HttpDelete("planes/{id}")]
        public IActionResult DeletePlane(int id)
        {
            _vehicleRepository.DeletePlane(id);
            return NoContent();
        }


        [HttpPost("cars")]
        public IActionResult AddCar([FromBody] Car car)
        {
            if (car == null)
            {
                return BadRequest("Car object is null");
            }

            _vehicleRepository.AddCar(car);

            return CreatedAtAction(nameof(GetAllCars), new { id = car.Id }, car);
        }
        [HttpPost("buses")]
        public IActionResult AddBus([FromBody] Bus bus)
        {
            if (bus == null)
            {
                return BadRequest("Bus object is null");
            }

            _vehicleRepository.AddBus(bus);

            return CreatedAtAction(nameof(GetAllBuses), new { id = bus.Id }, bus);
        }

        [HttpPost("planes")]
        public IActionResult AddPlane([FromBody] Plane plane)
        {
            if (plane == null)
            {
                return BadRequest("Plane object is null");
            }

            _vehicleRepository.AddPlane(plane);

            return CreatedAtAction(nameof(GetAllPlanes), new { id = plane.Id }, plane);
        }

        [HttpPost("boats")]
        public IActionResult AddBoat([FromBody] Boat boat)
        {
            if (boat == null)
            {
                return BadRequest("Boat object is null");
            }

            _vehicleRepository.AddBoat(boat);

            return CreatedAtAction(nameof(GetAllBoats), new { id = boat.Id }, boat);
        }


        [HttpGet("all")]
        public IActionResult GetAllVehicles()
        {
            var vehicles = _vehicleRepository.GetAllVehicles();
            return Ok(vehicles);
        }

        [HttpGet("cars")]
        public IActionResult GetAllCars()
        {
            var cars = _vehicleRepository.GetAllCars();
            return Ok(cars);
        }

        [HttpGet("buses")]
        public IActionResult GetAllBuses()
        {
            var buses = _vehicleRepository.GetAllBuses();
            return Ok(buses);
        }

        [HttpGet("boats")]
        public IActionResult GetAllBoats()
        {
            var boats = _vehicleRepository.GetAllBoats();
            return Ok(boats);
        }

        [HttpGet("planes")]
        public IActionResult GetAllPlanes()
        {
            var planes = _vehicleRepository.GetAllPlanes();
            return Ok(planes);
        }

        [HttpGet("sorted/modelyear")]
        public IActionResult GetAllVehiclesSortedByModelYear()
        {
            var vehicles = _vehicleRepository.GetAllVehiclesSortedByModelYear();
            return Ok(vehicles);
        }

        [HttpGet("color/{color}")]
        public IActionResult GetVehiclesByColor(string color)
        {
            var vehicles = _vehicleRepository.GetVehiclesByColor(color);
            if (!vehicles.Any())
            {
                return NotFound();
            }
            return Ok(vehicles);
        }
    }
}
