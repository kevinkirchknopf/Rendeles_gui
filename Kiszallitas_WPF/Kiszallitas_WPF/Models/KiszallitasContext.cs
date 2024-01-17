using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Kiszallitas_WPF.Models
{
     public class KiszallitasContext : DbContext
    {
        public DbSet<Etel> Etel { get; set; }
        public DbSet<Futar> Futar { get; set; }
        public DbSet<Megrendeles> Megrendeles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //ConnectionString
            string c = "server = localhost; userid = root; password =; database = Kiszallitas";

            //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
            optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


        }
    }
}
