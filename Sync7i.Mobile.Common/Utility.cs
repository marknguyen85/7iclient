
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Sync7i.Mobile.Common
{
    public static class Utility
    {
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
        public static void AddRange<T>(this ObservableCollection<T> lst, IEnumerable<T> addList)// where T : new()
        {
            if (addList == null) return;
            foreach (var i in addList) lst.Add(i);
        }
    }
    public static class StringExtention
    {

        private static readonly string[] VietnameseSigns = new string[]

    {

        "aAeEoOuUiIdDyY",

        "áàạảãâấầậẩẫăắằặẳẵ",

        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

        "éèẹẻẽêếềệểễ",

        "ÉÈẸẺẼÊẾỀỆỂỄ",

        "óòọỏõôốồộổỗơớờợởỡ",

        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

        "úùụủũưứừựửữ",

        "ÚÙỤỦŨƯỨỪỰỬỮ",

        "íìịỉĩ",

        "ÍÌỊỈĨ",

        "đ",

        "Đ",

        "ýỳỵỷỹ",

        "ÝỲỴỶỸ"

    };
        public static string RemoveSign4Vietnamese(this string str)
        {

            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi

            for (int i = 1; i < VietnameseSigns.Length; i++)
            {

                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);

            }

            return str;
        }
        public static string RemoveSign4VietnameseAndSpace(this string str)
        {
            str = str.RemoveSign4Vietnamese();
            str = str.Replace(' ', '_');
            return str;
        }
    }
}