using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo2.Model
{
    internal class UsuarioModel
    {
        #region Singleton
        private static UsuarioModel _UsuarioModel = null;
        public UsuarioModel() { }
        public static UsuarioModel GetInstacia()
        {
            if (_UsuarioModel == null)
                _UsuarioModel = new UsuarioModel();
            return _UsuarioModel;
        }
        #endregion

        public string Usuario { get; set; }
        public string Password { get; set; }
        public List<UsuarioModel> ListaUsuarios = new List<UsuarioModel>();
    }
}
