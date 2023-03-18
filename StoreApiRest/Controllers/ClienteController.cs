using System;
using Microsoft.AspNetCore.Mvc;
using StoreApiRest.Datos;
using StoreApiRest.Models;
using StoreApiRest.Models.Dto;

namespace StoreApiRest.Controllers
{

    [Route("client/")]
    [ApiController]
    public class ClienteController: ControllerBase
	{
        private readonly ILogger<ClienteController> _logger;
        private readonly ApplicationDbContext _db;

        public ClienteController(ILogger<ClienteController> logger, ApplicationDbContext db)
        {
            this._logger = logger;
            this._db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ClientDto>> GetAllClients()
        {

            return Ok(_db.Clients.ToList());
        }


        [HttpGet("{id}",Name = "GetClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ClientDto> GetClient(string id)
        {
            
            if (int.Parse(id) <= 0) {
                _logger.LogError("Error al traer un cliente con Id"+id);
                return BadRequest();
            }

            Client? client = _db.Clients.FirstOrDefault(client => client.Id == id.ToString());

            if (client==null) {
                return NotFound();
            }

            return Ok(client);
        }



        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ClientDto> AddClient([FromBody] ClientDto clientDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(_db.Clients.FirstOrDefault(client=> client.Nombre.ToLower() == clientDto.Nombre.ToLower()) !=null)
            {
                ModelState.AddModelError("NameExists", "The client with this name already exists");
                return BadRequest(ModelState);
            }

            if(clientDto==null)
            {
                return BadRequest(clientDto);
            }

            Client client = new()
            {
                Nombre = clientDto.Nombre,
                Edad = clientDto.Edad,
                Correo = clientDto.Correo
            };

            _db.Clients.Add(client);
            _db.SaveChanges();

            Client? client_=_db.Clients.FirstOrDefault(client => client.Nombre == clientDto.Nombre);

            return Ok(client_);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteClient(string id)
        {
            if (id==null)
            {
                return BadRequest();
            }

            Client? client = _db.Clients.FirstOrDefault(client => client.Id == id);

            if (client==null) {
                return NotFound();
            }

            _db.Clients.Remove(client);
            _db.SaveChanges();

            return NoContent();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateClient(string id, [FromBody] ClientDto clientDto)
        {
            if (clientDto == null) {
                return BadRequest();
            }

            Client client = new()
            {
                Id = id,
                Nombre = clientDto.Nombre,
                Edad = clientDto.Edad,
                Correo = clientDto.Correo
            };

            _db.Clients.Update(client);
            _db.SaveChanges();

            return NoContent();
        }


    }
}

