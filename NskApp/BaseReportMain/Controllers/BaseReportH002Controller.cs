﻿using BaseAppModelLibrary.Context;
using BaseReportMain.Common;
using BaseReportMain.Models.H002;
using BaseReportMain.Models.P1002;
using BaseReportMain.ReportCreators.P1002;
using BaseReportMain.Reports;
using CoreLibrary.Core.Consts;
using CoreLibrary.Core.Dto;
using CoreLibrary.Core.Extensions;
using CoreLibrary.Core.Utility;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ModelLibrary.Models;
using Npgsql;
using NpgsqlTypes;
using ReportLibrary.Core.Base;
using ReportLibrary.Core.Consts;
using ReportLibrary.Core.Utility;
using ReportMain.Common;
using System.ComponentModel;
using System.Text;

namespace BaseReportMain.Controllers
{
    public class BaseReportH002Controller : ReportController
    {

        #region メンバー定数
        /// <summary>
        /// ロガー出力情報
        /// </summary>
        private static readonly string LOGGER_INFO_STR = "H002_加入者情報（単票）制御処理";

        /// <summary>
        /// 表示順
        /// </summary>
        private static readonly Dictionary<string, string> allSortDic = new Dictionary<string, string>
            {
                { DisplaySortType.Nendo.ToString(), "t_kanyusha.nendo" },
                { DisplaySortType.TodofukenCd.ToString(), "v_nogyosha.todofuken_cd" },
                { DisplaySortType.KumiaitoCd.ToString(), "v_nogyosha.kumiaito_cd" },
                { DisplaySortType.ShishoCd.ToString(), "v_nogyosha.shisho_cd" },
                { DisplaySortType.ShichosonCd.ToString(), "v_nogyosha.shichoson_cd" },
                { DisplaySortType.DaichikuCd.ToString(), "v_nogyosha.daichiku_cd" },
                { DisplaySortType.ShochikuCd.ToString(), "v_nogyosha.shochiku_cd" },
                { DisplaySortType.HojinFullNm.ToString(), "v_nogyosha.hojin_full_nm" },
                { DisplaySortType.KanyushaCd.ToString(), "t_kanyusha.kanyusha_cd" },
            };

        /// <summary>
        /// ソート順
        /// </summary>
        [Flags]
        private enum DisplaySortType
        {
            [Description("対象年度")]
            Nendo,
            [Description("都道府県")]
            TodofukenCd,
            [Description("組合等")]
            KumiaitoCd,
            [Description("支所")]
            ShishoCd,
            [Description("加入者管理コード")]
            KanyushaCd,
            [Description("市町村")]
            ShichosonCd,
            [Description("大地区")]
            DaichikuCd,
            [Description("小地区")]
            ShochikuCd,
            [Description("氏名又は法人名")]
            HojinFullNm,
        }
        #endregion

        public BaseReportH002Controller(DbConnectionInfo dbInfo) : base(dbInfo)
        {
        }

