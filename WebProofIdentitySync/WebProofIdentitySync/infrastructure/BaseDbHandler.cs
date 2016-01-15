using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Dapper.FluentMap;
using WebProofIdentitySync.infrastructure.mappers;

namespace WebProofIdentitySync.infrastructure
{
    /// <summary>
    /// Base class for db operations.
    /// </summary>
    public class BaseDbHandler : IDisposable
    {
        private readonly string _connString;
        protected IDbConnection Conn { get; private set; }

        static BaseDbHandler()
        {
            FluentMapper.Initialize(config => config
                .AddMap(new WebproofGlobalAspMapper()));
        }

        /// <summary>Initializes a new instance of the <see cref="BaseDbHandler"/> class.</summary>
        /// <param name="connString">The connection string.</param>
        public BaseDbHandler(string connString)
        {
            _connString = connString;
            Conn = new SqlConnection(connString);
        }

        /// <summary>Initializes a new instance of the <see cref="BaseDbHandler"/> class.</summary>
        /// <param name="conn">The connection.</param>
        public BaseDbHandler(IDbConnection conn)
        {
            _connString = conn.ConnectionString;
            Conn = conn;
        }



        /// <summary>Runs the specified SQL query.</summary>
        /// <param name="sqlQuery">The SQL query.</param>
        /// <returns></returns>
        public dynamic Query<TQuery>(string sqlQuery)
        {
            if (Conn == null)
            {
                Conn = new SqlConnection(_connString);
            }
            if (Conn.State != ConnectionState.Open)
            {
                Conn.Open();
            }
            return Conn.Query<TQuery>(sqlQuery);
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            try
            {
                if (Conn != null)
                {
                    Conn.Dispose();
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
