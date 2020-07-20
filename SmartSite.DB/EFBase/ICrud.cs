using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SmartSite.DB.EFBase
{
    public interface ICrud<TEntity> where TEntity:class
    {
        public DbContext DbContext { get;}
        public IQueryable<TEntity> Queryable { get; }
        public Task<List<TEntity>> GetEntities();
        public Task<ResultModel> AddEntity(TEntity entity);
        public Task<ResultModel> Commit();
    }
}
