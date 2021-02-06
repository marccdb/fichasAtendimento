using FichaAtendimento.Shared.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FichaAtendimento.Server.Data
{
    public interface IFichaDB
    {
        void AddNewFicha(Ficha ficha);
        void DeleteFicha(Ficha ficha);
        Task<Ficha> GetFichaById(int id);
        Task<IEnumerable<Ficha>> GetFichas();
        void SaveChanges();
        void UpdateFicha(Ficha ficha);
    }
}