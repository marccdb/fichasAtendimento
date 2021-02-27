using FichaAtendimento.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Fichas
{
    public partial class Fichas
    {

        protected Paciente[] pacientesArr;
        protected Ficha[] fichas;
        private IEnumerable<Paciente> sortedPacientesArr;


        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/Pacientes");
            sortedPacientesArr = pacientesArr.OrderBy(x => x.NomePaciente);

            fichas = await Http.GetFromJsonAsync<Ficha[]>("api/Fichas");

        }

        private string sessaoPaga;
        private string reciboEntregue;

        private int pacienteId;
        private IEnumerable<Ficha> FichaPorPaciente()
        {
            var returnedValue = fichas.Where(x => x.idPaciente == pacienteId);
            return returnedValue;
        }

        private void NovaFicha()
        {
            NavigationManager.NavigateTo("/addficha");
        }

    }
}