        #region H002_加入者情報（単票）制御処理
        /// <summary>
        /// H002_加入者情報（単票）制御処理
        /// </summary>
        /// <param name="userId">ユーザーID</param>
        /// <param name="joukenId">条件ID</param>
        /// <param name="todofukenCd">都道府県コード</param>
        /// <param name="kumiaitoCd">組合等コード</param>
        /// <param name="shishoCd">支所コード</param>
        /// <param name="shishoList">利用可能支所一覧</param>
        /// <param name="batchFlag">バッチフラグ（リアルタイム帳票：0、バッチ帳票：1）</param>
        /// <param name="filePath">帳票パス</param>
        /// <param name="batchId">バッチID</param>/// 
        /// <returns>実行結果</returns>
        public ControllerResult ManageReports(string userId, int joukenId, string todofukenCd, string kumiaitoCd, string shishoCd, List<string> shishoList, int batchFlag, string filePath, long? batchId)
        {
            // ログ出力(開始)
            logger.Info(string.Format(
                ReportConst.METHOD_BEGIN_LOG,
                ReportConst.CLASS_NM_CONTROLLER,
                joukenId,
                LOGGER_INFO_STR,
                string.Join(ReportConst.PARAM_SEPARATOR, new string[]{
                        ReportConst.PARAM_NAME_USER_ID + ReportConst.PARAM_NAME_VALUE_SEPARATOR + userId,
                        ReportConst.PARAM_NAME_JOUKEN_ID + ReportConst.PARAM_NAME_VALUE_SEPARATOR + joukenId,
                        ReportConst.PARAM_NAME_TODOFUKEN_CD + ReportConst.PARAM_NAME_VALUE_SEPARATOR + todofukenCd,
                        ReportConst.PARAM_NAME_KUMIAITO_CD + ReportConst.PARAM_NAME_VALUE_SEPARATOR + kumiaitoCd,
                        ReportConst.PARAM_NAME_SHISHO_CD + ReportConst.PARAM_NAME_VALUE_SEPARATOR + shishoCd,
                        ReportConst.PARAM_NAME_SHISHO_LIST_CD + ReportConst.PARAM_NAME_VALUE_SEPARATOR +
                        (shishoList.IsNullOrEmpty() ? string.Empty : string.Join(ReportConst.SYMBOL_COMMA, shishoList)),
                        ReportConst.PARAM_NAME_BATCH_FLAG + ReportConst.PARAM_NAME_VALUE_SEPARATOR + batchFlag,
                        ReportConst.PARAM_NAME_FILE_PATH + ReportConst.PARAM_NAME_VALUE_SEPARATOR + filePath,
                        ReportConst.PARAM_NAME_BATCH_ID + ReportConst.PARAM_NAME_VALUE_SEPARATOR + (batchId == null ? string.Empty : batchId.ToString())})));

            // 実行結果
            var result = new ControllerResult();
            try
            {
                // 引数チェック
                result = CheckParams(result, userId, joukenId, todofukenCd, kumiaitoCd, shishoCd, shishoList, batchFlag, filePath);
                if (ReportConst.RESULT_FAILED.Equals(result.Result))
                {
                    return result;
                }

                // 帳票出力条件を取得する。
                // 条件IDをキーに帳票条件テーブルより帳票出力条件を取得する。
                // 取得結果が0件の場合はエラーとし、エラーメッセージを返す。
                var reportJoukens = GetReportJouken(getJigyoDb<BaseAppContext>(), joukenId);
                if (reportJoukens.IsNullOrEmpty())
                {
                    return result.ControllerResultError(string.Empty, "ME90010");
                }

                // 帳票出力対象とする農業者IDを取得する。
                // 引数：バッチフラグが0（リアルタイム）の場合
                if (ReportConst.REPORT_REALTIME.Equals(batchFlag))
                {
                    // 帳票オブジェクト
                    var report = new BaseSectionReport();
                    // 取得したデータから作成対象とする帳票データを取得する。
                    var p1002ModelList = GetRealReportDataList(reportJoukens, todofukenCd, kumiaitoCd, shishoCd, shishoList, ReportConst.REPORT_REALTIME);
                    // 取得結果が0件の場合は、エラーとし、エラーメッセージを返す。
                    // （メッセージID:MI00012）
                    if (p1002ModelList.IsNullOrEmpty())
                    {
                        return result.ControllerResultError(string.Empty, "MI00012");
                    }

                    // 帳票出力処理を呼び出す。
                    result = CreateP1002(p1002ModelList, joukenId, ref report);
                    if (result.Result == ReportConst.RESULT_FAILED)
                    {
                        return result;
                    }

                    // 処理結果を返す
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        pdfExport.Export(report.Document, memoryStream);

                        result.Result = ReportConst.RESULT_SUCCESS;
                        result.ReportData = memoryStream;
                    }
                }

                // 引数：バッチフラグが1（バッチ）の場合
                if (ReportConst.REPORT_BATCH.Equals(batchFlag))
                {
                    var dicNendoNogyoshaId = new Dictionary<List<int>, short>();
                    // 取得したデータから作成対象とする帳票データの集約単位リストを取得する。
                    // 取得結果が0件の場合は、エラーとし、エラーメッセージを返す。
                    // （メッセージID:MI00012）
                    var groupInfoList = GetGroupInfoList(reportJoukens, todofukenCd, kumiaitoCd, shishoCd, shishoList, ReportConst.REPORT_BATCH);
                    if (groupInfoList.IsNullOrEmpty())
                    {
                        return result.ControllerResultError(string.Empty, "MI00012");
                    }

                    var splitZumiNogyoshaIdList = new List<List<int>>();
                    // 集約単位リストの数分、以下の処理を繰り返す。
                    foreach (var groupInfo in groupInfoList)
                    {
                        // 帳票データの農業者IDを取得する。
                        var nogyoshaIdList = GetNogyoshaIdList(reportJoukens, groupInfo);

                        // 処理分割件数（定数ID：H002SplitCount）
                        var splitCount = ConfigUtil.GetInt(ReportConst.H002_SPLIT_COUNT);
                        var spiltList = SplitList(nogyoshaIdList, splitCount);
                        // 帳票出力用年度情報を保存
                        foreach (var item in spiltList)
                        {
                            dicNendoNogyoshaId.Add(item, groupInfo.Nendo);
                        }
                        splitZumiNogyoshaIdList.AddRange(spiltList);
                    }

                    // 帳票PDF一時出力フォルダ作成
                    // 引数：バッチフラグが1（バッチ）の場合
                    // 以下の帳票PDF一時出力フォルダを作成する。
                    // 定数取得(（定数ID：PrintTempFolder）)\ユーザID_グローバル一意識別子(GUID)\（引数：帳票パスのファイル名（拡張子を除く））
                    // （例）引数：帳票パスがC:\aaa\bbb\ccc\tyouhyou.zipの場合
                    // 出力フォルダは、定数取得(（定数ID：PrintTempFolder）)\ユーザID_91b84368272946718288a66acc9e078f\tyouhyou
                    var printTempFolder = ReportLibrary.Core.Utility.FolderUtil.CreatePrintTempFolder(userId, filePath);

                    //  分割後農業者IDリストの数分、以下の処理を繰り返す。
                    for (var i = 0; i < splitZumiNogyoshaIdList.Count; i++)
                    {
                        // 帳票オブジェクト
                        var report = new BaseSectionReport();
                        var nogyoIdList = splitZumiNogyoshaIdList[i];
                        // 分割後農業者IDリスト内の農業者IDを条件に、「加入者情報（単票）」の帳票データを取得する。
                        var p1002ModelList = GetReportData(reportJoukens, nogyoIdList, dicNendoNogyoshaId);

                        // 帳票出力処理を呼び出す。
                        result = CreateP1002(p1002ModelList, joukenId, ref report);
                        if (result.Result == ReportConst.RESULT_FAILED)
                        {
                            return result;
                        }

                        // 分割後農業者IDリストの数が1つの場合
                        if (splitZumiNogyoshaIdList.Count == 1)
                        {
                            // ファイル名は「11_加入者情報（単票）.PDF」とする。
                            pdfExport.Export(report.Document, Path.Combine(printTempFolder, "11_加入者情報（単票）" + ReportConst.REPORT_EXTENSION));
                        }
                        else
                        {
                            // ファイル名は「11_加入者情報（単票）_分割後農業者IDリスト連番.PDF」とする。
                            pdfExport.Export(report.Document, Path.Combine(printTempFolder, "11_加入者情報（単票）_" + (i + 1).ToString("D3") + ReportConst.REPORT_EXTENSION));
                        }
                    }

                    // バッチフラグが1（バッチ）である場合
                    // PDF出力用一時フォルダをzip化（暗号化）する。
                    var zipFilePath = ReportLibrary.Core.Utility.ZipUtil.CreateZip(printTempFolder);

                    // Zipファイルを引数：帳票パスに移動する
                    ReportLibrary.Core.Utility.FolderUtil.MoveFile(zipFilePath, filePath, userId, (batchId ?? 0));

                    // PDF出力用一時フォルダを削除する
                    ReportLibrary.Core.Utility.FolderUtil.DeletePrintTempFolder(printTempFolder);
                }

                result.Result = ReportConst.RESULT_SUCCESS;
            }
            catch (Exception)
            {
                // 法定帳票などと制御クラスの構造を統一するため、ここで例外をキャッチする
                throw;
            }

