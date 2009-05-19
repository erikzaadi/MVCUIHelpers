using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons
{
    /// <summary>
    /// IIconsAndButtons Interface
    /// 
    /// Includes all the needed implementations
    /// for an IconAndButtons repository
    /// 
    /// Created mainly for unit-testing and possible
    /// future extendability
    /// </summary>
    /// <typeparam name="IconType">Enum type for Icons</typeparam>
    public interface IIconsAndButtons<IconType>
    {
        /// <summary>
        /// Base CSS class used for Left to right direction
        /// </summary>
        string IIconBaseCSSClassLtr { get; }
        /// <summary>
        /// Base CSS class used for Right to left direction
        /// </summary>
        string IIconBaseCSSClassRtl { get; }

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created span</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of created Icon span</returns>
        string GetIcon(
            IconType inIcon,
            object htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection);

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created span</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of created Icon span</returns>
        string GetIcon(
               IconType inIcon,
               RouteValueDictionary htmlAttributes,
               MVCUIHelpers.Shared.Direction inDirection);

        /// <summary>
        /// Returns a button with a Icon
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
        string GetIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes,
           object innerSpanHtmlAttributes,
           object innerIconHtmlAttributes);

        /// <summary>
        /// Returns a button with a Icon
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
        string GetIconButton(
        string inText,
        IconType inIcon,
        MVCUIHelpers.Shared.ButtonType inButtonType,
        MVCUIHelpers.Shared.Direction inDirection,
        RouteValueDictionary htmlAttributes,
        RouteValueDictionary innerSpanHtmlAttributes,
        RouteValueDictionary innerIconHtmlAttributes);

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
        string GetIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes);

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
        string GetIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes);

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example>
        /// <remarks>Note : Can not be empty</remarks></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        string GetIconForElement(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inElement,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes);

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example>
        /// <remarks>Note : Can not be empty</remarks></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        string GetIconForElement(
              string inText,
              IconType inIcon,
              MVCUIHelpers.Shared.Direction inDirection,
              string inElement,
              RouteValueDictionary htmlAttributes,
              RouteValueDictionary innerSpanHtmlAttributes,
              RouteValueDictionary innerIconHtmlAttributes);
    }
}
