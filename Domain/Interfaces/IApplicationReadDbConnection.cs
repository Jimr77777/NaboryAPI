﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IApplicationReadDbConnection
    {
        Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object param=null, IDbTransaction transaction=null,
            CancellationToken cancellationToken = default);
        Task<T> QueryFirstOfDefaultAsync<T>(string sql, object param=null, IDbTransaction transaction=null,
            CancellationToken cancellationToken = default);
        Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null,
            CancellationToken cancellationToken = default);

    }
}
