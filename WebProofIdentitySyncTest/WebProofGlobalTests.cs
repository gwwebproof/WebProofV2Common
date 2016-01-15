using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebProofIdentitySync.infrastructure;

namespace WebProofIdentitySyncTest
{
    [TestClass]
    public class WebProofGlobalTests
    {
        [TestMethod]
        public void CheckIfClientsExistTest()
        {
            using (var db = new WebProofGlobal())
            {
                var allClients = db.AllClients();
                Assert.IsNotNull(allClients);
                Assert.IsTrue(allClients.Any());
            }
        }
    }
}
