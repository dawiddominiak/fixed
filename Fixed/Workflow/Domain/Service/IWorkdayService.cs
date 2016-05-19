using System;
using Fixed.Common.Service;
using Fixed.Workflow.Domain.Entity;

namespace Fixed.Workflow.Domain.Service
{
    public interface IWorkdayService : IRepositoryService<Workday>
    {
        Workday FindOneByDate(DateTime date);
    }
}
