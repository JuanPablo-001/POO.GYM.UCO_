namespace POO.GYM.Models
{
    public abstract class Persona
    {
            public int IdPersona { get; set; }
            public string Nombre { get; set; }
            public string Contrasena { get; set; }
            public string Correo { get; set; }

            public void IniciarSesion()
            {
                Console.WriteLine("Sesión iniciada");
            }
        }


    
}
