using WebListaEsperaMentoria.Models;

namespace WebListaEsperaMentoria.Interfaces
{
    public interface IPacienteServices
    {
        List<PacienteModel> BuscarPacientes();
        PacienteModel BuscarPorId(int id);
        PacienteModel CriarPaciente(PacienteModel paciente);
        PacienteModel EditarPaciente(PacienteModel paciente);
        PacienteModel DeletarPaciente(int id);

    }
}
