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
    public  class ClienteBL 
    {
         ClientesDAO c = new ClientesDAO();
        public DataTable ObtenerClientes()
        {

            return c.ObtenerClientes();
        }

        public DataTable ObtenerClientesFiltro(String filtro)
        {

            return c.obtenerclientesFiltro(filtro);
        }


        public ClienteBE getcliente(int filtro)
        {

            return c.getcliente(filtro);
        }

    }
}
