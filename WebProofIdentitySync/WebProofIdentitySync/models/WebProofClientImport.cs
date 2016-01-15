using System;

namespace WebProofIdentitySync.models
{
    /// <summary>
    /// Status type for a single client import record.
    /// </summary>
    internal enum ClientImportStatus
    {
        /// <summary>
        /// The failed status for a new client.
        /// </summary>
        NewFailed = 0,
        /// <summary>
        /// The ok status for a new client.
        /// </summary>
        NewOk = 1,
        /// <summary>
        /// The failed status for updating a client.
        /// </summary>
        UpdateFailed = 2,
        /// <summary>
        /// The ok status for updating a client.
        /// </summary>
        UpdateOk = 3,
        /// <summary>
        /// The update not needed status for updating a client.
        /// </summary>
        UpdateNotNeeded = 4
    }

    /// <summary>
    /// Status for a single client import / update.
    /// </summary>
    internal sealed class WebProofClientImport
    {
        /// <summary>
        /// Gets or sets the web proof global identifier.
        /// </summary>
        /// <value>
        /// The web proof global identifier.
        /// </value>
        public Guid WebProofGlobalId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public ClientImportStatus Status { get; set; }
    }
}