            // ログ出力(終了)
            logger.Info(string.Format(
                ReportConst.METHOD_END_LOG,
                ReportConst.CLASS_NM_CONTROLLER,
                joukenId,
                LOGGER_INFO_STR));

            return result;
        }
        #endregion

        #region 「P1002_加入者情報（単票）」を作成するメソッド
        /// <summary>
        /// 「P1002_加入者情報（単票）」を作成するメソッド
        /// </summary>
        /// <param name="model">帳票モデルリスト</param>
        /// <param name="joukenId">条件ID</param>
        /// <param name="report">帳票オブジェクト</param>
        /// <returns>実行結果</returns>
        private ControllerResult CreateP1002(
            List<P1002Model> model,
            int joukenId,
            ref BaseSectionReport report)
        {
            // データ編集処理
            model.ForEach(t =>
            {
                // 年度
                t.NendoJa = DateUtil.GetReportJapaneseYear(t.Nendo);
                t.KanyuShinseiYmdJaYY = DateUtil.GetReportJapaneseYear(t.KanyuShinseiYmd);
                t.KanyuShinseiYmdMM = DateUtil.FormatMonthByDateTime(t.KanyuShinseiYmd);
                t.KanyuShinseiYmdDD = DateUtil.FormatDayByDateTime(t.KanyuShinseiYmd);
            });

            // 実行結果
            var result = new ControllerResult();
            P1002Creator p1002Creator = new P1002Creator();
            CreatorResult creatorResult = p1002Creator.CreateReport(joukenId, model);
            // 失敗した場合
            if (creatorResult.Result == ReportConst.RESULT_FAILED)
            {
                return result.ControllerResultError(creatorResult.ErrorMessage, creatorResult.ErrorMessageId);
            }

            // ページ番号を描画する
            creatorResult.SectionReport = ReportPagerUtil.DrawReportPageNumber(creatorResult.SectionReport, ReportConst.REPORT_BOTTOM_MARGIN_STANDARD);
            // 出力レポートにP1002_加入者情報（単票）を入れる。
            report.Document.Pages.AddRange(creatorResult.SectionReport.Document.Pages);

            return result;
        }
        #endregion

        #region 引数チェック
        /// <summary>
        /// H002_加入者情報（単票）引数チェック
        /// </summary>
        /// <param name="result">実行結果</param>
        /// <param name="userId">ユーザーID</param>
        /// <param name="joukenId">条件ID</param>
        /// <param name="todofukenCd">都道府県コード</param>
        /// <param name="kumiaitoCd">組合等コード</param>
        /// <param name="shishoCd">支所コード</param>
        /// <param name="shishoList">利用可能支所一覧</param>
        /// <param name="batchFlag">バッチフラグ（リアルタイム帳票：0、バッチ帳票：1）</param>
        /// <param name="filePath">帳票パス</param>
        /// <returns>実行結果</returns>
        private ControllerResult CheckParams(ControllerResult result, string userId, int joukenId, string todofukenCd, string kumiaitoCd, string shishoCd,
            List<string> shishoList, int batchFlag, string filePath)
        {
            // ■１．引数チェックする
            // ユーザIDがないの場合、エラーとし、エラーメッセージを返す
            if (string.IsNullOrEmpty(userId))
            {
                return result.ControllerResultError(string.Empty, "ME90009", ReportConst.PARAM_NAME_USER_ID);
            }

            // 条件IDがないの場合、エラーとし、エラーメッセージを返す
            if (joukenId == 0)
            {
                return result.ControllerResultError(string.Empty, "ME90009", ReportConst.PARAM_NAME_JOUKEN_ID);
            }

            // バッチフラグが0（リアルタイム）、または1（バッチ）以外の場合、エラーとし、エラーメッセージを返す
            if (!ReportConst.REPORT_REALTIME.Equals(batchFlag) && !ReportConst.REPORT_BATCH.Equals(batchFlag))
            {
                return result.ControllerResultError(string.Empty, "ME90012", ReportConst.PARAM_NAME_BATCH_FLAG);
            }

            // バッチフラグが1（バッチ）、且つ帳票パスがない場合、エラーとし、エラーメッセージを返す
            if (batchFlag == ReportConst.REPORT_BATCH && string.IsNullOrEmpty(filePath))
            {
                return result.ControllerResultError(string.Empty, "ME90009", ReportConst.PARAM_NAME_FILE_PATH);
            }

            // バッチフラグが0（リアルタイム）の場合
            if (ReportConst.REPORT_REALTIME.Equals(batchFlag))
            {
                // 都道府県コードがない場合、エラーとし、エラーメッセージを返す。
                if (string.IsNullOrEmpty(todofukenCd))
                {
                    return result.ControllerResultError(string.Empty, "ME90009", ReportConst.PARAM_NAME_TODOFUKEN_CD);
                }

                // 組合等コードがない場合、エラーとし、エラーメッセージを返す。
                if (string.IsNullOrEmpty(kumiaitoCd))
                {
                    return result.ControllerResultError(string.Empty, "ME90009", ReportConst.PARAM_NAME_KUMIAITO_CD);
                }

                // バッチフラグが0（リアルタイム）の場合、コードの整合性チェックをする
                // 「都道府県コード存在情報」を取得する。
                // （１）データが取得できない場合（該当データがマスタデータに登録されていない場合）、エラーとし、エラーメッセージを返す。
                // （"{0}に、{1}に存在しないコードが存在します。"　引数{0} ：都道府県コード、引数{1} ：都道府県マスタ)
                logger.Info("「都道府県コード存在情報」を取得する。");
                var todofukenCnt = getJigyoDb<BaseAppContext>().VTodofukens.Where(t => t.TodofukenCd == todofukenCd).Count();
                if (todofukenCnt == 0)
                {
                    return result.ControllerResultError(string.Empty, "ME91003", ReportConst.PARAM_NAME_TODOFUKEN_CD, "都道府県マスタ");
                }

                // 「組合等コード存在情報」を取得する。
                // （１）データが取得できない場合（該当データがマスタデータに登録されていない場合）、エラーとし、エラーメッセージを返す。
                // （"{0}に、{1}に存在しないコードが存在します。"　引数{0} ：組合等コード、引数{1} ：組合等マスタ)
                logger.Info("「組合等コード存在情報」を取得する。");
                var kumiaitoCnt = getJigyoDb<BaseAppContext>().VKumiaitos.Where(t => t.TodofukenCd == todofukenCd && t.KumiaitoCd == kumiaitoCd).Count();
                if (kumiaitoCnt == 0)
                {
                    return result.ControllerResultError(string.Empty, "ME91003", ReportConst.PARAM_NAME_KUMIAITO_CD, "組合等マスタ");
                }

                // 引数：利用可能支所一覧が入力されている場合、「利用可能支所一覧存在情報」を取得する。
                // （１）データが取得できない場合（該当データがマスタデータに登録されていない場合）、エラーとし、エラーメッセージを返す。
                // （"{0}に、{1}に存在しないコードが存在します。"　引数{0} ：利用可能支所一覧、引数{1} ：名称M支所)
                if (!shishoList.IsNullOrEmpty())
                {
                    logger.Info("「利用可能支所一覧存在情報」を取得する。");
                    var shishoCnt = getJigyoDb<BaseAppContext>().VShishoNms.Where(t => t.TodofukenCd == todofukenCd && t.KumiaitoCd == kumiaitoCd && shishoList.Contains(t.ShishoCd)).Count();
                    if (shishoCnt == 0)
                    {
                        return result.ControllerResultError(string.Empty, "ME91003", ReportConst.PARAM_NAME_SHISHO_LIST_CD, "名称M支所");
                    }
                }

                // 引数：支所コードが入力されている場合、「支所コード存在情報」を取得する。
                // （１）データが取得できない場合（該当データがマスタデータに登録されていない場合）、エラーとし、エラーメッセージを返す。
                //（"{0}に、{1}に存在しないコードが存在します。"　引数{0} ：支所コード、引数{1} ：名称M支所)
                if (!string.IsNullOrEmpty(shishoCd))
                {
                    logger.Info("「支所コード存在情報」を取得する。");
                    var shishoCnt = getJigyoDb<BaseAppContext>().VShishoNms.Where(t => t.TodofukenCd == todofukenCd && t.KumiaitoCd == kumiaitoCd && t.ShishoCd == shishoCd).Count();
                    if (shishoCnt == 0)
                    {
                        return result.ControllerResultError(string.Empty, "ME91003", ReportConst.PARAM_NAME_SHISHO_CD, "名称M支所");
                    }
                }
            }

            return result;
        }
        #endregion

