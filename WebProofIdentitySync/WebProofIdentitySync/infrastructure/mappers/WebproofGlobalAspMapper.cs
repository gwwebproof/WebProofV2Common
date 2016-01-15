using Dapper.FluentMap.Mapping;
using WebProofIdentitySync.models;

namespace WebProofIdentitySync.infrastructure.mappers
{
    /// <summary>
    /// Mapping class handling table webproof_asp to WebProofClient mappings.
    /// </summary>
    public sealed class WebproofGlobalAspMapper : EntityMap<WebProofClient>
    {
        public WebproofGlobalAspMapper()
        {
            Map(c => c.WebProofGlobalId).ToColumn("webproof_guid");
            Map(c => c.Name).ToColumn("name");
            Map(c => c.URL).ToColumn("URL");
            Map(c => c.DtabaseIp).ToColumn("database_ip");
            Map(c => c.DatabaseName).ToColumn("database_name");
            Map(c => c.DatabaseUserName).ToColumn("database_username");
            Map(c => c.DatabasePassword).ToColumn("database_password");
            Map(c => c.MysqlIp).ToColumn("mysql_ip");
            Map(c => c.MySqlName).ToColumn("mysql_name");
            Map(c => c.MySqlWriteUsername).ToColumn("mysql_write_username");
            Map(c => c.MySqlWritePassword).ToColumn("mysql_write_password");
            Map(c => c.MySqlReadUsername).ToColumn("mysql_read_username");
            Map(c => c.MySqlReadPassword).ToColumn("mysql_read_password");
            Map(c => c.Description).ToColumn("description");
            Map(c => c.Created).ToColumn("stamp");
            Map(c => c.DatabaseNetwork).ToColumn("database_network");
            Map(c => c.LastSynced).Ignore();
            Map(c => c.UsersLastSynced).Ignore();
        }
    }
}
