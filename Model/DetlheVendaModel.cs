using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DetlheVendaModel
    {
        public int Id { get; set; }
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public int IdUser { get; set; }
        public int IdProduto { get; set; }
        public double Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Descriccao { get; set; }
        public decimal Total { get; set; }
        public DateTime DataCadastro { get; set; }
        public DetlheVendaModel(int id, int idVenda, int idCliente, int idUser, int idProduto, double quantidade, decimal precoUnitario, string descriccao, decimal total, DateTime dataCadastro)
        {
            this.Id = id;
            this.IdVenda = idVenda;
            this.IdCliente = idCliente;
            this.IdUser = idUser;
            this.IdProduto = idProduto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = precoUnitario;
            this.Descriccao = descriccao;
            this.Total = total;
            this.DataCadastro = dataCadastro;
        }
    }
}
