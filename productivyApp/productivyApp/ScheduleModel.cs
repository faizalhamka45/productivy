using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace productivyApp
{
    public partial class ScheduleModel : DbContext
    {
        public ScheduleModel()
            : base("name = ScheduleModel")
        {

        }
        public virtual DbSet<InputKegiatan> Schedule { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
