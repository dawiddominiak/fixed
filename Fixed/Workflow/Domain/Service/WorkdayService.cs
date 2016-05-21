using System;
using Fixed.Common.Service;
using Fixed.Workflow.Domain.Entity.Workday;

namespace Fixed.Workflow.Domain.Service
{
    public class WorkdayService : RepositoryService<Workday, IWorkdayRepository>, IWorkdayService
    {
        public WorkdayService(IWorkdayRepository repository) : base(repository)
        {
        }

        public Workday EnsureWorkday(DateTime date)
        {
            var workday = Repository.FindOneByDate(date);

            if (workday == null)
            {
                workday = new Workday()
                {
                    Date = date
                };
                Repository.Insert(workday);
            }

            return workday;
        }
    }
}
