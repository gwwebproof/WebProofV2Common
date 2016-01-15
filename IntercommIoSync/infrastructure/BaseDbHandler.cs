using System;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace IntercommIoSync.infrastructure
{
    internal class BaseDbHandler : IDisposable
    {
        private readonly string _connString;
        private IDbConnection _conn;

        /// <summary>Initializes a new instance of the <see cref="BaseDbHandler"/> class.</summary>
        /// <param name="connString">The connection string.</param>
        public BaseDbHandler(string connString)
        {
            _connString = connString;
            _conn = new SqlConnection(connString);
        }

        /// <summary>Initializes a new instance of the <see cref="BaseDbHandler"/> class.</summary>
        /// <param name="conn">The connection.</param>
        public BaseDbHandler(IDbConnection conn)
        {
            _connString = conn.ConnectionString;
            _conn = conn;
        }

        /// <summary>Queries the specified SQL query.</summary>
        /// <param name="sqlQuery">The SQL query.</param>
        /// <returns></returns>
        public dynamic Query<TQuery>(string sqlQuery)
        {
            if (_conn == null)
            {
                _conn = new SqlConnection(_connString);
            }
            if (_conn.State != ConnectionState.Open)
            {
                _conn.Open();
            }
            return _conn.Query<TQuery>(sqlQuery);
        }

        /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
        public void Dispose()
        {
            try
            {
                if (_conn != null)
                {
                    _conn.Dispose();
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
