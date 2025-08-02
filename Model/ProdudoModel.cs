using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProdudoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public ObservableCollection<ProdudoModel> Produdos = new ObservableCollection<ProdudoModel>();

        public ProdudoModel(int id, string nome, string descricao,decimal quantidade, decimal preco, DateTime datacadastro, DateTime dataatualizacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Quantidade = quantidade;
            this.Preco = preco;
            this.DataCadastro = datacadastro;
            this.DataAtualizacao = dataatualizacao;
        }
    }
}
