using FichaAtendimento.Shared.Model;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace FichaAtendimento.Client.Pages.Pacientes
{
    public partial class Pacientes
    {

        private Paciente[] pacientesArr;
        private IEnumerable<Paciente> sortedPacientesArr;

        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/Pacientes");
            sortedPacientesArr = pacientesArr.OrderBy(x => x.NomePaciente);
        }

        private void NewPaciente()
        {
            NavigationManager.NavigateTo("/addpaciente");
        }

    }
}
