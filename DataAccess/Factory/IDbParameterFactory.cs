using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess.Factory
{
    public interface IDbParameterFactory
    {
        IDbDataParameter CreateParameter(string name, object? value);
    }
}
