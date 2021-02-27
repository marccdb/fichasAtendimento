using FichaAtendimento.Shared.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Net.Http;

namespace FichaAtendimento.Client.Services
{
    public class Helper 
    {
        public HttpClient Http = new HttpClient();

        public async Task<IOrderedEnumerable<Paciente>> GetPacientes()
        {
            var pacientesArr = await Http.GetFromJsonAsync<IEnumerable<Paciente>>("https://localhost:5001/api/Pacientes");
            var sortedPacienteList = pacientesArr.OrderBy(x => x.NomePaciente);
            return sortedPacienteList;
        }



    }
}
