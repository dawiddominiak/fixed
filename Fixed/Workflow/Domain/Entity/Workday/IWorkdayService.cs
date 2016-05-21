using System;
using Fixed.Common.Service;

namespace Fixed.Workflow.Domain.Entity.Workday
{
    public interface IWorkdayService : IRepositoryService<Workday>
    {
        Workday EnsureWorkday(DateTime date);
    }
}
