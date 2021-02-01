using FichaAtendimento.Server.Model;
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

        public IEnumerable<Ficha> GetFichas()
        {
            try
            {
                return _fichaContext.Fichas.ToList();
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

        public Ficha GetFichaById(int id)
        {
            return _fichaContext.Fichas.FirstOrDefault(x => x.ID == id);
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
