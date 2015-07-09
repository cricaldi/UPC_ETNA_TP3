using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ETNA.BL.PV;
using ETNA.Domain;
using ETNA.DTOs.PV;
namespace ETNA.WCF.PV
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Plantillas" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Plantillas.svc o Plantillas.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Plantillas : IPlantillas
    {
        public void DoWork()
        {
        }



        public List<PlantillaDto> ListaPlantillas()
        {
            var gestorPrograma = new GestorPlantillas();
            var lista = gestorPrograma.Listar();
            var listaDtos = new List<PlantillaDto>();

            foreach (var programa in lista)
            {
                var dto = new PlantillaDto();
                dto.Id= programa.PlantillaId;
                dto.Descripcion= programa.Descripcion;
                dto.Estado = programa.Estado;
               

                listaDtos.Add(dto);
            }

            return listaDtos;
        
        }
    }
}
