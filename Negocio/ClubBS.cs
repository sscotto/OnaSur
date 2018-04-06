using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class ClubBS
    {
        private ClubDal _clubDal = new ClubDal();

        public void agregar(club club)
        {
            if (_clubDal.getByDescripcion(club.descripcion) == null)
            {
                _clubDal.insertClub(club);
            }
        }

    }
}
