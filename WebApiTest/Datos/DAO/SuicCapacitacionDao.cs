using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.DAO
{
    public class SuicCapacitacionDao
    {
        public static bool GuardarSuic(suic_capacitacion suic)
        {
            bool ok = false;
            using (NatgasHO model = new NatgasHO())
            {
                model.suic_capacitacion.Add(suic);
                model.SaveChanges();

                return true;
            }
        }
    }
}
