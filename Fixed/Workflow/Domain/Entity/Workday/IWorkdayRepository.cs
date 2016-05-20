using System;
using Fixed.Common.Entity;

namespace Fixed.Workflow.Domain.Entity.Workday
{
    public interface IWorkdayRepository : IRepository<Workday>
    {
        Entity.Workday.Workday FindOneByDate(DateTime date);
    }
}
