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

        public void AddNewFicha(Paciente paciente)
        {
            _fichaContext.Pacientes.Add(paciente);
        }

        public IEnumerable<Paciente> GetFichas()
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

        public void UpdateFicha(Paciente paciente)
        {
            _fichaContext.Entry(paciente).State = EntityState.Modified;
        }

        public Paciente GetFichaById(int id)
        {
            return _fichaContext.Pacientes.FirstOrDefault(x => x.idPaciente == id);
        }

        public void DeleteFicha(Paciente paciente)
        {
            _fichaContext.Pacientes.Remove(paciente);
        }

        public void SaveChanges()
        {
            _fichaContext.SaveChanges();
        }
    }
}
