using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fixed.Common.Entity;

namespace Fixed.Workflow.Domain.Entity
{
    public interface IWorkdayRepository : IRepository<Workday>
    {
        Workday FindOneByDate(DateTime date);
    }
}
