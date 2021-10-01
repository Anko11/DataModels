using Models.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public record DataManager(IMainRecordRepository mainRecordRepository,  IDepRecordRepository depRecordRepository);
}
