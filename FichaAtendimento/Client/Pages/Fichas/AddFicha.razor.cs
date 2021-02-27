using FichaAtendimento.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace FichaAtendimento.Client.Pages.Fichas
{
    public partial class AddFicha
    {
        Ficha newFicha = new Ficha();
        private IEnumerable<Paciente> sortedPacientesArr;


        private async Task CreateFicha()
        {
            newFicha.NomePaciente = pacientesArr.Where(x => x.idPaciente == newFicha.idPaciente).SingleOrDefault()?.NomePaciente;
            await Http.PostAsJsonAsync<Ficha>("api/Fichas", newFicha);
            NavigationManager.NavigateTo("fichasatendimento");
        }

        private void Cancel()
        {
            NavigationManager.NavigateTo("fichasatendimento");
        }



        protected Paciente[] pacientesArr;
        protected override async Task OnInitializedAsync()
        {
            pacientesArr = await Http.GetFromJsonAsync<Paciente[]>("api/Pacientes");
            sortedPacientesArr = pacientesArr.OrderBy(x => x.NomePaciente);
            newFicha.DataAtendimento = DateTime.Now;
        }
    }
}
