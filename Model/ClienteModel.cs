using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public ObservableCollection<ClienteModel> Clientes = new ObservableCollection<ClienteModel>();
        public ClienteModel(int id, string nome, DateTime datacadastro, DateTime dataatualizacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataCadastro = datacadastro;
            this.DataAtualizacao = dataatualizacao;
        }
    }
}
