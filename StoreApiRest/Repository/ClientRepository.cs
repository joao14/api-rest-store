using System;
using Microsoft.EntityFrameworkCore;
using StoreApiRest.Data;
using StoreApiRest.Models;

namespace StoreApiRest.Repository
{
	public class ClientRepository: IClientRepository
	{
        private readonly ClientDb _context;

        public ClientRepository(ClientDb context)
		{
            this._context = context;
        }

		public async Task<List<Client>> GetAllClientsAsync()
		{
			var records = _context.Clients.Select(x => new Client()
			{

				Id = x.Id,
				Nombre = x.Nombre,
				Edad = x.Edad,
				Correo = x.Correo

			}).ToListAsync();

			return records;
		}
	}
}

