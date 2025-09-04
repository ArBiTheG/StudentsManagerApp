using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagerApp.Application.Common.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        IPersonRepository Persons { get; }
        IGroupRepository Groups { get; }
        IStudentRepository Students { get; }

        ITransaction BeginTransaction();
        void Save();
    }
}
