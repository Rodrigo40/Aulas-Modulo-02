using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VendaModel
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdUser{ get; set; }
        public int IdProduto { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal TotalVenda { get; set; }

        ObservableCollection<VendaModel> Vendas = new ObservableCollection<VendaModel>();   
        public VendaModel(int id,int idclinete,int iduser, int idProduto, DateTime dataVenda, decimal totalVenda)
        {
            this.Id = id;
            this.IdProduto = idProduto;
            this.DataVenda = dataVenda;
            this.TotalVenda = totalVenda;
            this.IdCliente = idclinete;
            this.IdUser = iduser;
        }
    }
}
