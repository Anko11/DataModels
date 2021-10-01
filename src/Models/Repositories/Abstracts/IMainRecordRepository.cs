using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories.Abstracts
{
    public interface IMainRecordRepository
    {
        IQueryable<MainRecord> Items { get; }
        MainRecord GetRecord(Guid id);
        void Update(MainRecord record);
        void Delete(Guid id);

    }
}
