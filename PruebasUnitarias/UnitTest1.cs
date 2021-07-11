using PipHolaMundo.Controllers;
using PipHolaMundo;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PipController controlador = new PipController();
            ActionResult action = controlador.Index() as ActionResult;
        }
    }
}
