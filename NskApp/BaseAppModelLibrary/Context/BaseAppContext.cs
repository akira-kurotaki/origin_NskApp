using BaseAppModelLibrary.Models;
using Microsoft.EntityFrameworkCore;
using ModelLibrary.Context;

namespace BaseAppModelLibrary.Context
{
    /// <summary>
    /// ベースアプリケーション向けDBコンテキスト
    /// </summary>
    public class BaseAppContext : JigyoContext
    {
        public BaseAppContext(string connectionString, string defaultSchema, int commandTimeout = 0) : 
            base(connectionString, defaultSchema, commandTimeout)
        {
        }

        public BaseAppContext(string connectionString, string defaultSchema, string userId, string ipAddress, int commandTimeout = 0) : 
            base(connectionString, defaultSchema, userId, ipAddress, commandTimeout)
        {
        }

        /// <summary>
        /// 加入者情報
        /// </summary>
        public DbSet<TKanyusha> TKanyushas { get; set; }

        /// <summary>
        /// 一時連携加入者情報
        /// </summary>
        public DbSet<WRenkeiKanyusha> WRenkeiKanyushas { get; set; }

        /// <summary>
        /// 取込管理
        /// </summary>
        public DbSet<TTorikomiManage> TTorikomiManages { get; set; }

        /// <summary>
        /// 取込対象マスタ
        /// </summary>
        public DbSet<MTorikomi> MTorikomis { get; set; }

        /// <summary>
        /// 操作履歴
        /// </summary>
        public DbSet<TSosaRireki> TSosaRirekis { get; set; }

    }
}
