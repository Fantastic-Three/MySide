using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HabitForm
{
    public partial class HabitModel : DbContext
    {
        public HabitModel()
            : base("name=HabitModel")
        {
        }

        public virtual DbSet<Habit> Habits { get; set; }
        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
