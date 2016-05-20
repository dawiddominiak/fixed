using System;
using System.Linq;
using Fixed.Workflow.Domain.Entity;
using Fixed.Common.Repository;
using System.Data.Entity;
using Fixed.Workflow.Domain.Entity.Workday;

namespace Fixed.Workflow.Domain.Repository
{
    public class WorkdayRepository : Repository<Workday, WorkflowContext>, IWorkdayRepository
    {
        public WorkdayRepository(WorkflowContext context) : base(context)
        {
        }

        public Workday FindOneByDate(DateTime date)
        {
            // ReSharper disable once ReplaceWithSingleCallToFirstOrDefault
            return Context.Workdays
                .Where(w => w.Date.Equals(date))
                .FirstOrDefault()
            ;
        }

        public override DbSet<Workday> GetEntityDbSet()
        {
            return Context.Workdays;
        }
    }
}
