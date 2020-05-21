using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vagas.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Vagas.Banco;

namespace Vagas.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroVaga : ContentPage
    {
        public CadastroVaga()
        {
            InitializeComponent();
        }

        private void btn_salvar_Clicked(object sender, EventArgs e)
        {
            Vaga vaga = new Vaga();
            vaga.Nome = nomeVaga.Text;
            vaga.Quantidade = short.Parse(qtd.Text);
            vaga.Empresa = empresa.Text;
            vaga.Salario = double.Parse(salario.Text);
            vaga.Cidade = cidade.Text;
            vaga.Descricao = descricao.Text;
            vaga.Telefone = telefone.Text;
            vaga.TipoContrato = (tipoContrato.IsToggled) ? "PJ" : "CLT";
            vaga.Email = email.Text;

            Conexao conecta = new Conexao();
            conecta.Cadastro(vaga);


            Navigation.PopAsync();
            

        }
    }
}