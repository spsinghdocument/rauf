using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class Sp
    {
       private Inventory_MVC2Entities1 db;
      // private DbSet<T> dbSet;
     public Sp()
       {
           db = new Inventory_MVC2Entities1();
           //dbSet = db.Set<T>();
       }
     public List< mayank_Result> spi()
     {
         var idParam = new SqlParameter
         {
             ParameterName = "sp",
             Value = 1
         };
        return db.Database.SqlQuery<mayank_Result>(
         "exec mayank @sp ", idParam).ToList<mayank_Result>();
     }


      // private YourContext Context { get; set; }

       public DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters)
       {
           return db.Database.SqlQuery<T>(sql, parameters);
       }

    }
}
