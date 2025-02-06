using System.IO.Compression;
using System.Text;

namespace CoreLibrary.Core.Utility
{
    /// <summary>
    /// Zip関連ユーティリティ
    /// </summary>
    public static class ZipUtil
    {
        /// <summary>
        /// 指定したフォルダをZip化する
        /// </summary>
        /// <param name="path">zip化されるフォルダのパス</param>
        /// <param name="destination">zip アーカイブを格納するストリーム</param>
        public static void CreateZip(string path, Stream destination)
        {
            // ZIP書庫を作成する
            ZipFile.CreateFromDirectory(
                path,
                destination,
                CompressionLevel.Fastest,
                false, Encoding.GetEncoding("Shift_JIS"));
        }
    }
}
