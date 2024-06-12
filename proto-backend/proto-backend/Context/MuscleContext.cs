using Microsoft.EntityFrameworkCore;
using proto_backend.Models;

namespace proto_backend.Context
{
    internal class MuscleContext : DbContext
    {
        public DbSet<PartMaster> PartMasters { get; set; }
        // DBのパス
        public string DbPath { get; }

        public MuscleContext()
        {
            // DBの保存先をとりあえず指定
            DbPath = "C:\\rinyou-work\\Muscle.db";
        }

        // 指定したパスにSQLiteのDBファイルを作成
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

    }
}
