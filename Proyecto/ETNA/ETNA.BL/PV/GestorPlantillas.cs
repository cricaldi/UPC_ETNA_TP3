using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETNA.DAL;
using ETNA.Domain;

namespace ETNA.BL.PV
{
    public class GestorPlantillas
    {
        public List<TB_PV_Plantillas> Listar()
        {
            var context = new INTEGRADOModelContainer();
            return context.TB_PV_Plantillas.ToList();
        }

        public int InsertarPlantilla(string descripcion, string estado, int tipoPlantillaId)
        {
            var context = new INTEGRADOModelContainer();
            var objPlantilla = new TB_PV_Plantillas();
            objPlantilla.Descripcion = descripcion;
            objPlantilla.Estado = estado;
            objPlantilla.TB_PV_TiposPlantilla = context.TB_PV_TiposPlantilla.Find(tipoPlantillaId);
            objPlantilla.TipoPlantillaId = objPlantilla.TB_PV_TiposPlantilla.TipoPlantillaId;
            context.TB_PV_Plantillas.Add(objPlantilla);
            context.SaveChanges();
            return objPlantilla.PlantillaId;
        }

        public bool EditarPlantilla(int idPlantilla, string descripcion, string estado, int tipoPlantillaId)
        {
            var context = new INTEGRADOModelContainer();
            var plantilla = context.TB_PV_Plantillas.Find(idPlantilla);
            plantilla.Descripcion = descripcion;
            plantilla.Estado = estado;
            plantilla.TB_PV_TiposPlantilla = context.TB_PV_TiposPlantilla.Find(tipoPlantillaId);
            plantilla.TipoPlantillaId = plantilla.TB_PV_TiposPlantilla.TipoPlantillaId;
            context.SaveChanges();
            return true;
        }
    }
}
