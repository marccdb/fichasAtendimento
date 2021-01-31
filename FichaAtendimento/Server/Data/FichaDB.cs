using FichaAtendimento.Server.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Data
{
    public class FichaDB
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
            return _fichaContext.Fichas.ToList();
        }

        public void UpdateFicha(Ficha ficha)
        {
            _fichaContext.Fichas.Update(ficha);
        }

        public Ficha GetFichaById(int id)
        {
            return _fichaContext.Fichas.FirstOrDefault(x => x.ID == id);
        }

        public void DeleteFicha(Ficha ficha)
        {
            _fichaContext.Fichas.Remove(ficha);
        }




    }
}
