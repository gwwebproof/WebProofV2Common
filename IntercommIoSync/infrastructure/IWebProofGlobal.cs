using System.Collections.Generic;
using IntercommIoSync.models;

namespace IntercommIoSync.infrastructure
{
    /// <summary>
    /// Description of all activities related to the webproof_global database.
    /// </summary>
    internal interface IWebProofGlobal
    {
        /// <summary>Alls the clients.</summary>
        /// <returns>List of all entries in webproof_asp table</returns>
        IEnumerable<WebProofAsp> AllClients();
    }
}
