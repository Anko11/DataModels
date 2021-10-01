using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DataProviders.SqlServer
{
    class ModelsContext: DbContext
    {
        public DbSet<MainRecord> MainRecords { get; set; }
        public DbSet<DepRecord> DepRecords { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Data Source = DBSRV\\MSSQL2021; Initial Catalog = _00; Integrated Security = True");
        /*
        string connString = "Data Source=DBSRV\\MSSQL2021;Initial Catalog=_00;Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(connString);
        sqlConnection.Open(); */
    }
}
