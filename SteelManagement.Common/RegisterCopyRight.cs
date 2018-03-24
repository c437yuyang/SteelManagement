using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelManagement.Common
{
    public class RegisterCopyRight : ICopyRight
    {
        private const string KEY_NAME = "SteelManagement";
        public bool CheckAvailable()
        {
            RegistryKey RootKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey RegKey = RootKey.OpenSubKey(KEY_NAME, true);
            if (RegKey == null) //第一次使用
            {
                RootKey.CreateSubKey(KEY_NAME);//不存在，则创建子项
                RegKey = RootKey.OpenSubKey(KEY_NAME, true);
                RegKey.SetValue("FirstTime", (object)DateTime.Now.ToString("yyyy/MM/dd"));    //创建键值，存储第一次使用时间

                RegKey.SetValue("Days", (object)30); //限时30天

                return true;
            }
            DateTime firstDate = DateTime.Parse(RegKey.GetValue("FirstTime").ToString());
            object obj = RegKey.GetValue("LastTime");
            if (obj == null) //第一次使用是没有的
                return true;
            DateTime lastDate = DateTime.Parse(obj.ToString());

            int days = int.Parse(RegKey.GetValue("Days").ToString());

            if ((lastDate - firstDate).Duration().TotalDays > days) //限时比较
                return false;
            return true;
        }

        void ICopyRight.UpdateUserInfo()
        {
            RegistryKey RootKey = Registry.CurrentUser.OpenSubKey("Software", true);
            RegistryKey RegKey = RootKey.OpenSubKey(KEY_NAME, true);

            object obj = RegKey.GetValue("LastTime");
            if (obj == null) //第一次使用是没有的
            {
                RegKey.SetValue("LastTime", (object)DateTime.Now.ToString("yyyy/MM/dd"));
                return;
            }
            DateTime lastDate = DateTime.Parse(obj.ToString());
            if (lastDate <= DateTime.Now) //必须是在上一次之后，才更新这个值
            {
                RegKey.SetValue("LastTime", (object)DateTime.Now.ToString("yyyy/MM/dd"));
            }
        }
    }
}
