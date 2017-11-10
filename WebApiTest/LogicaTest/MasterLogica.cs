using Datos;
using Datos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaTest
{
    public class MasterLogica
    {

        public static string LeerRom(int cara)
        {
            List<suic> lsuic = SuicDao.ConsultarActivos();
            Random random = new Random(cara);
            suic oSuic = lsuic[random.Next(1,40)];
            return oSuic.rom;
        }

        public static bool EscribirRom(String rom, int cara)
        {
            suic_capacitacion suic = new suic_capacitacion();
            suic.rom = rom;
            suic.fecha = DateTime.Now;
            return SuicCapacitacionDao.GuardarSuic(suic);
        }

        public static bool Imprimir(String texto, String ip)
        {
            throw new NotImplementedException("Metodo no implementado.");
        }
    }
}
