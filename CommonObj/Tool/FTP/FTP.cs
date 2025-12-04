using System;
using System.IO;
using System.Net;

namespace CommonObj
{
    public struct FtpData
    {
        public string ftpUrl;           // FTP 檔案路徑
        public string localFilePath;    // 本地存放檔案的路徑
        public string ftpUsername;      // FTP 使用者名稱
        public string ftpPassword;
    }

    public struct FTP_RESULT 
    {
        public bool bResult;
        public string Msg;
    }

    public static class FTP
    {
        /// <summary>
        /// 下載
        /// </summary>
        public static FTP_RESULT Download(FtpData MyData)
        {
            try
            {
                // 檢查本地存放的資料夾是否存在，若不存在則建立
                string directoryPath = Path.GetDirectoryName(MyData.localFilePath);
                if (!string.IsNullOrEmpty(directoryPath) && !Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                // 建立 FTP 請求
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(MyData.ftpUrl);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // 設定 FTP 認證
                request.Credentials = new NetworkCredential(MyData.ftpUsername, MyData.ftpPassword);

                // 獲取 FTP 伺服器的回應
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                using (Stream responseStream = response.GetResponseStream())
                using (FileStream fileStream = new FileStream(MyData.localFilePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    responseStream.CopyTo(fileStream);  // 直接高效下載
                }

                return new FTP_RESULT { bResult = true, Msg = "OK" };
            }
            catch (Exception ex)
            {
                // 若下載失敗，刪除損壞的檔案
                if (File.Exists(MyData.localFilePath))
                {
                    File.Delete(MyData.localFilePath);
                }

                return new FTP_RESULT { bResult = false, Msg = ex.Message };
            }
        }
        /// <summary>
        /// 上傳
        /// </summary>
        public static FTP_RESULT Upload(FtpData MyData)
        {
            try
            {
                FileInfo fileInf = new FileInfo(MyData.localFilePath);
                // 建立 FTP 請求
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(MyData.ftpUrl);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                // 設定 FTP 認證
                request.Credentials = new NetworkCredential(MyData.ftpUsername, MyData.ftpPassword);
                request.UseBinary = true;
                request.ContentLength = fileInf.Length;
                // 獲取 FTP 伺服器的回應
                using (FileStream fileStream = fileInf.OpenRead())
                using (Stream requestStream = request.GetRequestStream())
                {
                    fileStream.CopyTo(requestStream);  // 正確地將本地檔案寫入 FTP
                }

                return new FTP_RESULT { bResult = true, Msg = "OK" };
            }
            catch (Exception ex)
            {
                return new FTP_RESULT { bResult = false, Msg = ex.Message };
            }
        }
        /// <summary>
        /// 刪除
        /// </summary>
        public static FTP_RESULT Delete(FtpData MyData)
        {
            try
            {
                // 建立 FTP 請求
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(MyData.ftpUrl);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                request.Credentials = new NetworkCredential(MyData.ftpUsername, MyData.ftpPassword);

                // 發送刪除請求
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {

                }

                return new FTP_RESULT { bResult = true, Msg = "OK" };
            }
            catch (Exception ex)
            {
                return new FTP_RESULT { bResult = false, Msg = ex.Message };
            }
        }
    }
}
