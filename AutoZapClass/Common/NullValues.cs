using System;

namespace SQLiteBAL.Common
{
    public class NullValues
    {
        public static DateTime NullDateTime = DateTime.MinValue;
        public static Guid NullGuid = Guid.Empty;
        public static int NullInt = int.MinValue;
        public static double NullDouble = double.MinValue;
        public static decimal NullDecimal = decimal.MinValue;
        public static string NullString = null;
        

        //public static Category NullCategory = new Category() { CategoryGuid = Guid.Empty, CategoryKey = "", CategoryName = "" };
    }
}
