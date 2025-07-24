using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2.Model
{
    internal class PessoaModel
    {
        #region Singleton
        private static PessoaModel _pessoaModel = null;
        public PessoaModel() { }
        public static PessoaModel GetInstacia()
        {
            if (_pessoaModel == null)
                _pessoaModel = new PessoaModel();
            return _pessoaModel;
        }
        #endregion
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public List<PessoaModel> ListaPessoa = new List<PessoaModel>(); 
    }
}
