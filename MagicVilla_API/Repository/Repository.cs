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
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeProperites = null, int pageSize = 0, int pageNumber = 1)
        {
            // when using IQueryable, it doesn't get executed straight away 
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Pagination 
            if (pageSize > 0)
            {
                // Max 100 items 
                if (pageSize > 100)
                {
                    pageSize = 100;
                }
                // pageNumber = 2 | pageSize = 5
                // Skip(5*(2-1).Take(5) 
                // Skip(5).Take(5) -> Skip the first five and take the next 5
                query = query.Skip(pageSize * (pageNumber - 1)).Take(pageSize);
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
