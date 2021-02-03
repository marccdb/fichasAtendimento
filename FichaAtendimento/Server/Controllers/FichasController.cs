using FichaAtendimento.Shared.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using FichaAtendimento.Server.Data;

namespace FichaAtendimento.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichasController : ControllerBase
    {
        private readonly IFichaDB _fichaDB;

        public FichasController(IFichaDB fichaDB)
        {
            _fichaDB = fichaDB;

        }


        [HttpGet]
        public IEnumerable<Ficha> GetAllFichas()
        {
            try
            {
                return _fichaDB.GetFichas();
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Não foi possivel encontrar as fichas informadas.");
            }
            
        }


        [HttpGet("{id}")]
        public Ficha GetFicha(int id)
        {
            var returnedValue = _fichaDB.GetFichaById(id);
            if (returnedValue != null)
            {
                return returnedValue;
            }
            else
                throw new InvalidOperationException("Não foi possivel encontrar a ficha informada.");

        }


        [HttpPost]
        public ActionResult<Ficha> NewFicha(Ficha newFicha)
        {
            _fichaDB.AddNewFicha(newFicha);
            _fichaDB.SaveChanges();
            return Ok();
        }


        [HttpPut("{id}")]
        public ActionResult<Ficha> UpdateFicha(int id, Ficha ficha)
        {
            if (id != ficha.idPaciente)
            {
                return BadRequest();
            }

            _fichaDB.UpdateFicha(ficha);
            _fichaDB.SaveChanges();

            return NoContent();
        }



        [HttpDelete("{id}")]
        public void RemoveFicha(int id)
        {
            try
            {
                var returnedValue = _fichaDB.GetFichaById(id);
                if (returnedValue != null)
                {
                    _fichaDB.DeleteFicha(returnedValue);
                    _fichaDB.SaveChanges();
                }

            }
            catch (Exception)
            {

                throw new InvalidOperationException("Não foi possivel encontrar a ficha informada.");
            }


        }

    }
}
