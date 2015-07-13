using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL;
using ETNA.Domain;
namespace ETNA.BL.FB
{
    public class TB_PR_SolicitudProduccionBL
    {
        public List<TB_PR_SolicitudProduccion> TB_PR_SolicitudProduccion_Listar(string pCOD_ESTADO)
        {
            try
            {
                return new DAL.FB.TB_PR_SolicitudProduccionDAO().TB_PR_SolicitudProduccion_Listar(pCOD_ESTADO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
