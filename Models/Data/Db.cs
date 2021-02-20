using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Project_ASP.Models.Data
{
    public class Db : DbContext
    {
        public DbSet<PageDTO> Pages { get; set; }
        public DbSet<SidebarDTO> Sidebar { get; set; }
    }
}