using System;
using Microsoft.AspNetCore.Mvc;
using StoreApiRest.Models;
using StoreApiRest.Repository;

namespace StoreApiRest.Controllers
{
    [ApiController]
    [Route("client")]
    public class ClienteController: ControllerBase
	{
        private readonly IClientRepository _clientRepository;

        public ClienteController(IClientRepository clientRepository)
        {
            this._clientRepository = clientRepository;
        }


        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> getClients()
        {
            var clients = await _clientRepository.GetAllClientsAsync();

            return Ok(clients);
        }



        [HttpPost]
        [Route("add")]
        public dynamic addClient(Client client)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");

            return Ok();
        }


    }
}

