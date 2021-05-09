using System;
using BE;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UsuarioBL
    {
        public List<Usuario> ListarUsuarios()
        {
            var db = new DAL.BaseDataService<Usuario>();
            return db.Get();
        }
        public int Agregar()
        {
            //llamada a datos
            return 1;
        }
    }
}
