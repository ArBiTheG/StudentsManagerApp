using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using StudentsManagerApp.Application.Common;
using StudentsManagerApp.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Infrastructure.Common
{
    public class Transaction : ITransaction
    {
        IDbContextTransaction _contextTransaction;

        public Transaction(IDbContextTransaction contextTransaction)
        {
            _contextTransaction = contextTransaction;
        }

        public void Commit() => _contextTransaction.Commit();

        public void Rollback() => _contextTransaction.Rollback();

        public void Dispose()
        {
            _contextTransaction?.Dispose();
        }
    }
}
