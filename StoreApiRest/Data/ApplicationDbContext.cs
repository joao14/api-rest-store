using System;
using Microsoft.EntityFrameworkCore;
using StoreApiRest.Models;

namespace StoreApiRest.Datos
{
	public class ApplicationDbContext: DbContext
	{
		public DbSet<Client> Clients { get; set; }
	}
}

