using System;
using System.Collections.Generic;
using System.Linq;
using WebProofIdentitySync.infrastructure;
using WebProofIdentitySync.models;

namespace WebProofIdentitySync.services
{
    /// <summary>
    /// Responsible for handling sync between webproof_global and wp.identity
    /// </summary>
    public sealed class WebProofSyncService
    {
        private readonly IEnumerable<WebProofClient> _globalClients;
        private readonly IEnumerable<WebProofClient> _identityClients;
        private readonly INLogService _log;

        /// <summary>Initializes a new instance of the <see cref="WebProofSyncService"/> class.</summary>
        public WebProofSyncService()
        {
            _globalClients = GetAllGlobalClients();
            _identityClients = GetAllIdentityClients();
            _log = new NLogService();
        }

        /// <summary>Synchronizes the clients.</summary>
        public void SyncClients()
        {
            foreach (var client in _globalClients)
            {
                if (ClientExist(client.WebProofGlobalId))
                {
                    UpdateClient(client);
                }
                else
                {
                    CreateClient(client);
                }
            }
        }

        private void CreateClient(WebProofClient client)
        {
            throw new NotImplementedException();
        }

        private void UpdateClient(WebProofClient client)
        {

            throw new NotImplementedException();
        }

        private bool ClientExist(Guid webProofGlobalId)
        {
            return _identityClients.Any(c => c.WebProofGlobalId == webProofGlobalId);
        }

        private IEnumerable<WebProofClient> GetAllIdentityClients()
        {
            using (var identityDb = new WebProofIdentity())
            {
                return identityDb.AllClients();
            }
        }

        private IEnumerable<WebProofClient> GetAllGlobalClients()
        {
            using (var globalDb = new WebProofGlobal())
            {
                return globalDb.AllClients();
            }
        }
    }
}
