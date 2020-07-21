using System;
using System.Collections.Generic;
using System.Text;
using StackExchange.Redis;
using SmartSite.Log;
using System.Threading;

namespace SmartSite.Common
{
    /// <summary>
    /// redis帮助类
    /// </summary>
    public class RedisHelper
    {
        private RedisHelper()
        {

        }

        static RedisHelper()
        {
            GetConnectionRedisMultiplexer();
            if (_connMultiplexer != null)
                _db = _connMultiplexer.GetDatabase(0);
        }

        /// <summary>
        /// redis客户端连接
        /// </summary>
        private static void GetConnectionRedisMultiplexer()
        {
            if (_connMultiplexer == null || !_connMultiplexer.IsConnected)
            {
                var connectionString = ReadAppConfig.ReadConnectString("RedisConnection");
                if (string.IsNullOrEmpty(connectionString))
                    return;
                int i = 0;
                while (i < 3)
                {
                    try
                    {
                        _connMultiplexer = ConnectionMultiplexer.Connect(connectionString);
                        break;
                    }
                    catch (Exception ex)
                    {
                        i++;
                        LogHelper.WriteErrorLog($"redis初始化连接失败{i}次,连接字符串：{connectionString}。异常信息:{ex}");
                        Thread.Sleep(10);
                    }
                }
            }
        }

        #region 静态变量
        //单例
        public static RedisHelper Instance = new RedisHelper();
        private static readonly IDatabase _db;
        private static IConnectionMultiplexer _connMultiplexer;

        #endregion

        #region 公共

        /// <summary>
        /// del,删除键
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>
        public static bool KeyDel(RedisKey redisKey)
        {
            return _db.KeyDelete(redisKey);
        }
        /// <summary>
        /// type,获取键值的数据类型
        /// </summary>
        /// <param name="redisKey"></param>
        /// <returns></returns>
        public static RedisType GetKeyType(RedisKey redisKey)
        {
            return _db.KeyType(redisKey);
        }

        #endregion

        #region 字符串

        /// <summary>
        /// set,设置键值
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        /// <param name="expire"></param>
        /// <returns></returns>
        public static bool StringSet(RedisKey strKey, RedisValue strValue, TimeSpan? expire = null)
        {
            return _db.StringSet(strKey, strValue, expire);
        }
        /// <summary>
        /// get,获取键值
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>
        public static string StringGet(RedisKey strKey)
        {
            return _db.StringGet(strKey);
        }
        /// <summary>
        /// incr,递增数字
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="incrNum"></param>
        /// <returns></returns>
        public static double StringIncr(RedisKey strKey, double incrNum)
        {
            double num = 0;
            try
            {
                num = _db.StringIncrement(strKey, incrNum);
            }
            catch
            {
                var logMessage = string.Format("redis字符串递增数字失败！键名：{0}，递增数字：{1}", strKey, incrNum);
                LogHelper.WriteErrorLog(logMessage);
            }
            return num;
        }
        /// <summary>
        /// append,向尾部追加值
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public static long StringAppend(RedisKey strKey, RedisValue strValue)
        {
            return _db.StringAppend(strKey, strValue);
        }
        /// <summary>
        /// strlen，获取字符串长度
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>
        public static long GetStringLen(RedisKey strKey)
        {
            return _db.StringLength(strKey);
        }
        /// <summary>
        /// del,删除键
        /// </summary>
        /// <param name="strKey"></param>
        /// <returns></returns>


        #endregion

        #region 散列

