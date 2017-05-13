using SaraTest.Data;
using SaraTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaraTest.Repo
{
    public class GenericRepo : IGenericRepo
    {
        private ApplicationDbContext _db;

        public GenericRepo(ApplicationDbContext db)
        {
            _db = db;
        }
        /// <summary>
        /// Generic Query Method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IQueryable<T> Query<T>() where T : class
        {
            return _db.Set<T>().AsQueryable();
        }
        /// <summary>
        /// Add a new entity to a dbSet of that entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityToCreate"></param>
        public void Add<T>(T entityToCreate) where T : class
        {
            _db.Set<T>().Add(entityToCreate);
            _db.SaveChanges();
        }
        /// <summary>
        /// Generically Update an existing entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityToUpdate"></param>
        public void Update<T>(T entityToUpdate) where T : class
        {
            _db.Set<T>().Update(entityToUpdate);
            _db.SaveChanges();
        }
        /// <summary>
        /// Gneric Delete existing entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityToDelete"></param>
        public void Delete<T>(T entityToDelete) where T : class
        {
            _db.Set<T>().Remove(entityToDelete);
            _db.SaveChanges();
        }
    }
}
