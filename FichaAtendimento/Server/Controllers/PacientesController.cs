using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FichaAtendimento.Server.Data;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {

        private readonly IPacienteDB _pacienteDB;

        public PacientesController(IPacienteDB pacienteDB)
        {
            _pacienteDB = pacienteDB;
        }


        [HttpGet]
        public async Task<IEnumerable<Paciente>> GetAllPacientes()
        {
            try
            {
                return await _pacienteDB.GetPacientes();
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Não foi possivel encontrar os pacientes informados.");
            }
        }


        [HttpGet("{id}")]
        public async Task<Paciente> GetPaciente(int id)
        {
            var returnedValue = _pacienteDB.GetPacienteById(id);
            if (returnedValue != null)
            {
                return await returnedValue;
            }
            else
                throw new InvalidOperationException("Não foi possivel encontrar o paciente informado.");
        }


        [HttpPost]
        public ActionResult<Paciente> NewPaciente(Paciente newPaciente)
        {
            _pacienteDB.AddNewPaciente(newPaciente);
            _pacienteDB.SaveChanges();
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult<Paciente> UpdatePaciente(int id, Paciente paciente)
        {
            if (id != paciente.idPaciente)
            {
                return BadRequest();
            }

            _pacienteDB.UpdatePaciente(paciente);
            _pacienteDB.SaveChanges();
            return NoContent();
        }



        [HttpDelete("{id}")]
        public async Task RemovePaciente(int id)
        {
            try
            {
                var returnedValue = await _pacienteDB.GetPacienteById(id);
                if (returnedValue != null)
                {
                    _pacienteDB.DeletePaciente(returnedValue);
                    _pacienteDB.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Não foi possivel encontrar o paciente informado.");
            }
        }



    }
}
