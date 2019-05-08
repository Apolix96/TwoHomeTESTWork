using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace dbsamicro.Models
{
    public class Context :DbContext
    {
        public DbSet<Micro> micros { get; set; }
    }
}