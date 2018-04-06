using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;


namespace Datos
{
    public class ClubDal
    {
        public void insertClub(club club)
        {
            prueba_pabloEntities db = new prueba_pabloEntities();
            db.club.Add(club);
            db.SaveChanges();
        }

        public club getById(int idClub)
        {
            prueba_pabloEntities db = new prueba_pabloEntities();
            return db.club.Where(c => c.id_club == idClub).FirstOrDefault();
        }

        public club getByDescripcion(string descripcion)
        {
            prueba_pabloEntities db = new prueba_pabloEntities();
            return db.club.Where(c => c.descripcion == descripcion).FirstOrDefault();
        }
    }
}
