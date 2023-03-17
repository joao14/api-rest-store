using StoreApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace StoreApiRest.Data
{
	public class ClientDb : DbContext
	{
		public ClientDb(DbContextOptions<ClientDb> options): base(options)
		{
		}


        public DbSet<Client> Clients { get; set; }
    }

}

