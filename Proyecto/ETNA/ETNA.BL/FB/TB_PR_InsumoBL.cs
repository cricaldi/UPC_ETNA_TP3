using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL;
using ETNA.Domain;
namespace ETNA.BL.FB
{
    public class TB_PR_InsumoBL
    {
        public List<TB_PR_Insumo> TB_PR_Insumo_Listar()
        {
            try
            {
                return new DAL.FB.TB_PR_InsumoDAO().TB_PR_Insumo_Listar();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
