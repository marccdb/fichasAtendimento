using FichaAtendimento.Shared.Model;
using System.Collections.Generic;

namespace FichaAtendimento.Server.Data
{
    public interface IFichaDB
    {
        void AddNewFicha(Ficha ficha);
        void DeleteFicha(Ficha ficha);
        Ficha GetFichaById(int id);
        IEnumerable<Ficha> GetFichas();
        void SaveChanges();
        void UpdateFicha(Ficha ficha);
    }
}