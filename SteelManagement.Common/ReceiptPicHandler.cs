using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using NPOI.SS.Formula.Functions;
using SteelManagement.Common;
using SteelManagement.Common.FTP;

namespace SteelManagement.Common.PictureHandler
{
    public static class ReceiptPicHandler
    {
        public static string RemoteRootPath
        {
            get
            {
                string path = AppSettingHandler.ReadConfig("RemoteReceiptPicPath");
                if (string.IsNullOrEmpty(path)) //如果没读到就返回默认值
                {
                    AppSettingHandler.AddConfig("RemoteReceiptPicPath", "E:/东瀛假日签证识别管理系统/高拍仪图像保存路径");
                    return "E:/东瀛假日签证识别管理系统/高拍仪图像保存路径";
                }
                return path;
            }
        }


        public static List<string> GetFolderList()
        {
            FtpHandler.ChangeFtpUri(RemoteRootPath);
            var list = FtpHandler.GetDirectoryList();
            return list;
        }





        /// <summary>
        /// 传入文件名格式: 20171228/xxxx.jpg
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static Image GetImage(string filename)
        {
            //FtpHandler.ChangeFtpUri(RemoteRootPath);
            if (!CheckLocalExist(filename))
            {
                //if (!FtpHandler.Download(GlobalUtils.LocalReceiptPicPath, filename)) //就不检查存在与否了，直接看下载成功没有
                return null;
            }
            return GlobalUtils.LoadImageFromFileNoBlock(GlobalUtils.LocalReceiptPicPath + "\\" + filename);
        }

        /// <summary>
        /// 传入文件名格式: 20171228/xxxx.jpg
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static void DownloadGaoPaiImage(string filename, string savefilename)
        {
            GetImage(filename).Save(savefilename);
        }

        /// <summary>
        /// 传入文件名格式: 20171228/xxxx.jpg
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static void DownloadGaoPaiImageBatch(List<string> filenames, string savePath)
        {
            if (string.IsNullOrEmpty(savePath))
                return;
            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            for (int i = 0; i < filenames.Count; i++)
            {
                GetImage(filenames[i]).Save(savePath + "\\" + Path.GetFileName(filenames[i]));
            }
        }

        /// <summary>
        /// 有路径和没路径的都支持
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static string GetThumbName(string filename)
        {
            string dstName = "thumb_" + Path.GetFileName(filename);
            string path = Path.GetDirectoryName(filename);
            if (filename.Contains("\\"))
            {
                return path + "\\" + dstName;
            }
            if (filename.Contains("/"))
            {

                return path + "/" + dstName;
            }
            return dstName;
        }


        /// <summary>
        /// 检查本地是否存在，
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static bool CheckLocalExist(string filename)
        {
            string picName = GlobalUtils.LocalReceiptPicPath + "\\" + filename;
            return File.Exists(picName);
        }


        //public static bool CheckAndDownloadIfNotExist(string passportNo, PassportPicHandler.PicType type)
        //{
        //    FtpHandler.ChangeFtpUri(ConfigurationManager.AppSettings["PassportPicPath"]);
        //    string fileName = GetFileName(passportNo, type);
        //    if (CheckLocalExist(passportNo, type)) //先检查本地是否存在
        //        return true;

        //    if (FtpHandler.FileExist(fileName))
        //        if (FtpHandler.Download(GlobalUtils.LocalPassportPicPath, fileName))
        //        {
        //            return true;
        //        }
        //    return false;
        //}


    }
}