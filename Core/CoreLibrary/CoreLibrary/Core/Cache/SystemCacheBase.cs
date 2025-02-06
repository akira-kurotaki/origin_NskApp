﻿using ModelLibrary.Context;
using ModelLibrary.Models;

namespace CoreLibrary.Core.Cache
{
    /// <summary>
    /// キャッシュ機能ベースクラス
    /// システム共通向け
    /// </summary>
    public abstract class SystemCacheBase
    {
        /// <summary>
        /// キャッシュマネージャー変数
        /// </summary>
        protected ICacheManager cacheManager;

        /// <summary>
        /// DBコンネクション変数
        /// </summary>
        protected SystemCommonContext db = new SystemCommonContext();

        /// <summary>
        /// 全件別の取得処理の抽象メソッド。
        /// </summary>
        /// <returns>全件取得の結果</returns>
        public abstract IEnumerable<ModelBase> FindAll();

        /// <summary>
        /// 件別取得処理ロジックの抽象メソッド（コールバックメソッド）。
        /// </summary>
        /// <returns>全件取得の結果</returns>
        public abstract IEnumerable<ModelBase> GetList();
    }
}