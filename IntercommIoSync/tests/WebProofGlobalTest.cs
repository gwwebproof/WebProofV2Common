using IntercommIoSync.infrastructure;

namespace IntercommIoSync.tests
{
    internal class WebProofGlobalTest
    {
        internal static void TestAllClients()
        {
            using (var db = new WebProofGlobal())
            {
                var res = db.AllClients();
                var t = "";
            }
        }
    }
}
