using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ETNA.Domain.Venta;
using ETNA.DAL.Venta;

namespace ETNA.BL.Venta
{
    public class ModalidadCreditoBL
    {

        ModalidaCreditoDAO bl = new ModalidaCreditoDAO();

        public ModalidadCreditoBE getmodalidad(int cod)
        {
            return bl.getmodalidad(cod);
        }

    }
}