        /// <summary>
        /// hset，设置字段的值
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashField"></param>
        /// <param name="hashFieldValue"></param>
        /// <returns></returns>
        public static bool HStringSet(RedisKey hashKey, RedisValue hashField, RedisValue hashFieldValue)
        {
            return _db.HashSet(hashKey, hashField, hashFieldValue);
        }
        /// <summary>
        /// hget，获取字段的值
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashField"></param>
        /// <returns></returns>
        public static string HStringGet(RedisKey hashKey, RedisValue hashField)
        {
            return _db.HashGet(hashKey, hashField);
        }
        /// <summary>
        /// hmset，同时设置多个字段的值
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashEntries"></param>
        public static void HMStringSet(RedisKey hashKey, HashEntry[] hashEntries)
        {
            _db.HashSet(hashKey, hashEntries);
        }
        /// <summary>
        /// hmget，同时获取多个字段的值
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashFields"></param>
        /// <returns></returns>
        public static RedisValue[] HMStringGet(RedisKey hashKey, RedisValue[] hashFields)
        {
            return _db.HashGet(hashKey, hashFields);
        }
        /// <summary>
        /// hgetall，获取指定键所有的字段和字段值
        /// </summary>
        /// <param name="hashKey"></param>
        /// <returns></returns>
        public static HashEntry[] HGetAll(RedisKey hashKey)
        {
            return _db.HashGetAll(hashKey);
        }
        /// <summary>
        /// hexists，判断字段是否存在
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashField"></param>
        /// <returns></returns>
        public static bool HExists(RedisKey hashKey, RedisValue hashField)
        {
            return _db.HashExists(hashKey, hashField);
        }
        /// <summary>
        /// hincrby，按指定数字增加或减少字段的值。前提是字段的值必须是数字类型
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashField"></param>
        /// <param name="incrNum"></param>
        /// <returns></returns>
        public static double HIncrBy(RedisKey hashKey, RedisValue hashField, double incrNum)
        {
            double num = 0;
            try
            {
                num = _db.HashIncrement(hashKey, hashField, incrNum);
            }
            catch
            {
                var logMessage = string.Format("redis散列递增数字失败！键名：{0}，递增数字：{1}", hashKey, incrNum);
                LogHelper.WriteErrorLog(logMessage);
            }
            return num;
        }
        /// <summary>
        /// hdel,删除键中的字段
        /// </summary>
        /// <param name="hashKey"></param>
        /// <param name="hashField"></param>
        /// <returns></returns>
        public static bool HDelField(RedisKey hashKey, RedisValue hashField)
        {
            return _db.HashDelete(hashKey, hashField);
        }

        #endregion

        #region 列表

        /// <summary>
        /// lpush，向列表左边增加元素
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="listValue"></param>
        /// <returns></returns>
        public static long ListLPush(RedisKey listKey, RedisValue listValue)
        {
            return _db.ListLeftPush(listKey, listValue);
        }
        /// <summary>
        /// lpush,向列表左边增加多个元素
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="listValues"></param>
        /// <returns></returns>
        public static long ListLMPush(RedisKey listKey, RedisValue[] listValues)
        {
            return _db.ListLeftPush(listKey, listValues);
        }
        /// <summary>
        /// rpush,向列表右边添加元素
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="listValue"></param>
        /// <returns></returns>
        public static long ListRPush(RedisKey listKey, RedisValue listValue)
        {
            return _db.ListRightPush(listKey, listValue);
        }
        /// <summary>
        /// rpush,向列表右边添加多个元素
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="listValues"></param>
        /// <returns></returns>
        public static long ListRMPush(RedisKey listKey, RedisValue[] listValues)
        {
            return _db.ListRightPush(listKey, listValues);
        }
        /// <summary>
        /// lpop,从列表左边弹出一个元素
        /// </summary>
        /// <param name="listKey"></param>
        /// <returns></returns>
        public static RedisValue ListLPop(RedisKey listKey)
        {
            return _db.ListLeftPop(listKey);
        }
        /// <summary>
        /// rpop,从列表右边弹出一个元素
        /// </summary>
        /// <param name="listKey"></param>
        /// <returns></returns>
        public static RedisValue ListRPop(RedisKey listKey)
        {
            return _db.ListRightPop(listKey);
        }
        /// <summary>
        /// llen,获取列表中元素的个数
        /// </summary>
        /// <param name="listKey"></param>
        /// <returns></returns>
        public static long ListLLen(RedisKey listKey)
        {
            return _db.ListLength(listKey);
        }
        /// <summary>
        /// lrange，获取列表片段
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="startIndex"></param>
        /// <param name="endIndex"></param>
        /// <returns></returns>
        public static RedisValue[] ListLRange(RedisKey listKey, long startIndex, long endIndex)
        {
            return _db.ListRange(listKey, startIndex, endIndex);
        }
        /// <summary>
        /// lrem,删除列表中指定的值
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="listValue"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static long ListLRem(RedisKey listKey, RedisValue listValue, long count)
        {
            return _db.ListRemove(listKey, listValue, count);
        }
        /// <summary>
        /// lindex，获取列表指定索引的元素值
        /// </summary>
        /// <param name="listKey"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static RedisValue ListLIndex(RedisKey listKey, long index)
        {
            return _db.ListGetByIndex(listKey, index);
        }

        #endregion
    }
}
