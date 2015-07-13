using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ETNA.DAL.FB
{
    public class ConexionDAO
    {
        private static SqlConnection cn;

        private ConexionDAO()
        {

        }

        public static SqlConnection getInstance()
        {
            if (cn == null)
                cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ETNA"].ConnectionString);

            return cn;
        }
    }
}
