using System;
using System.Data.Entity;
using System.Linq;

namespace AppRunner1
{
    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }


        public virtual DbSet<ConPath> ConPaths { get; set; }
    }

    public class ConPath
    {
       public int Id { get; set; }
       public string Name { get; set; }
       public string PathString { get; set; }
    }
}