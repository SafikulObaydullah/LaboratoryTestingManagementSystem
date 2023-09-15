using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMTLLMS.Domain
{
    public class RavenDBContext:DbContext
    {
        //Constructor with DbContextOptions and the context class itself
        public RavenDBContext(DbContextOptions<RavenDBContext> options) : base(options)
        {

        }
    }
}