        #region リアルタイム帳票データ取得メソッド
        /// <summary>
        /// 作成対象とするリアルタイム帳票データを取得する。
        /// </summary>
        /// <param name="reportJoukens">条件情報</param>
        /// <param name="todofukenCd">都道府県コード</param>
        /// <param name="kumiaitoCd">組合等コード</param>
        /// <param name="shishoCd">支所コード</param>
        /// <param name="shishoList">利用可能支所一覧</param>
        /// <param name="batchFlag">バッチフラグ（リアルタイム帳票：0、バッチ帳票：1）</param>
        /// <returns>帳票データ</returns>
        private List<P1002Model> GetRealReportDataList(List<TReportJouken> reportJoukens, string todofukenCd, string kumiaitoCd, string shishoCd, List<string> shishoList, int batchFlag)
        {
            // sql用定数定義
            var sql = new StringBuilder();
            var parameters = new List<NpgsqlParameter>();

            // 検索項目を取得する
            GetCondition(sql);
            // 検索テーブルを取得する
            GetReportDataTableCondition(sql);
            // 検索条件を取得する
            GetSearchCondition(sql, reportJoukens, todofukenCd, kumiaitoCd, shishoCd, shishoList, batchFlag, parameters);
            // ソート順を追加する
            GetOrderby(ref sql, reportJoukens);

            logger.Info("作成対象とする帳票データを取得する。");
            return getJigyoDb<BaseAppContext>().Database.SqlQueryRaw<P1002Model>(sql.ToString(), parameters.ToArray()).ToList();
        }
        #endregion

        #region 帳票データの集約単位リスト取得メソッド
        /// <summary>
        /// 作成対象とする帳票データの集約単位リストを取得する。
        /// </summary>
        /// <param name="reportJoukens">条件情報</param>
        /// <param name="todofukenCd">都道府県コード</param>
        /// <param name="kumiaitoCd">組合等コード</param>
        /// <param name="shishoCd">支所コード</param>
        /// <param name="shishoList">利用可能支所一覧</param>
        /// <param name="batchFlag">バッチフラグ（リアルタイム帳票：0、バッチ帳票：1）</param>
        /// <returns>年度リスト</returns>
        private List<H002GroupInfoModel> GetGroupInfoList(List<TReportJouken> reportJoukens, string todofukenCd, string kumiaitoCd, string shishoCd, List<string> shishoList, int batchFlag)
        {
            // sql用定数定義
            var sql = new StringBuilder();
            var parameters = new List<NpgsqlParameter>();

            // 検索項目を取得する
            sql.Append("SELECT ");
            sql.Append("    t_kanyusha.nendo AS Nendo ");
            sql.Append("    , v_nogyosha.todofuken_cd AS TodofukenCd ");
            sql.Append("    , v_nogyosha.kumiaito_cd AS KumiaitoCd ");
            sql.Append("    , v_nogyosha.shisho_cd AS ShishoCd ");
            // 検索テーブルを取得する
            GetTableCondition(sql);
            // 検索条件を取得する
            GetSearchCondition(sql, reportJoukens, todofukenCd, kumiaitoCd, shishoCd, shishoList, batchFlag, parameters);
            // group by
            sql.Append("    GROUP BY t_kanyusha.nendo ");
            sql.Append("    , v_nogyosha.todofuken_cd ");
            sql.Append("    , v_nogyosha.kumiaito_cd ");
            sql.Append("    , v_nogyosha.shisho_cd ");
            // ソート順
            sql.Append("    ORDER BY t_kanyusha.nendo ASC ");
            sql.Append("    , v_nogyosha.todofuken_cd ASC  ");
            sql.Append("    , v_nogyosha.kumiaito_cd ASC  ");
            sql.Append("    , v_nogyosha.shisho_cd ASC  ");

            logger.Info("作成対象とする帳票データの集約単位リストを取得する。（集約条件：t_kanyusha.nendo、v_nogyosha.todofuken_cd、v_nogyosha.kumiaito_cd、v_nogyosha.shisho_cd）");
            return getJigyoDb<BaseAppContext>().Database.SqlQueryRaw<H002GroupInfoModel>(sql.ToString(), parameters.ToArray()).ToList();
        }
        #endregion

