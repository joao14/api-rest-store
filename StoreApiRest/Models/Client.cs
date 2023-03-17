using System;
namespace StoreApiRest.Models
{
	public class Client
	{
        public string id { get; set; }
        public string nombre { get; set; }
		public string edad { get; set; }
        public string correo { get; set; }

        public Client() { }

        public Client(string id, string nombre, string edad, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.correo = correo;


        }
    }
}

