using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ETNA.Domain;
using ETNA.BL.FB;
using System.Collections.Generic;
namespace ETNA.Test
{
    [TestClass]
    public class FabricacionTEST
    {
        [TestMethod]
        public void TB_PR_INSUMO_Listar()
        {
            List<TB_PR_Insumo> objListado = new TB_PR_InsumoBL().TB_PR_Insumo_Listar();

            Assert.IsTrue(objListado.Count > 0);

        }
    }
}
