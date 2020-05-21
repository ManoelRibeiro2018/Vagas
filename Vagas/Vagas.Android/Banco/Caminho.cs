using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Vagas.Banco;
using Xamarin.Forms;
using System.IO;
using Vagas.Droid.Banco;

[assembly:Dependency(typeof(Caminho))]
namespace Vagas.Droid.Banco
{
    public class Caminho : ICaminho
    {
     public string GetCaminho(string NomeArquivoBanco)
        {
            
            var caminhoDaPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            string caminhoBanco = Path.Combine(caminhoDaPasta, NomeArquivoBanco);

            return caminhoBanco;
        }   
    }
}