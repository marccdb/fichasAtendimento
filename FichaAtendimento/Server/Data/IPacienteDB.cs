using FichaAtendimento.Shared.Model;
using System.Collections.Generic;

namespace FichaAtendimento.Server.Data
{
    public interface IPacienteDB
    {
        void AddNewPaciente(Paciente paciente);
        void DeletePaciente(Paciente paciente);
        Paciente GetPacienteById(int id);
        IEnumerable<Paciente> GetPacientes();
        void SaveChanges();
        void UpdatePaciente(Paciente paciente);
    }
}