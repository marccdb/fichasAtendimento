using FichaAtendimento.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Data
{
    public class PacienteDB : IPacienteDB
    {
        readonly FichaContext _fichaContext;

        public PacienteDB(FichaContext fichaContext)
        {
            _fichaContext = fichaContext;
        }

        public void AddNewPaciente(Paciente paciente)
        {
            _fichaContext.Pacientes.Add(paciente);
        }

        public async Task<IEnumerable<Paciente>> GetPacientes()
        {
            try
            {
                return await _fichaContext.Pacientes.ToListAsync();
            }
            catch (Exception)
            {

                throw new KeyNotFoundException();
            }
        }

        public void UpdatePaciente(Paciente paciente)
        {
            _fichaContext.Entry(paciente).State = EntityState.Modified;
        }

        public async Task<Paciente> GetPacienteById(int id)
        {
            return await _fichaContext.Pacientes.FirstOrDefaultAsync(x => x.idPaciente == id);
        }

        public void DeletePaciente(Paciente paciente)
        {
            _fichaContext.Pacientes.Remove(paciente);
        }

        public void SaveChanges()
        {
            _fichaContext.SaveChanges();
        }
    }
}
