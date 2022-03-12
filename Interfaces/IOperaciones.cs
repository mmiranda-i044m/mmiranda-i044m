using Asistencia.Entities;

namespace Asistencia.Interface
{
    public interface IOperaciones{
        public void ListarMisDatos(Persona Identificador);
        public bool EliminarAsisgnatura(Persona Asignatura);
    }
}