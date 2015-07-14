using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ETNA.Domain.Venta;
using ETNA.DAL.Venta;

namespace ETNA.BL.Venta
{
    public class MonedaBL
    {
        MonedadDAO ms = new MonedadDAO();

         public  DataTable ObtenerMonedas()
         {


             return ms.ObtenerMonedas();
         }
             



    }
}
