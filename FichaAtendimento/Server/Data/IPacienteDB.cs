using FichaAtendimento.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Data
{
    public interface IPacienteDB
    {
        void AddNewPaciente(Paciente paciente);
        void DeletePaciente(Paciente paciente);
        Task<Paciente> GetPacienteById(int id);
        Task<IEnumerable<Paciente>> GetPacientes();
        void SaveChanges();
        void UpdatePaciente(Paciente paciente);
    }
}