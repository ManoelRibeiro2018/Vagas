using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vagas.Banco;
using Xamarin.Forms;
using System.IO;
using Vagas.UWP.Banco;
using Windows.Storage;

[assembly:Dependency(typeof(Caminho))]
namespace Vagas.UWP.Banco
{
    public class Caminho : ICaminho
    {
        public string GetCaminho(string NomeArquivoBanco)
        {
            string caminhoPasta = ApplicationData.Current.LocalFolder.Path;

            string caminhoBanco = Path.Combine(caminhoPasta, NomeArquivoBanco);

            return caminhoBanco;
        }
    }
}
