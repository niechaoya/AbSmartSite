using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSite.DB.Models;

namespace SmartSite.DB.EFBase
{
    public interface ICrud<TEntity> where TEntity:class
    {
        public subei_iot_2019_workspaceContext DbContext { get;}
        public IQueryable<TEntity> Queryable { get; }
        public Task<List<TEntity>> GetEntities();
        public Task<ResultModel> AddEntity(TEntity entity);
        public Task<ResultModel> Commit();
    }
}
