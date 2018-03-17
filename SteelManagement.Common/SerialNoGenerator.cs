using System;

namespace SteelManagement.Common
{
    public class SerialNoGenerator
    {
        public enum Type
        {
            Type01Purchase,
            Type02Sale,
            Type03Receipt,
            Type04PurchaseBill,
            Type05SaleBill
        }
        public static string GetSerialNo(Type type)
        {
            Random rng = new Random();
            int num = rng.Next(0, 10000); //随机四位数
            string rndNum = num.ToString().PadLeft(4, '0');
            return DateTimeFormator.DateTimeToString(DateTime.Now, DateTimeFormator.TimeFormat.Type02SerialNo) + GetTypeString(type) + rndNum;
        }

        private static string GetTypeString(Type type)
        {
            switch (type)
            {
                case Type.Type01Purchase:
                    return "01";
                case Type.Type02Sale:
                    return "02";
                case Type.Type03Receipt:
                    return "03";
                case Type.Type04PurchaseBill:
                    return "04";
                case Type.Type05SaleBill:
                    return "05";
                default:
                    return "";
            }
        }

    }
}
