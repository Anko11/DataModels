using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories.Abstracts
{
    public interface IDepRecordRepository
    {
        IQueryable<MainRecord> GetItemsByRef(Guid mainRecordId);
        MainRecord GetRecord(Guid id);
        void Update(MainRecord record);
        void Delete(Guid id);

    }
}
