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
    /// <summary>
    /// Common structs and methods
    /// </summary>
    public static class Shared
    {
        /// <summary>
        /// Button Type enum
        /// 
        /// Sets the button html element type properties
        /// </summary>
        public enum ButtonType
        {
            [Description("button")]
            Button,
            [Description("reset")]
            Reset,
            [Description("submit")]
            Submit
        }

        /// <summary>
        /// Sets the icons directions
        /// 
        /// Left to right or Right to left
        /// </summary>
        public enum Direction
        {
            Ltr,
            Rtl
        }
        
        //http://www.codeproject.com/KB/cs/enumwithdescription.aspx?msg=649306#xx649306xx
        /// <summary>
        /// Get's the description string of a Enum value
        /// </summary>
        /// <typeparam name="EnumType">Type of Enum</typeparam>
        /// <param name="value">Enum Value</param>
        /// <returns>Enum value description</returns>
        public static string GetDescription<EnumType>(EnumType value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes =
                  (DescriptionAttribute[])fi.GetCustomAttributes(
                  typeof(DescriptionAttribute), false);
            return (attributes.Length > 0) ? attributes[0].Description : value.ToString();
        }

        #region Consts

        /// <summary>
        /// Inner tag used to render Icons and Text
        /// </summary>
        public static string DefaultInnerContainerHtmlTag { get { return "span"; } }
        /// <summary>
        /// Spacer for empty elements
        /// </summary>
        public static string DefaultSpacerHtmlTag { get { return "&nbsp;"; } }

        #endregion Consts
    }
}
