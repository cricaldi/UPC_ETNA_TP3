using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.Domain;
using System.Data.SqlClient;
using System.Data;


namespace ETNA.DAL.FB
{
    public class TB_PR_SolicitudProduccionDAO
    {
        public List<TB_PR_SolicitudProduccion> TB_PR_SolicitudProduccion_Listar(string pCOD_ESTADO)
        {
            List<TB_PR_SolicitudProduccion> objTB_PR_SolicitudProduccionListado = new List<TB_PR_SolicitudProduccion>();
            try
            {
                using (SqlConnection cn = ConexionDAO.getInstance())
                {
                    using (SqlCommand command = new SqlCommand("usp_getSolicitudes", cn))
                    {
                        cn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("COD_ESTADO", pCOD_ESTADO);

                        IDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            TB_PR_SolicitudProduccion objTB_PR_SolicitudProduccion = new TB_PR_SolicitudProduccion();

                            objTB_PR_SolicitudProduccion.SolicitudProdId = reader.IsDBNull(reader.GetOrdinal("COD_SOL")) ? string.Empty : reader.GetString(reader.GetOrdinal("COD_SOL"));
                            objTB_PR_SolicitudProduccion.FecSol = reader.IsDBNull(reader.GetOrdinal("FEC_SOL")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("FEC_SOL"));
                            objTB_PR_SolicitudProduccion.Descripcion= reader.IsDBNull(reader.GetOrdinal("DESCRIPCION")) ? string.Empty : reader.GetString(reader.GetOrdinal("DESCRIPCION"));                            
                            objTB_PR_SolicitudProduccion.PlanId = reader.IsDBNull(reader.GetOrdinal("COD_PLAN")) ? 0 : reader.GetInt32(reader.GetOrdinal("COD_PLAN"));
                            objTB_PR_SolicitudProduccion.CantPersonal = reader.IsDBNull(reader.GetOrdinal("CANT_PERSONAL")) ? 0 : reader.GetInt32(reader.GetOrdinal("CANT_PERSONAL"));
                            objTB_PR_SolicitudProduccion.CantInsumos= reader.IsDBNull(reader.GetOrdinal("CANT_INSUMOS")) ? 0 : reader.GetInt32(reader.GetOrdinal("CANT_INSUMOS"));
                            objTB_PR_SolicitudProduccion.CantMaquinaria = reader.IsDBNull(reader.GetOrdinal("CANT_MAQUINARIA")) ? 0 : reader.GetInt32(reader.GetOrdinal("CANT_MAQUINARIA"));

                            objTB_PR_SolicitudProduccionListado.Add(objTB_PR_SolicitudProduccion);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return objTB_PR_SolicitudProduccionListado;
        } 
    }
}
