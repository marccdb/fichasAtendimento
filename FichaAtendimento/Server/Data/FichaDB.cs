using FichaAtendimento.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Data
{
    public class FichaDB : IFichaDB
    {
        readonly FichaContext _fichaContext;

        public FichaDB(FichaContext fichaContext)
        {
            _fichaContext = fichaContext;
        }

        public void AddNewFicha(Ficha ficha)
        {
            _fichaContext.Fichas.Add(ficha);
        }

        public async Task<IEnumerable<Ficha>> GetFichas()
        {
            try
            {
                return await _fichaContext.Fichas.ToListAsync();
            }
            catch (Exception)
            {

                throw new KeyNotFoundException();
            }

        }

        public void UpdateFicha(Ficha ficha)
        {
            _fichaContext.Entry(ficha).State = EntityState.Modified;
        }

        public async Task<Ficha> GetFichaById(int id)
        {
            return await _fichaContext.Fichas.FirstOrDefaultAsync(x => x.idPaciente == id);
        }

        public void DeleteFicha(Ficha ficha)
        {
            _fichaContext.Fichas.Remove(ficha);
        }

        public void SaveChanges()
        {
            _fichaContext.SaveChanges();
        }


    }
}
