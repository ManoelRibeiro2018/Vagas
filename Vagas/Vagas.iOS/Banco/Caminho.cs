using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

using Vagas.Banco;
using Xamarin.Forms;
using System.IO;
using Vagas.iOS.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace Vagas.iOS.Banco
{
    class Caminho : ICaminho
    {
        public string GetCaminho(string NomeArquivoBanco)
        {
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoBiblioteca = Path.Combine(caminhoDaPasta, "..", "Library");

            string caminhoBanco = Path.Combine(caminhoBiblioteca, NomeArquivoBanco);
            return caminhoBanco;
        
        }
    }
}