using System;
using Fixed.Common.Service;
using Fixed.Workflow.Domain.Entity;

namespace Fixed.Workflow.Domain.Service
{
    public class WorkdayService : RepositoryService<Workday, IWorkdayRepository>, IWorkdayService
    {
        public WorkdayService(IWorkdayRepository repository) : base(repository)
        {
        }

        public Workday FindOneByDate(DateTime date)
        {
            return Repository.FindOneByDate(date);
        }
    }
}
