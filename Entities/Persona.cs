
namespace Asistencia.Entities
{

    public abstract class Persona 
    {
        public string Uuid {get; set;}
        public string Apellidos {get; set;}
        public string Nombres {get; set;} 
        public string Email {get; set;}

        public abstract void TomarAsistencia();
    
        public Persona()
        {   
            Console.WriteLine("Iniciando Control de Asistencia");    
        }

        public Persona(string uuid, string apellidos, string nombres, string email)
        {
            this.Uuid = uuid;
            this.Apellidos  = apellidos;
            this.Nombres = nombres;
            this.Email = email;
        }

    }   

}
