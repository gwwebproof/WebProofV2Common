using System.Collections.Generic;
using System.Configuration;
using WebProofIdentitySync.models;

namespace WebProofIdentitySync.infrastructure
{
    /// <summary>Helper class for wp.identity</summary>
    public sealed class WebProofIdentity : BaseDbHandler
    {
        /// <summary>Initializes a new instance of the <see cref="WebProofIdentity"/> class.</summary>
        public WebProofIdentity()
            : base(ConfigurationManager.ConnectionStrings["WebProofIdentity"].ConnectionString)
        { }

        /// <summary>All records in webproof_asp table.</summary>
        /// <returns>List of all entries in webproof_asp table</returns>
        public IEnumerable<WebProofClient> AllClients()
        {
            return Query<WebProofClient>(@"SELECT * FROM WebProofClients");
        }

        public bool ClientExist(string guid)
        {
            var res = Query<int>(@"SELECT COUNT(1) AS Res FROM WebProofClients WHERE WebProofGlobalId = N'" + guid +"'");
            return res[0] != 0;
        }

        public void UpdateClient(WebProofClient client)
        {
            
        }

        public void DeleteClient(string guid)
        {
            
        }
    }
}
