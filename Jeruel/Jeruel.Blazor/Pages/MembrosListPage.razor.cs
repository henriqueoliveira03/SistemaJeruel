using Jeruel.Teste;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;




namespace Jeruel.Blazor.Pages
{
    public partial class MembrosListPage
    {
        [Inject]

        public HttpClient HttpClient { get; set; }


    


        public List<Membros> membros { get; set; }


        protected override async Task OnInitializedAsync()
        {
            // membros = await HttpClient.GetFromJsonAsync<Membros[]>("sample-data/weather.json");

            membros = new List<Membros>
            {
                new (){ID= 1, Nome= "João da Silva", Telefone= "(21) 999999999", Email= "joaodasilva@gmail.com", CPF="000.000.000-00", DataDeNascimento= DateTime.Parse("13/03/2001")  }
            };

            await base.OnInitializedAsync();
        }
    }
}

      
