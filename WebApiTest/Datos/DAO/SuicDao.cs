using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAO
{
    public class SuicDao
    {
        public static List<suic> ConsultarActivos()
        {
            using (NatgasHO model = new NatgasHO())
            {
                List<suic> listado = model
                                     .suic
                                     .Where(x=>x.habilitado && x.fecha_proxima_revision >= DateTime.Now)
                                     .ToList();

                return listado;
            }
        }
    }
}
