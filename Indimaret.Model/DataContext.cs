using System;
using System.Collections.Generic;
using System.Data.Entity;//
using System.Data.Entity.ModelConfiguration.Conventions;//
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class DataContext:DbContext
    {
        public DataContext():base("Name=IndimaretConn")
        {
            //Database.SetInitializer(new Initializer());
            Database.SetInitializer<DataContext>(null);
        }

        public virtual DbSet<Barang> Barang { get; set; }

        public virtual DbSet<MasterTransaction> MasterTransaction { get; set; }
        public virtual DbSet<DetailTransaction> DetailTransaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
