using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI
{
    public static class jQueryIconsAndButtonsHtmlHelper
    {
        private static jQueryUIIconsAndButtonsRepository mjQueryUIIconsAndButtonsRepository
        {
            get
            {
                return new jQueryUIIconsAndButtonsRepository();
            }
        }

        #region Icon

        public static string jQueryUIIcon(this HtmlHelper helper,
           jQueryUIIconsEnum inIcon)
        {
            return jQueryUIIcon(helper, inIcon, null, Shared.Direction.Ltr);
        }

        public static string jQueryUIIcon(this HtmlHelper helper,
         jQueryUIIconsEnum inIcon,
         object htmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIcon(inIcon,
                htmlAttributes,
                MVCUIHelpers.Shared.Direction.Ltr);
        }

        public static string jQueryUIIcon(this HtmlHelper helper,
            jQueryUIIconsEnum inIcon,
            object htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIcon(inIcon,
                htmlAttributes,
                inDirection);
        }

        public static string jQueryUIIcon(this HtmlHelper helper,
           jQueryUIIconsEnum inIcon,
           RouteValueDictionary htmlAttributes,
           MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIcon(inIcon,
                htmlAttributes,
                inDirection);
        }

        #endregion Icon

        #region Button

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

        public static string jQueryUIIconButton(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType)
        {
            return jQueryUIIconButton(helper,
                inText,
                inIcon,
                inButtonType,
                MVCUIHelpers.Shared.Direction.Ltr,
                null,
                null,
                null);
        }

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

        public static string jQueryUIIconButton(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public static string jQueryUIIconButton(this HtmlHelper helper,
           string inText,
           jQueryUIIconsEnum inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           RouteValueDictionary htmlAttributes,
           RouteValueDictionary innerSpanHtmlAttributes,
           RouteValueDictionary innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconButton(
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

        public static string jQueryUIIconLink(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inUrl)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconLink(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inUrl,
                null,
                null,
                null);
        }

        public static string jQueryUIIconLink(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inUrl,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                null,
                null,
                null);
        }

        public static string jQueryUIIconLink(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inUrl,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public static string jQueryUIIconLink(this HtmlHelper helper,
                   string inText,
                   jQueryUIIconsEnum inIcon,
                   string inUrl,
                   MVCUIHelpers.Shared.Direction inDirection,
                   RouteValueDictionary htmlAttributes,
                   RouteValueDictionary innerSpanHtmlAttributes,
                   RouteValueDictionary innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconLink(
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

        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconForElement(
                inText,
                inIcon,
                MVCUIHelpers.Shared.Direction.Ltr,
                inElement,
                null,
                null,
                null);
        }
        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                null,
                null,
                null);
        }

        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public static string jQueryUIIconForElement(this HtmlHelper helper,
            string inText,
            jQueryUIIconsEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            return mjQueryUIIconsAndButtonsRepository.GetSpriteIconForElement(
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
