using ASPNETTestProject1.Controllers;
using ASPNETTestProject1.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETTestProject1.Tests.Controllers
{
    [TestClass]
    public class PortfolioControllerTest
    {
        [TestMethod]
        public void Portfolio_Get()
        {
            // Anordnen
            PortfolioController controller = new PortfolioController();

            // Aktion ausführen
            IEnumerable<Portfolio> result = controller.Get();

            // Bestätigen
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
        }
    }
}
