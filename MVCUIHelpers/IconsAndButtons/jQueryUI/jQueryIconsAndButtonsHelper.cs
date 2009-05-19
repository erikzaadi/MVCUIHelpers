using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI
{
    /// <summary>
    /// jQuery UI Icons and Buttons HtmlHelper Class
    /// 
    /// This class exposes the Icons and Buttons 
    /// Repository using a Html Helper
    /// </summary>
    public static class jQueryIconsAndButtonsHtmlHelper
    {
        /// <summary>
        /// private jQuery UI Icons and Buttons Repository 
        /// kind of Static Singleton
        /// </summary>
        private static jQueryUIIconsAndButtonsRepository mjQueryUIIconsAndButtonsRepository
        {
            get
            {
                return new jQueryUIIconsAndButtonsRepository();
            }
        }

        #region Icon

        /// <summary>
        /// Returns a jQuery UI Icon
        /// </summary>
        /// <param name="inIcon">jQuery UI Icon to show</param>
        /// <returns>Html of jQuery UI Icon</returns>
        public static string jQueryUIIcon(this HtmlHelper helper,
           jQueryUIIconsEnum inIcon)
        {
            return jQueryUIIcon(helper, inIcon, null, Shared.Direction.Ltr);
        }

        /// <summary>
        /// Returns a jQuery UI Icon
        /// </summary>
        /// <param name="inIcon">jQuery UI Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created icon</param>
        /// <returns>Html of jQuery UI Icon</returns>
        public static string jQueryUIIcon(this HtmlHelper helper,
         jQueryUIIconsEnum inIcon,
         object htmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIcon(inIcon,
                htmlAttributes,
                MVCUIHelpers.Shared.Direction.Ltr);
        }

        /// <summary>
        /// Returns a jQuery UI Icon
        /// </summary>
        /// <param name="inIcon">jQuery UI Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created icon</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of jQuery UI Icon</returns>
        public static string jQueryUIIcon(this HtmlHelper helper,
            jQueryUIIconsEnum inIcon,
            object htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIcon(inIcon,
                htmlAttributes,
                inDirection);
        }

        /// <summary>
        /// Returns a jQuery UI Icon
        /// </summary>
        /// <param name="inIcon">jQuery UI Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created icon</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of jQuery UI Icon</returns>
        public static string jQueryUIIcon(this HtmlHelper helper,
           jQueryUIIconsEnum inIcon,
           RouteValueDictionary htmlAttributes,
           MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIcon(inIcon,
                htmlAttributes,
                inDirection);
        }

        #endregion Icon

        #region Button

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon)
        {
            return jQueryUIIconButton(helper,
                inText,
                inIcon,
                MVCUIHelpers.Shared.ButtonType.Button,
                MVCUIHelpers.Shared.Direction.Ltr,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            object htmlAttributes)
        {
            return jQueryUIIconButton(helper,
                inText,
                inIcon,
                MVCUIHelpers.Shared.ButtonType.Button,
                MVCUIHelpers.Shared.Direction.Ltr,
                htmlAttributes,
                null,
                null);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconButton(
                inText,
                inIcon,
                inButtonType,
                MVCUIHelpers.Shared.Direction.Ltr,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
           string inText,
           jQueryUIIconsEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection)
        {
            return jQueryUIIconButton(helper,
                inText,
                inIcon,
                inButtonType,
                inDirection,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
           string inText,
           jQueryUIIconsEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes)
        {
            return jQueryUIIconButton(helper,
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                null,
                null);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
           string inText,
           jQueryUIIconsEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes,
           object innerSpanHtmlAttributes)
        {
            return jQueryUIIconButton(helper,
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                innerSpanHtmlAttributes,
                null);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Button</returns>
        public static string jQueryUIIconButton(this HtmlHelper helper,
           string inText,
           jQueryUIIconsEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           RouteValueDictionary htmlAttributes,
           RouteValueDictionary innerSpanHtmlAttributes,
           RouteValueDictionary innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        #endregion Button

        #region Link

        /// <summary>
        /// Returns a link with an Icon
        /// </summary>
        /// <param name="inText">Link Text</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <returns>Html of created Icon Link</returns>
        public static string jQueryUIIconLink(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inUrl)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inUrl,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a link with an Icon
        /// </summary>
        /// <param name="inText">Link Text</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <returns>Html of created Icon Link</returns>
        public static string jQueryUIIconLink(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inUrl,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a link with an Icon
        /// </summary>
        /// <param name="inText">Link Text</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public static string jQueryUIIconLink(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inUrl,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        /// <summary>
        /// Returns a link with an Icon
        /// </summary>
        /// <param name="inText">Link Text</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public static string jQueryUIIconLink(this HtmlHelper helper,
                   string inText,
                   jQueryUIIconsEnum inIcon,
                   string inUrl,
                   MVCUIHelpers.Shared.Direction inDirection,
                   RouteValueDictionary htmlAttributes,
                   RouteValueDictionary innerSpanHtmlAttributes,
                   RouteValueDictionary innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        #endregion Link

        #region Generic Element

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <returns>Html of created element with Icon</returns>
        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inElement,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <returns>Html of created element with Icon</returns>
        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                null,
                null,
                null);
        }

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        #endregion Generic Element

    }
}
