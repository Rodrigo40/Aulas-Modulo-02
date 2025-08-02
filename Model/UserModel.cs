using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }

        public ObservableCollection<UserModel> Users = new ObservableCollection<UserModel>();

        public UserModel(int id, string nome, string email, string password, DateTime datacadastro, DateTime dataatualizacao)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Password = password;
            this.DataCadastro = datacadastro;
            this.DataAtualizacao = dataatualizacao;
        }
        public UserModel(){}
    }
}
