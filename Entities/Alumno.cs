namespace Asistencia.Entities;

using Asistencia.Interface;

public class Alumno : Persona, IOperaciones
{   
        public string Carne {get; set;}

        public string NumeroCreditos {get; set;}

        public Alumno() : base()
        {

        }
        public Alumno(string Uuid, string Apellidos, String Nombres, String Email, string Carne, string numeroCreditos)
        : base(uuid, apellidos, nombres, email)
        {
            this.Carne = Carne;
            this.NumeroCreditos = numeroCreditos;
        }        
        public override void TomarAsistencia()
        {
            return;
        }

    public void ListarMisDatos(Persona Identificador)
    {
        throw new NotImplementedException();
    }

    public bool EliminarAsisgnatura(Persona Asignatura)
    {
        throw new NotImplementedException();
    }
}
