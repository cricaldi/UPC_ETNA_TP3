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
    public class TB_PR_InsumoDAO
    {
        public List<TB_PR_Insumo> TB_PR_Insumo_Listar()
        {
            List<TB_PR_Insumo> objTB_INSUMOListado = new List<TB_PR_Insumo>();
            try
            {
                using (SqlConnection cn = ConexionDAO.getInstance())
                {
                    using (SqlCommand command = new SqlCommand("usp_getInsumos", cn))
                    {
                        cn.Open();
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("COD_SOL", 1);

                        IDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            TB_PR_Insumo objTB_INSUMO = new TB_PR_Insumo();
                            objTB_INSUMO.InsumoId = reader.IsDBNull(reader.GetOrdinal("COD_INSUMO")) ? string.Empty : reader.GetString(reader.GetOrdinal("COD_INSUMO"));
                            objTB_INSUMO.Descripcion = reader.IsDBNull(reader.GetOrdinal("DESCRIPCION")) ? string.Empty : reader.GetString(reader.GetOrdinal("DESCRIPCION"));
                            objTB_INSUMO.StockDispInsumo = reader.IsDBNull(reader.GetOrdinal("STOCK_DISP_INSUMO")) ? 0 : reader.GetInt32(reader.GetOrdinal("STOCK_DISP_INSUMO"));
                            objTB_INSUMO.StockResInsumo = reader.IsDBNull(reader.GetOrdinal("STOCK_RES_INSUMO")) ? 0 : reader.GetInt32(reader.GetOrdinal("STOCK_RES_INSUMO"));
                            objTB_INSUMO.Observacion = reader.IsDBNull(reader.GetOrdinal("Observacion")) ? string.Empty : reader.GetString(reader.GetOrdinal("Observacion"));
                            
                            objTB_INSUMOListado.Add(objTB_INSUMO);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return objTB_INSUMOListado;
        } 
    }
}
