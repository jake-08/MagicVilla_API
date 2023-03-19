using MagicVilla_API.Data;
using MagicVilla_API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MagicVilla_API.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            //_db.VillaNumbers.Include(villaNumber => villaNumber.Villa).ToList();
            dbSet = _db.Set<T>();
        }

        // "Villa,VillaSpecial"
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperites = null)
        {
            // when using IQueryable, it doesn't get executed straight away 
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperites != null)
            {
                foreach (var includeProp in includeProperites.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }

            // At this point, the query will be executed. ToList() causes immediate execution. 
            return await query.ToListAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true, string? includeProperites = null)
        {
            IQueryable<T> query = dbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            if (filter != null)
            {
                query = query.Where(filter);
            }

			if (includeProperites != null)
			{
				foreach (var includeProp in includeProperites.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query = query.Include(includeProp);
				}
			}

			return await query.FirstOrDefaultAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await Save();
        }

        public async Task RemoveAsync(T entity)
        {
            dbSet.Remove(entity);
            await Save();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
