using System.Collections.Generic;
using System.Configuration;
using WebProofIdentitySync.models;

namespace WebProofIdentitySync.infrastructure
{
    /// <summary>
    /// Helper functions for the webproof_global database.
    /// </summary>
    public sealed class WebProofGlobal : BaseDbHandler
    {
        /// <summary>Initializes a new instance of the <see cref="WebProofGlobal"/> class.</summary>
        public WebProofGlobal()
            : base(ConfigurationManager.ConnectionStrings["WebProofGlobal"].ConnectionString)
        { }



        /// <summary>All records in webproof_asp table.</summary>
        /// <returns>List of all entries in webproof_asp table</returns>
        public IEnumerable<WebProofClient> AllClients()
        {
            return Query<WebProofClient>(@"SELECT * FROM webproof_asp");
        }
    }
}
