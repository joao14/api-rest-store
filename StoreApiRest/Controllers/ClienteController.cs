using System;
using Microsoft.AspNetCore.Mvc;
using StoreApiRest.Models;

namespace StoreApiRest.Controllers
{
    [ApiController]
    [Route("client")]
    public class ClienteController: ControllerBase
	{

        [HttpGet]
        [Route("list")]
        public dynamic getClients()
        {
            List<Client> clients = new List<Client>
            {
                new Client
                {
                    id= "1",
                    correo="alexmerino67@gmail.com",
                    edad="20",
                    nombre="Alexander Merino"
                },

                new Client
                {
                    id= "2",
                    correo="barcealex1014@hotmail.com",
                    edad="25",
                    nombre="Miguel Merino"
                }
            };

            return clients;
        }


    }
}

