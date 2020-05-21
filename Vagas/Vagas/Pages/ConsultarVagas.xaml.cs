using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vagas.Modelos;
using Vagas.Banco;

namespace Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultarVagas : ContentPage
    {
        public ConsultarVagas()
        {
            InitializeComponent();
            Conexao conecta = new Conexao();
            ListaVagas.ItemsSource = conecta.Consultar();
        }

        private void btn_cadastro_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVaga());
        }

        private void btn_MinhasVagas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.VagasCadastrada());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Label lblDetalhe = (Label)sender;
            TapGestureRecognizer tapGest = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];
            Vaga vaga = tapGest.CommandParameter as Vaga;

            Navigation.PushAsync(new Pages.DetalheVaga(vaga));

            
            
        }
    }
}