using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.FamFamSprites
{
    /// <summary>
    /// Fam Fam Sprites Icons and Buttons HtmlHelper Class
    /// 
    /// This class exposes the Icons and Buttons 
    /// Repository using a Html Helper
    /// </summary>
    public static class FamFamSpritesIconButtonsHtmlHelper
    {
        /// <summary>
        /// private Fam Fam Sprites and Buttons Repository 
        /// kind of Static Singleton
        /// </summary>
        private static FamFamSpritesIconAndButtonsRepository mFamFamSpritesAndButtonsRepository
        {
            get { return new FamFamSpritesIconAndButtonsRepository(); }
        }

        #region Icons

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <returns>Html of created Icon span</returns>
        public static string FamFamSprites(this HtmlHelper helper,
         FamFamSpritesEnum inIcon)
        {
            return FamFamSprites(helper, inIcon, null);
        }

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created span</param>
        /// <returns>Html of created Icon span</returns>
        public static string FamFamSprites(this HtmlHelper helper,
           FamFamSpritesEnum inIcon,
           object htmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIcon(inIcon,
                htmlAttributes,
                Shared.Direction.Ltr);
        }

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created span</param>
        /// <returns>Html of created Icon span</returns>
        public static string FamFamSprites(this HtmlHelper helper,
           FamFamSpritesEnum inIcon,
           RouteValueDictionary htmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIcon(inIcon,
                htmlAttributes,
                Shared.Direction.Ltr);
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon)
        {
            return FamFamSpritesButton(helper,
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            object htmlAttributes)
        {
            return FamFamSpritesButton(helper,
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType)
        {
            return FamFamSpritesButton(helper,
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
           string inText,
           FamFamSpritesEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection)
        {
            return FamFamSpritesButton(helper,
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
           string inText,
           FamFamSpritesEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes)
        {
            return FamFamSpritesButton(helper,
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
           string inText,
           FamFamSpritesEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes,
           object innerSpanHtmlAttributes)
        {
            return FamFamSpritesButton(helper,
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
        public static string FamFamSpritesButton(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconButton(
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
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public static string FamFamSpritesLink(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inUrl,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconLink(
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
        public static string FamFamSpritesLink(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inUrl,
            object htmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inUrl,
                htmlAttributes,
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
        public static string FamFamSpritesLink(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inUrl)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconLink(
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
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public static string FamFamSpritesLink(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inUrl,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
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
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public static string FamFamSpritesLink(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inUrl,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconLink(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
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
        public static string FamFamSpritesForElement(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inElement)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconForElement(
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
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <returns>Html of created element with Icon</returns>
        public static string FamFamSpritesForElement(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inElement,
            object htmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inElement,
                htmlAttributes,
                null,
                null);
        }

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        public static string FamFamSpritesForElement(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inElement,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
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
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        public static string FamFamSpritesForElement(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inElement,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetIconForElement(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inElement,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        #endregion Generic Element
    }
}
