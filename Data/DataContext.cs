namespace Nutri.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DbContext> options)
            : base(options)
        {

        }
    }

}
