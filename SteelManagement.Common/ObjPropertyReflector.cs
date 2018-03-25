using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;

namespace SteelManagement.Common
{
    public static class ObjPropertyReflector
    {



        /// <summary>  
        /// 创建对象深度复制的副本  
        /// </summary>  
        public static object GetProperty<T>(this T source, string propertyName) where T : class
        {
            Type type = source.GetType();

            return source.GetType().GetProperty(propertyName).GetValue(source, null);


        }




       
    }
}