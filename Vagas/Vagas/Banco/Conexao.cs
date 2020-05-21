using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Vagas.Modelos;
using Xamarin.Forms;

namespace Vagas.Banco
{
    class Conexao
    {
        private SQLiteConnection _conecta;

        public Conexao()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.GetCaminho("database.sqlite");
            _conecta = new SQLiteConnection(caminho);
            _conecta.CreateTable<Vaga>();
        }


        public void Cadastro(Vaga vaga)
        {
            _conecta.Insert(vaga);
        }
        public void Atualizar(Vaga vaga)
        {
            _conecta.Update(vaga);
        }
        public void Delete(Vaga vaga)
        {
            _conecta.Delete(vaga);
        }
        public List<Vaga> Consultar()
        {
            return _conecta.Table<Vaga>().ToList();
        }
        public List<Vaga> Pesquisar(string palavra)
        {
            return _conecta.Table<Vaga>().Where(a => a.Nome.Contains(palavra)).ToList();
        }
        public Vaga GetID(int id)
        {
          return  _conecta.Table<Vaga>().Where(a => a.Id == id).FirstOrDefault();
        }   
       

    }
}
