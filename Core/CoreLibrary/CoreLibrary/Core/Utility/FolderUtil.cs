using CoreLibrary.Core.Consts;
using Microsoft.VisualBasic.FileIO;

namespace CoreLibrary.Core.Utility
{
    /// <summary>
    /// フォルダ関連ユーティリティ
    /// </summary>
    public static class FolderUtil
    {
        /// <summary>
        /// CSVの一時出力フォルダを作成
        /// </summary>
        /// <param name="sysDateTime">システム日時</param>
        /// <param name="zipFileNm">zipファイル名</param>
        /// <returns>作成されたCSV一時出力フォルダパス</returns>
        public static string CreateCsvTempFolder(DateTime sysDateTime, string zipFileNm)
        {
            // 定数（設定ファイル）：CSV一時出力フォルダ\yyyyMMdd\HHmmss\（GUIDを生成したフォルダ名）\zipファイル名（引数）の拡張子以外
            var tempFolder = Path.Combine(
                ConfigUtil.Get(CoreConst.CSV_TEMP_FOLDER),
                sysDateTime.ToString("yyyyMMdd"),
                sysDateTime.ToString("HHmmss"),
                System.Guid.NewGuid().ToString(),
                Path.GetFileNameWithoutExtension(zipFileNm));

            FileSystem.CreateDirectory(tempFolder);

            return tempFolder;
        }
    }
}
