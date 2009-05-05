using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Reflection;
using System.ComponentModel;

namespace MVCUIHelpers
{
    public static class Shared
    {
        public enum ButtonType
        {
            [Description("button")]
            Button,
            [Description("reset")]
            Reset,
            [Description("submit")]
            Submit
        }

        public enum Direction
        {
            Ltr,
            Rtl
        }
        //http://www.codeproject.com/KB/cs/enumwithdescription.aspx?msg=649306#xx649306xx
        public static string GetDescription<EnumType>(EnumType value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                  (DescriptionAttribute[])fi.GetCustomAttributes(
                  typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }
    }

    //http://dotnet.org.za/johanvw/archive/2008/10/21/applying-c-generics-when-working-with-enum.aspx
    //http://geekswithblogs.net/WillSmith/archive/2008/06/28/c-generics-for-enums.aspx
    public static class enumFinder<T>
    {
        public static T ParseMe(string value)
        {
            if (!typeof(T).IsEnum)
            {
                throw new NotSupportedException("T must be an Enum");
            }
            T foundEnum = (T)Enum.Parse(typeof(T), value);
            return foundEnum;
        }
    }
}
