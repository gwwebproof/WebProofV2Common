using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProofIdentitySync.models
{
    /// <summary>
    /// POCO for table WebProofClients in wp.identity
    /// </summary>
    public sealed class WebProofClient
    {
        public Guid WebProofGlobalId { get; set; }
        public string Name { get; set; }
        // ReSharper disable once InconsistentNaming
        public string URL { get; set; }
        public string DtabaseIp { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUserName { get; set; }
        public string DatabasePassword { get; set; }
        public string MysqlIp { get; set; }
        public string MySqlName { get; set; }
        public string MySqlWriteUsername { get; set; }
        public string MySqlWritePassword { get; set; }
        public string MySqlReadUsername { get; set; }
        public string MySqlReadPassword { get; set; }
        public string Description { get; set; }
        public string DatabaseNetwork { get; set; }
        public string CdnBaseUrl { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime Created { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? LastSynced { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? UsersLastSynced { get; set; }

        public Int16 IsEnabled { get; set; }
    }
}
