using System;
using StoreApiRest.Models;

namespace StoreApiRest.Repository
{
	public interface IClientRepository
	{
		Task<List<Client>> GetAllClientsAsync();

    }
}

