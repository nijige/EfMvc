using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
