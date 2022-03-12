namespace Asistencia.Entities;

using Asistencia.Interface;

public class Profesor : Persona, IOperaciones
{
    public string CUI {get; set;}

    public string Cargo {get; set;}

    public Profesor() : base()
    {

    }

    public Profesor(string Uuid, string Apellidos, String Nombres, String Email, string CUI, string Cargo)
        : base(uuid, apellidos, nombres, email)
    {
        this.CUI = CUI;
        this.Cargo = Cargo;
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
