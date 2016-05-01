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
    public class Repository<T> : IRepository<T> where T : class
    {

        private Inventory_MVC2Entities1 db;
        private DbSet<T> dbSet;

        public Repository()
        {
            db = new Inventory_MVC2Entities1();
            dbSet = db.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(object Id)
        {
            return dbSet.Find(Id);
        }
        public void Insert(T obj)
        {
            dbSet.Add(obj);
        }
        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object Id)
        {
            T getObjById = dbSet.Find(Id);
            dbSet.Remove(getObjById);
        }
        public void Save()
        {
            db.SaveChanges();
        }


        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.db != null)
                {
                    this.db.Dispose();
                    this.db = null;
                }
            }
        }


        public List<T> SQLQuery<T>(string sql, params object[] parameters)
        {

         //   List<T> b = db.Database.SqlQuery<T>(
         //sql, parameters).ToList<T>();
           
            return db.Database.SqlQuery<T>(sql, parameters).ToList<T>();
        }


    }  

}
