
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InspectionAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {

        }
        

        public DbSet<Inspection> Inspections { get; set; }  
        public DbSet<InspectionType> Types { get; set; }
        public DbSet<Status> Statuses { get; set; }
    }
}
