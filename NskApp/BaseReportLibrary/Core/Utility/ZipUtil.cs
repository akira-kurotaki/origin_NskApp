using CoreLibrary.Core.Utility;
using NLog;
using ReportLibrary.Core.Consts;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;

namespace ReportLibrary.Core.Utility
{
    /// <summary>
    /// ZIPのユーティリティクラス
    /// 
    /// 作成日：2017/12/11
    /// 作成者：KAN RI
    /// </summary>
    public static class ZipUtil
    {
        /// <summary>
        /// ロガー
        /// </summary>
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 指定したフォルダをZipし、暗号化する
        /// </summary>
        /// <param name="printTempFolder">帳票一時出力フォルダパス</param>
        /// <returns>zipファイルパス</returns>
        public static Dictionary<string, string> CreateZip(string printTempFolder)
        {
            // 処理時間計測用ストップウォッチ
            var stopwatch = new Stopwatch();

            // ZIP書庫のMAXサイズ
            var zipMaxSize = long.Parse(ConfigUtil.Get(ReportConst.ZIP_MAX_SIZE_TAG_NAME)) * 1024 * 1024;

            // ZIPファイルパス
            var zipFilePath = printTempFolder + DateUtil.GetSysDateTime().ToString("yyyyMMddHHmmssfff") + ".zip";

            // ■ZIP書庫作成
            logger.Info("ZIP書庫作成開始");
            stopwatch.Start();

            var pdfCountSize = 0L;
            DirectoryInfo di = new DirectoryInfo(printTempFolder);
            FileInfo[] files = di.GetFiles("*.*", SearchOption.AllDirectories);
            List<string> archivePdf = new List<string>();
            HashSet<string> archiveDirectory = new HashSet<string>();

            for (var i = 0; i < files.Length; i++)
            {
                archivePdf = new List<string>();

                //読み取りと書き込みができるようにして、ZIP書庫を開く
                using (ZipArchive zip = ZipFile.Open(zipFilePath, ZipArchiveMode.Update, Encoding.GetEncoding("Shift_JIS")))
                {
                    for (var j = i; j < files.Length; j++)
                    {
                        i = j;

                        // ZIPに追加する
                        if (di.FullName.Equals(files[j].Directory.FullName))
                        {
                            zip.CreateEntryFromFile(files[j].FullName, files[j].Name, CompressionLevel.Fastest);
                        }
                        else
                        {
                            zip.CreateEntryFromFile(files[j].FullName, Path.Combine(files[j].Directory.Name, files[j].Name), CompressionLevel.Fastest);
                            archiveDirectory.Add(files[j].DirectoryName);
                        }
                        
                        // PDFファイルサイズを加算する
                        pdfCountSize += files[j].Length;

                        archivePdf.Add(files[j].FullName);
                        
                        // 次のPDFが存在する場合
                        if (j + 1 < files.Length)
                        {
                            // ZIPファイル中のPDFサイズ + 次のPDFのサイズがZIP書庫のMAXサイズにオーバーしたかどうか 
                            if (zipMaxSize < pdfCountSize + files[j + 1].Length)
                            {
                                zipFilePath = printTempFolder + DateUtil.GetSysDateTime().ToString("yyyyMMddHHmmssfff") + ".zip";
                                pdfCountSize = 0L;
                                break;
                            }
                        }
                    }
                }

                // ZIPファイル作成済のPDFを削除する
                foreach (var item in archivePdf)
                {
                    File.Delete(item);
                }
            }
            foreach (var item in archiveDirectory)
            {
                Directory.Delete(item);
            }

            // 処理時間
            stopwatch.Stop();
            logger.Info("ZIP書庫作成終了：" + stopwatch.ElapsedMilliseconds.ToString());

            // ■ZIP書庫をリネームする
            logger.Info("ZIP書庫リネーム開始");
            stopwatch.Restart();
            DirectoryInfo zipDi = new DirectoryInfo(printTempFolder).Parent;
            FileInfo[] zipFiles = zipDi.GetFiles("*.zip", SearchOption.TopDirectoryOnly);

            if (zipFiles.Length > 1)
            {
                for (var i = 0; i < zipFiles.Length; i++)
                {
                    zipFilePath = string.Format("{0}_{1:0000}.zip", printTempFolder, i + 1);
                    File.Move(zipFiles[i].FullName, zipFilePath);
                }
            }
            else
            {
                zipFilePath = printTempFolder + ".zip";
                File.Move(zipFiles[0].FullName, zipFilePath);
            }
            // 処理時間
            stopwatch.Stop();
            logger.Info("ZIP書庫リネーム終了：" + stopwatch.ElapsedMilliseconds.ToString());

            // ■ZIP書庫を暗号化する
            logger.Info("ZIP書庫を暗号化する開始");
            stopwatch.Restart();

            Dictionary<string, string> zipFilePaths = new Dictionary<string, string>();
            FileInfo[] encryptZipFiles = zipDi.GetFiles("*.zip", SearchOption.TopDirectoryOnly);

            foreach (var item in encryptZipFiles)
            {
                byte[] fileData = null;
                var hash = string.Empty;

                using (var fileStream = new FileStream(item.FullName, FileMode.Open, FileAccess.Read))
                {
                    byte[] data = new byte[fileStream.Length];
                    fileStream.Read(data, 0, data.Length);

                    // 暗号化前のファイルのハッシュ値を取得する。
                    hash = CryptoUtil.GetSHA256Hex(data);

                    // ファイル暗号化する。
                    fileData = CryptoUtil.Encrypt(data, Path.GetFileName(item.FullName));
                }

                using (var fileStreamWrite = new FileStream(item.FullName, FileMode.Create, FileAccess.Write))
                {
                    fileStreamWrite.Write(fileData, 0, fileData.Length);
                }

                // キーをzipファイルパス、valueはzipファイル暗号化前のhash値
                zipFilePaths.Add(item.FullName, hash);
            }
            // 処理時間
            stopwatch.Stop();
            logger.Info("ZIP書庫を暗号化する終了：" + stopwatch.ElapsedMilliseconds.ToString());

            return zipFilePaths;
        }
    }
}
