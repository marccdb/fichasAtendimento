using FichaAtendimento.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Paciente> GetPacientes()
        {
            try
            {
                return _fichaContext.Pacientes.ToList();
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

        public Paciente GetPacienteById(int id)
        {
            return _fichaContext.Pacientes.FirstOrDefault(x => x.idPaciente == id);
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