        #region 帳票データの農業者ID取得メソッド
        /// <summary>
        /// 分割条件（年度、都道府県コード、組合等コード、支所コード）の帳票データの農業者IDを取得する。
        /// </summary>
        /// <param name="reportJoukens">条件情報</param>
        /// <param name="todofukenCd">都道府県コード</param>
        /// <param name="kumiaitoCd">組合等コード</param>
        /// <param name="shishoCd">支所コード</param>
        /// <param name="shishoList">利用可能支所一覧</param>
        /// <param name="batchFlag">バッチフラグ（リアルタイム帳票：0、バッチ帳票：1）</param>
        /// <param name="nendo">年度</param>
        /// <returns>分割条件の帳票データの農業者ID</returns>
        private List<int> GetNogyoshaIdList(List<TReportJouken> reportJoukens, H002GroupInfoModel groupInfo)
        {
            // sql用定数定義
            var sql = new StringBuilder();
            var parameters = new List<NpgsqlParameter>();

            // 検索項目を取得する
            sql.Append("SELECT ");
            sql.Append("    v_nogyosha.nogyosha_id AS \"Value\" ");
            // 検索テーブルを取得する
            GetTableCondition(sql);
            // 検索条件を取得する
            sql.Append("WHERE t_kanyusha.nendo = @Nendo ");
            parameters.Add(new NpgsqlParameter("@Nendo", groupInfo.Nendo));

            // 都道府県
            if (!string.IsNullOrEmpty(groupInfo.TodofukenCd))
            {
                sql.Append("AND v_nogyosha.todofuken_cd = @TodofukenCd ");
                parameters.Add(new NpgsqlParameter("@TodofukenCd", groupInfo.TodofukenCd));
            }

            // 組合等
            if (!string.IsNullOrEmpty(groupInfo.KumiaitoCd))
            {
                sql.Append("AND v_nogyosha.kumiaito_cd = @KumiaitoCd ");
                parameters.Add(new NpgsqlParameter("@KumiaitoCd", groupInfo.KumiaitoCd));
            }

            // 支所
            if (!string.IsNullOrEmpty(groupInfo.ShishoCd))
            {
                sql.Append("AND v_nogyosha.shisho_cd = @ShishoCd ");
                parameters.Add(new NpgsqlParameter("@ShishoCd", groupInfo.ShishoCd));
            }

            // 他の検索条件
            GetSearchConditionCompart(sql, reportJoukens, parameters, true);

            // ソート順を追加する
            GetOrderby(ref sql, reportJoukens);

            logger.Info("分割条件（年度、都道府県コード、組合等コード、支所コード）の帳票データの農業者IDを取得する。");
            return getJigyoDb<BaseAppContext>().Database.SqlQueryRaw<int>(sql.ToString(), parameters.ToArray()).ToList();
        }
        #endregion

