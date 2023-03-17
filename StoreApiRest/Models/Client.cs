namespace StoreApiRest.Models
{
	public class Client
	{
        public string Id { get; set; }
        public string Nombre { get; set; }
		public string Edad { get; set; }
        public string Correo { get; set; }

        public Client() { }

        public Client(string Id, string Nombre, string Edad, string Correo)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Edad = Edad;
            this.Correo = Correo;


        }
    }
}

