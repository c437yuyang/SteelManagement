using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);

            RegistryKey RootKey = Registry.CurrentUser.OpenSubKey("Software", true);

            foreach (string name in RootKey.GetSubKeyNames())
            {
                Console.WriteLine(name);
            }
            RegistryKey RegKey = RootKey.OpenSubKey("MyRegDataApp", true);
            if (RegKey == null)
            {
                RootKey.CreateSubKey("MyRegDataApp");//不存在，则创建子项
                RegKey = RootKey.OpenSubKey("MyRegDataApp", true);
                RegKey.SetValue("UseTime", (object)DateTime.Now.ToString("yyyy/MM/dd"));    //创建键值，存储可使用次数
            }
            //RegKey.SetValue("UseTime", (object)DateTime.Now.ToString("yyyy/MM/dd"));    //创建键值，存储可使用次数
            Console.WriteLine(RegKey.GetValue("UseTime")); 

            Console.Read();

        }
    }
}
