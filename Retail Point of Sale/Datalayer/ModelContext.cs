using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalayer
{
    public class ModelContext : DbContext
    {
        public ModelContext() : base("name=conexion") { } 
        public DbSet<Model.User> User { get; set; }

    }
}
