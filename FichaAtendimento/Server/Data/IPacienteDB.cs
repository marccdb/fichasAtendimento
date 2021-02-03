using FichaAtendimento.Shared.Model;
using System.Collections.Generic;

namespace FichaAtendimento.Server.Data
{
    public interface IPacienteDB
    {
        void AddNewFicha(Paciente paciente);
        void DeleteFicha(Paciente paciente);
        Paciente GetFichaById(int id);
        IEnumerable<Paciente> GetFichas();
        void SaveChanges();
        void UpdateFicha(Paciente paciente);
    }
}