        #region 「加入者情報（単票）」の帳票データ取得メソッド
        /// <summary>
        /// 「加入者情報（単票）」の帳票データを取得する。
        /// </summary>
        /// <param name="reportJoukens">条件情報</param>
        /// <param name="nogyoshaIdList">農業者IDリスト</param>
        /// <param name="dicNendoNogyoshaId">分割後農業者IDリスト</param>
        /// <returns>帳票データ</returns>
        private List<P1002Model> GetReportData(List<TReportJouken> reportJoukens, List<int> nogyoshaIdList, Dictionary<List<int>, short> dicNendoNogyoshaId)
        {
            // sql用定数定義
            var sql = new StringBuilder();
            var parameters = new List<NpgsqlParameter>();

            // 検索項目を取得する
            GetCondition(sql);
            // 検索テーブルを取得する
            GetReportDataTableCondition(sql);

            // 検索条件を取得する
            sql.Append("WHERE v_nogyosha.nogyosha_id = ANY(@NogyoshaIdList) ");
            parameters.Add(new NpgsqlParameter("@NogyoshaIdList", NpgsqlDbType.Array | NpgsqlDbType.Integer)
            {
                Value = nogyoshaIdList
            });

            // 年度指定がある
            sql.Append("AND t_kanyusha.nendo = @Nendo ");
            parameters.Add(new NpgsqlParameter("@Nendo", dicNendoNogyoshaId[nogyoshaIdList]));

            // 農業者ID、年度
            var jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_NOGYOSHA_ID_TARGET_NENDO).FirstOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                var tulpTableKey = TupleTableKey(jouken?.JoukenValue);
                sql.Append("AND (v_nogyosha.nogyosha_id, t_kanyusha.nendo) IN (");
                string parameterList = string.Join(", ", tulpTableKey.Select((t, i) => $"(@nogyosha_id{i}, @nendo{i})"));
                sql.Append(parameterList);
                sql.Append(")");
                for (int i = 0; i < tulpTableKey.Count; i++)
                {
                    parameters.Add(new NpgsqlParameter($"@nogyosha_id{i}", tulpTableKey[i].Item1));
                    parameters.Add(new NpgsqlParameter($"@nendo{i}", tulpTableKey[i].Item2));
                }
            }

            // ソート順を追加する
            GetOrderby(ref sql, reportJoukens);

            logger.Info("「加入者情報（単票）」の帳票データを取得する。");
            return getJigyoDb<BaseAppContext>().Database.SqlQueryRaw<P1002Model>(sql.ToString(), parameters.ToArray()).ToList();
        }
        #endregion

        #region 検索項目取得
        /// <summary>
        /// 検索項目を取得する
        /// </summary>
        /// <param name="sql">検索sql</param>
        private void GetCondition(StringBuilder sql)
        {
            sql.Append("SELECT ");
            sql.Append("    t_kanyusha.nendo AS Nendo ");
            sql.Append("    , '' AS NendoJa ");
            sql.Append("    , t_kanyusha.kanyu_shinsei_ymd AS KanyuShinseiYmd ");
            sql.Append("    , '' AS KanyuShinseiYmdJaYY ");
            sql.Append("    , '' AS KanyuShinseiYmdMM  ");
            sql.Append("    , '' AS KanyuShinseiYmdDD  ");
            sql.Append("    , t_kanyusha.kouchi_address AS KochiAddress ");
            sql.Append("    , v_nogyosha.hojin_full_nm AS HojinFullNm ");
            sql.Append("    , t_kanyusha.kanyusha_cd AS KanyushaCd ");
            sql.Append("    , v_todofuken.todofuken_nm AS TodofukenNm  ");
            sql.Append("    , v_kumiaito.kumiaito_nm AS KumiaitoNm   ");
            sql.Append("    , v_shisho_nm.shisho_nm AS ShishoNm  ");
            sql.Append("    , v_shichoson_nm.shichoson_nm AS ShichosonNm  ");
            sql.Append("    , v_daichiku_nm.daichiku_nm AS DaichikuNm  ");
            sql.Append("    , v_shochiku_nm.shochiku_nm AS ShochikuNm  ");
            sql.Append("    , t_kanyusha.kouchi_menseki AS KouchiMenseki  ");
            sql.Append("    , CASE ");
            sql.Append("        WHEN t_kanyusha.kouchi_keitai_cd = '1' ");
            sql.Append("            THEN TRUE ");
            sql.Append("        ELSE FALSE ");
            sql.Append("        END AS IsKouchiKeitaiCdHata ");
            sql.Append("    , CASE ");
            sql.Append("        WHEN t_kanyusha.kouchi_keitai_cd = '2' ");
            sql.Append("            THEN TRUE ");
            sql.Append("        ELSE FALSE ");
            sql.Append("        END AS IsKouchiKeitaiCdTa ");
            sql.Append("    , CASE ");
            sql.Append("        WHEN t_kanyusha.kouchi_keitai_cd = '3' ");
            sql.Append("            THEN TRUE ");
            sql.Append("        ELSE FALSE ");
            sql.Append("        END AS IsKouchiKeitaiCdOther ");
            sql.Append("    , CASE ");
            sql.Append("        WHEN t_kanyusha.kouchi_keitai_cd = '0' ");
            sql.Append("            THEN TRUE ");
            sql.Append("        ELSE FALSE ");
            sql.Append("        END AS IsKouchiKeitaiCdNone ");
            sql.Append("    , CASE ");
            sql.Append("        WHEN t_kanyusha.kojinjoho_toriatsukai_flg = '1' ");
            sql.Append("            THEN TRUE ");
            sql.Append("        ELSE FALSE ");
            sql.Append("        END AS KojinjohoToriatsukaiFlg ");
            sql.Append("    , t_kanyusha.biko AS Biko  ");
        }
        #endregion

        #region 検索テーブル取得（集約単位情報取得用）
        /// <summary>
        /// 検索テーブルを取得する（集約単位情報取得用）
        /// </summary>
        /// <param name="sql">検索sql</param>
        private void GetTableCondition(StringBuilder sql)
        {
            sql.Append("FROM ");
            sql.Append("    v_nogyosha ");
            sql.Append("    LEFT JOIN t_kanyusha ");
            sql.Append("        ON v_nogyosha.nogyosha_id = t_kanyusha.nogyosha_id ");
        }
        #endregion

        #region 検索テーブル取得（帳票データ取得用）
        /// <summary>
        /// 検索テーブルを取得する（帳票データ取得用）
        /// </summary>
        /// <param name="sql">検索sql</param>
        private void GetReportDataTableCondition(StringBuilder sql)
        {
            sql.Append("FROM ");
            sql.Append("    v_nogyosha ");
            sql.Append("    LEFT JOIN t_kanyusha ");
            sql.Append("        ON v_nogyosha.nogyosha_id = t_kanyusha.nogyosha_id ");
            sql.Append("    LEFT JOIN v_todofuken ");
            sql.Append("        ON v_nogyosha.todofuken_cd = v_todofuken.todofuken_cd ");
            sql.Append("    LEFT JOIN v_kumiaito ");
            sql.Append("        ON v_nogyosha.todofuken_cd = v_kumiaito.todofuken_cd ");
            sql.Append("        AND v_nogyosha.kumiaito_cd = v_kumiaito.kumiaito_cd ");
            sql.Append("    LEFT JOIN v_shisho_nm ");
            sql.Append("        ON v_nogyosha.todofuken_cd = v_shisho_nm.todofuken_cd ");
            sql.Append("        AND v_nogyosha.kumiaito_cd = v_shisho_nm.kumiaito_cd ");
            sql.Append("        AND v_nogyosha.shisho_cd = v_shisho_nm.shisho_cd ");
            sql.Append("    LEFT JOIN v_shichoson_nm ");
            sql.Append("        ON v_nogyosha.todofuken_cd = v_shichoson_nm.todofuken_cd ");
            sql.Append("        AND v_nogyosha.kumiaito_cd = v_shichoson_nm.kumiaito_cd ");
            sql.Append("        AND v_nogyosha.shichoson_cd = v_shichoson_nm.shichoson_cd ");
            sql.Append("    LEFT JOIN v_daichiku_nm ");
            sql.Append("        ON v_nogyosha.todofuken_cd = v_daichiku_nm.todofuken_cd ");
            sql.Append("        AND v_nogyosha.kumiaito_cd = v_daichiku_nm.kumiaito_cd ");
            sql.Append("        AND v_nogyosha.daichiku_cd = v_daichiku_nm.daichiku_cd ");
            sql.Append("    LEFT JOIN v_shochiku_nm ");
            sql.Append("        ON v_nogyosha.todofuken_cd = v_shochiku_nm.todofuken_cd ");
            sql.Append("        AND v_nogyosha.kumiaito_cd = v_shochiku_nm.kumiaito_cd ");
            sql.Append("        AND v_nogyosha.daichiku_cd = v_shochiku_nm.daichiku_cd ");
            sql.Append("        AND v_nogyosha.shochiku_cd = v_shochiku_nm.shochiku_cd ");
        }
        #endregion

        #region 検索条件設定処理
        /// <summary>
        /// 検索条件を設定する。
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="reportJoukens">検索条件</param>
        /// <param name="todofukenCd">都道府県コード</param>
        /// <param name="kumiaitoCd">組合等コード</param>
        /// <param name="shishoCd">支所コード</param>
        /// <param name="shishoList">利用可能支所一覧</param>
        /// <param name="batchFlag">バッチフラグ（リアルタイム帳票：0、バッチ帳票：1）</param>
        /// <param name="parameters">パラメータ</param>
        private void GetSearchCondition(StringBuilder sql, List<TReportJouken> reportJoukens, string todofukenCd, string kumiaitoCd, string shishoCd,
            List<string> shishoList, int batchFlag, List<NpgsqlParameter> parameters)
        {
            sql.Append("WHERE '1' = '1'");

            // バッチフラグが0（リアルタイム）の場合
            if (ReportConst.REPORT_REALTIME.Equals(batchFlag))
            {
                // 都道府県
                sql.Append("AND v_nogyosha.todofuken_cd = @TodofukenCd ");
                parameters.Add(new NpgsqlParameter("@TodofukenCd", todofukenCd));

                // 組合等
                sql.Append("AND v_nogyosha.kumiaito_cd = @KumiaitoCd ");
                parameters.Add(new NpgsqlParameter("@KumiaitoCd", kumiaitoCd));

                // 支所
                if (!shishoList.IsNullOrEmpty())
                {
                    // 引数：利用可能支所一覧がある場合
                    sql.Append("AND v_nogyosha.shisho_cd = ANY (@ShishoList) ");
                    parameters.Add(new NpgsqlParameter("@ShishoList", NpgsqlDbType.Array | NpgsqlDbType.Varchar)
                    {
                        Value = shishoList
                    });
                }
                else if (!string.IsNullOrEmpty(shishoCd))
                {
                    // 引数：利用可能支所一覧がない、かつ、引数：支所コードが空でない場合
                    sql.Append("AND v_nogyosha.shisho_cd = @ShishoCd_1 ");
                    parameters.Add(new NpgsqlParameter("@ShishoCd_1", shishoCd));
                }
            }

            TReportJouken jouken = null;
            // バッチフラグが1（バッチ）の場合
            if (ReportConst.REPORT_BATCH.Equals(batchFlag))
            {
                // 都道府県
                jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_TODOFUKEN).SingleOrDefault();
                if (!string.IsNullOrEmpty(jouken?.JoukenValue))
                {
                    sql.Append("AND v_nogyosha.todofuken_cd = @TodofukenCd ");
                    parameters.Add(new NpgsqlParameter("@TodofukenCd", jouken.JoukenValue));
                }

                // 組合等
                jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_KUMIAITO).SingleOrDefault();
                if (!string.IsNullOrEmpty(jouken?.JoukenValue))
                {
                    sql.Append("AND v_nogyosha.kumiaito_cd = @KumiaitoCd ");
                    parameters.Add(new NpgsqlParameter("@KumiaitoCd", jouken.JoukenValue));
                }

                // 利用可能支所一覧
                jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_SHISHO_LIST).SingleOrDefault();
                if (!string.IsNullOrEmpty(jouken?.JoukenValue))
                {
                    sql.Append("AND v_nogyosha.shisho_cd = ANY (@ShishoList) ");
                    parameters.Add(new NpgsqlParameter("@ShishoList", NpgsqlDbType.Array | NpgsqlDbType.Varchar)
                    {
                        Value = new List<string>(jouken.JoukenValue.Split(",")),
                    });
                }

                // 利用可能支所一覧がない
                if (string.IsNullOrEmpty(jouken?.JoukenValue))
                {
                    // 支所（ログインユーザのセッション）
                    jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_SESSION_SHISHO).SingleOrDefault();
                    if (!string.IsNullOrEmpty(jouken?.JoukenValue))
                    {
                        // 利用可能支所一覧がない、かつ、支所コードが空でない場合
                        sql.Append("AND v_nogyosha.shisho_cd = @ShishoCd_1 ");
                        parameters.Add(new NpgsqlParameter("@ShishoCd_1", jouken.JoukenValue));
                    }
                }
            }

            // 対象年度（開始）
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_TARGET_NENDO_FROM).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND t_kanyusha.nendo >= @NendoFrom ");
                parameters.Add(new NpgsqlParameter("@NendoFrom", short.Parse(jouken.JoukenValue)));
            }

            // 対象年度（終了）
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_TARGET_NENDO_TO).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND t_kanyusha.nendo <= @NendoTo ");
                parameters.Add(new NpgsqlParameter("@NendoTo", short.Parse(jouken.JoukenValue)));
            }

            GetSearchConditionCompart(sql, reportJoukens, parameters);
        }
        #endregion

        #region 検索条件設定処理の共通Part
        /// <summary>
        /// 検索条件の共通Partを設定する。
        /// </summary>
        /// <param name="sql">SQL</param>
        /// <param name="reportJoukens">検索条件</param>
        /// <param name="parameters">パラメータ</param>
        /// <param name="shishoExceptFlg">支所コード条件から除外フラグ</param>
        private void GetSearchConditionCompart(StringBuilder sql, List<TReportJouken> reportJoukens, List<NpgsqlParameter> parameters, bool shishoExceptFlg = false)
        {
            // 農業者ID、年度
            var jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_NOGYOSHA_ID_TARGET_NENDO).FirstOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                var tulpTableKey = TupleTableKey(jouken?.JoukenValue);
                sql.Append("AND (v_nogyosha.nogyosha_id, t_kanyusha.nendo) IN (");
                string parameterList = string.Join(", ", tulpTableKey.Select((t, i) => $"(@nogyosha_id{i}, @nendo{i})"));
                sql.Append(parameterList);
                sql.Append(")");
                for (int i = 0; i < tulpTableKey.Count; i++)
                {
                    parameters.Add(new NpgsqlParameter($"@nogyosha_id{i}", tulpTableKey[i].Item1));
                    parameters.Add(new NpgsqlParameter($"@nendo{i}", tulpTableKey[i].Item2));
                }
            }

            if (!shishoExceptFlg)
            {
                // 支所
                jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_SHISHO).SingleOrDefault();
                if (!string.IsNullOrEmpty(jouken?.JoukenValue))
                {
                    sql.Append("AND v_nogyosha.shisho_cd = @ShishoCd_2 ");
                    parameters.Add(new NpgsqlParameter("@ShishoCd_2", jouken.JoukenValue));
                }
            }

            // 市町村
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_SHICHOSON).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND v_nogyosha.shichoson_cd = @ShichosonCd ");
                parameters.Add(new NpgsqlParameter("@ShichosonCd", jouken.JoukenValue));
            }

            // 大地区
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_DAICHIKU).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND v_nogyosha.daichiku_cd = @DaichikuCd ");
                parameters.Add(new NpgsqlParameter("@DaichikuCd", jouken.JoukenValue));
            }

            // 小地区（開始）
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_SHOCHIKU_START).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND v_nogyosha.shochiku_cd >= @ShochikuCdFrom ");
                parameters.Add(new NpgsqlParameter("@ShochikuCdFrom", jouken.JoukenValue));
            }

            // 小地区（終了）
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_SHOCHIKU_END).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND v_nogyosha.shochiku_cd <= @ShochikuCdTo ");
                parameters.Add(new NpgsqlParameter("@ShochikuCdTo", jouken.JoukenValue));
            }

            // 加入者管理コード（開始）
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_KANYUSHA_CD_START).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND t_kanyusha.kanyusha_cd >= @KanyushaCdFrom ");
                parameters.Add(new NpgsqlParameter("@KanyushaCdFrom", jouken.JoukenValue));
            }

            // 加入者管理コード（終了）
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_KANYUSHA_CD_END).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                sql.Append("AND t_kanyusha.kanyusha_cd <= @KanyushaCdTo ");
                parameters.Add(new NpgsqlParameter("@KanyushaCdTo", jouken.JoukenValue));
            }

            // 氏名又は法人名
            jouken = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_HOJIN_FULL_NM).SingleOrDefault();
            if (!string.IsNullOrEmpty(jouken?.JoukenValue))
            {
                // 全角スペース、半角スペースを除く
                var hojinFullNmInput = jouken?.JoukenValue.Replace("　", "").Replace(" ", "");

                sql.Append("AND replace(replace(v_nogyosha.hojin_full_nm,'　',''),' ','')  LIKE '%' || @HojinFullNm || '%'  ESCAPE '\\' ");
                parameters.Add(new NpgsqlParameter("@HojinFullNm", StringUtil.RemoveEscapeChar(hojinFullNmInput)));
            }
        }
        #endregion

        #region クエリ式にソート順設定
        /// <summary>
        /// ソート順設定処理
        /// </summary>
        /// <param name="sb">sql</param>
        /// <param name="reportJoukens">検索条件情報</param>
        private void GetOrderby(ref StringBuilder sb, List<TReportJouken> reportJoukens)
        {
            // 表示順１
            var joukenOrderKey1 = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_ORDER_BY_KEY1).SingleOrDefault();
            var joukenOrderBy1 = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_ORDER_BY1).SingleOrDefault();

            // 表示順２
            var joukenOrderKey2 = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_ORDER_BY_KEY2).SingleOrDefault();
            var joukenOrderBy2 = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_ORDER_BY2).SingleOrDefault();

            // 表示順３
            var joukenOrderKey3 = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_ORDER_BY_KEY3).SingleOrDefault();
            var joukenOrderBy3 = reportJoukens.Where(t => t.JoukenNm == JoukenNameConst.JOUKEN_ORDER_BY3).SingleOrDefault();

            sb.Append("ORDER BY ");
            sb.Append("t_kanyusha.nendo ASC, ");
            sb.Append("v_nogyosha.todofuken_cd ASC, ");
            sb.Append("v_nogyosha.kumiaito_cd ASC, ");
            sb.Append("v_nogyosha.shisho_cd ASC, ");
            sb.Append("v_nogyosha.daichiku_cd ASC, ");
            sb.Append("v_nogyosha.shochiku_cd ASC, ");

            var constOrderList = new List<string>() { "t_kanyusha.nendo", "v_nogyosha.todofuken_cd", "v_nogyosha.kumiaito_cd", "v_nogyosha.shisho_cd", "v_nogyosha.daichiku_cd", "v_nogyosha.shochiku_cd" };
            var orderList = new List<string>();
            // 表示順キー１が空ではない場合
            if (!string.IsNullOrEmpty(joukenOrderKey1?.JoukenValue) && !constOrderList.Contains(allSortDic[joukenOrderKey1.JoukenValue]))
            {
                sb.Append(allSortDic[joukenOrderKey1.JoukenValue] + ReportConst.HALF_WIDTH_SPACE + joukenOrderBy1.JoukenValue + ReportConst.SYMBOL_COMMA);
                orderList.Add(allSortDic[joukenOrderKey1.JoukenValue]);
            }

            // 表示順キー２が空ではない場合
            if (!string.IsNullOrEmpty(joukenOrderKey2?.JoukenValue) && !constOrderList.Contains(allSortDic[joukenOrderKey2.JoukenValue]))
            {
                sb.Append(allSortDic[joukenOrderKey2.JoukenValue] + ReportConst.HALF_WIDTH_SPACE + joukenOrderBy2.JoukenValue + ReportConst.SYMBOL_COMMA);
                orderList.Add(allSortDic[joukenOrderKey2.JoukenValue]);
            }

            // 表示順キー３が空ではない場合
            if (!string.IsNullOrEmpty(joukenOrderKey3?.JoukenValue) && !constOrderList.Contains(allSortDic[joukenOrderKey3.JoukenValue]))
            {
                sb.Append(allSortDic[joukenOrderKey3.JoukenValue] + ReportConst.HALF_WIDTH_SPACE + joukenOrderBy3.JoukenValue + ReportConst.SYMBOL_COMMA);
                orderList.Add(allSortDic[joukenOrderKey3.JoukenValue]);
            }

            // 表示順キー１～３に、加入者管理コードが存在する場合はソート順から除く
            if (!orderList.Contains("t_kanyusha.kanyusha_cd"))
            {
                sb.Append("t_kanyusha.kanyusha_cd ASC ");
            }
            else
            {
                // 最後のコンマを削除する。
                sb = new StringBuilder(sb.ToString().TrimEnd(',', ' '));
            }
        }
        #endregion
    }
}
