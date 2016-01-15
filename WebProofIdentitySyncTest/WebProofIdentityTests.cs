using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebProofIdentitySync.infrastructure;

namespace WebProofIdentitySyncTest
{
    [TestClass]
    public class WebProofIdentityTests
    {
        [TestMethod]
        public void CheckIfClientsExist()
        {
            using (var db = new WebProofIdentity())
            {
                var allClients = db.AllClients();
                Assert.IsNotNull(allClients);
                Assert.IsTrue(allClients.Any());
            }
        }

        [TestMethod]
        public void CheckIfClientExist()
        {
            using (var db = new WebProofIdentity())
            {
                var client = db.ClientExist(new Guid().ToString());
                Assert.IsFalse(client);
            }
        }
    }
}
