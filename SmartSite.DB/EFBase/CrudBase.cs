using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SmartSite.Common;
using SmartSite.DB.Models;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSite.DB.EFBase
{
    /// <summary>
    /// 数据库单表操作基类
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class CrudBase<TEntity>: ICrud<TEntity> where TEntity:class
    {
        public subei_iot_2019_workspaceContext DbContext 
        {
            get
            {
                return DIHelper.ServiceProvider.GetService(typeof(subei_iot_2019_workspaceContext)) as subei_iot_2019_workspaceContext;
            }
        } 

        public IQueryable<TEntity> Queryable
        {
            get
            {
                return DbContext.Set<TEntity>();
            }
        }
        /// <summary>
        /// 获取单表所有记录
        /// </summary>
        /// <returns></returns>
        public async Task<List<TEntity>> GetEntities()
        {
            return await Queryable.ToListAsync();
        }
        /// <summary>
        /// 添加一条记录
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<ResultModel> AddEntity(TEntity entity)
        {
            await DbContext.AddAsync(entity);
            return await Commit();
        }
        /// <summary>
        /// 提交修改到数据库
        /// </summary>
        /// <returns></returns>
        public async Task<ResultModel> Commit()
        {
            var result = new ResultModel();
            try
            {
                var saveResult = await DbContext.SaveChangesAsync();
                if (saveResult > 0)
                {
                    result.Success = true;
                    result.Data = saveResult;
                }
            }
            catch (Exception ex)
            {
                result.Message = $"EF保存出现异常，异常信息：{ex}";
            }
            return result;
        }
    }
}
