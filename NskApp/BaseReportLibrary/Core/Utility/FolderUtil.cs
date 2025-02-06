using CoreLibrary.Core.Utility;
using Microsoft.VisualBasic.FileIO;
using ModelLibrary.Models;
using NLog;
using ReportLibrary.Core.Consts;
using System.Collections.Generic;
using System.IO;

namespace ReportLibrary.Core.Utility
{
    /// <summary>
    /// フォルダアクセスのユーティリティクラス
    /// 
    /// 作成日：2017/12/11
    /// 作成者：KAN RI
    /// </summary>
    public static class FolderUtil
    {
        /// <summary>
        /// ロガー
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 帳票一時出力フォルダを作成
        /// </summary>
        /// <param name="userId">ユーザID</param>
        /// <param name="filePath">帳票パス</param>
        /// <returns>作成された帳票一時出力フォルダパス</returns>
        public static string CreatePrintTempFolder(string userId, string filePath)
        {
            var tempFolder = Path.Combine(
                ConfigUtil.Get(ReportConst.PRINT_TEMP_FOLDER_TAG_NAME),
                userId + "_" + System.Guid.NewGuid().ToString("N"),
                Path.GetFileNameWithoutExtension(filePath));

            FileSystem.CreateDirectory(tempFolder);

            return tempFolder;
        }

        /// <summary>
        /// ファイル移動
        /// </summary>
        /// <param name="zipFilePath">ZIPファイルパスリスト(キー：ファイルパス、value:暗号化前のzipファイルのハッシュ)</param>
        /// <param name="filePath">帳票パス</param>
        /// <param name="userId">ユーザID</param>
        /// <param name="batchId">バッチID</param>
        public static void MoveFile(Dictionary<string, string> zipFilePath, string filePath, string userId, long batchId)
        {
            // 移動先フォルダが存在しない場合、作成する
            FileInfo file = new FileInfo(filePath);
            if (!Directory.Exists(file.DirectoryName))
            {
                FileSystem.CreateDirectory(file.DirectoryName);
            }

            // 移動先のファイルがすでに存在する場合、削除する
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            // ファイル移動
            foreach (var item in zipFilePath)
            {
                FileInfo zipFileInfo = new FileInfo(item.Key);
                var zipFilePathNew = Path.Combine(file.DirectoryName, zipFileInfo.Name);

                if (File.Exists(zipFilePathNew))
                {
                    File.Delete(zipFilePathNew);
                }

                zipFileInfo.MoveTo(zipFilePathNew);

                // バッチダウンロードファイル登録
                try
                {
                    var message = string.Empty;
                    var reult = BatchUtil.InsertBatchDownloadFile(batchId, zipFilePathNew, item.Value, zipFileInfo.Name, userId, ref message);
                    if(reult == 0)
                    {
                        if (File.Exists(zipFilePathNew))
                        {
                            File.Delete(zipFilePathNew);
                        }
                        throw new ApplicationException("バッチダウンロードファイルの登録に失敗しました。");
                    }
                }
                catch (Exception)
                {
                    if (File.Exists(zipFilePathNew))
                    {
                        File.Delete(zipFilePathNew);
                    }
                    throw;
                }   
            }
        }

        /// <summary>
        /// 帳票一時出力フォルダを削除する
        /// </summary>
        /// <param name="printTempFolder">帳票一時出力フォルダパス</param>
        public static void DeletePrintTempFolder(string printTempFolder)
        {
            Directory.Delete((new DirectoryInfo(printTempFolder)).Parent.FullName, true);
        }
    }
}