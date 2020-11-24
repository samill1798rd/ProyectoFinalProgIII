using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAcces.Context
{
    class ApplicationDbContext: DbContext, IApplicationDbContext
    {
   
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


    }
}
