using System.Collections.Generic;
using System.Configuration;
using IntercommIoSync.models;

namespace IntercommIoSync.infrastructure
{
    /// <summary>
    /// Helper functions for the webproof_global database.
    /// </summary>
    internal class WebProofGlobal : BaseDbHandler, IWebProofGlobal
    {
        /// <summary>Initializes a new instance of the <see cref="WebProofGlobal"/> class.</summary>
        public WebProofGlobal()
            : base(ConfigurationManager.ConnectionStrings["WebProofGlobal"].ConnectionString)
        { }



        /// <summary>All records in webproof_asp table.</summary>
        /// <returns>List of all entries in webproof_asp table</returns>
        public IEnumerable<WebProofAsp> AllClients()
        {
            return Query<WebProofAsp>(@"SELECT webproof_guid AS WebProofGuid, name AS NAME FROM webproof_asp");
        }
    }
}
