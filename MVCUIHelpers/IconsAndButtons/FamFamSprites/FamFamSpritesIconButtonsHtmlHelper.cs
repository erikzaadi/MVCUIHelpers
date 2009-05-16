using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MVCUIHelpers.IconsAndButtons.FamFamSprites
{
    public static class FamFamSpritesIconButtonsHtmlHelper
    {
        private static FamFamSpritesIconAndButtonsRepository mFamFamSpritesAndButtonsRepository
        {
            get { return new FamFamSpritesIconAndButtonsRepository(); }
        }

        public static string FamFamSprites(this HtmlHelper helper,
         FamFamSpritesEnum inIcon)
        {
            return FamFamSprites(helper, inIcon, null);
        }

        public static string FamFamSprites(this HtmlHelper helper,
           FamFamSpritesEnum inIcon,
           object htmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetSpriteIcon(inIcon, htmlAttributes);
        }

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

        public static string FamFamSpritesButton(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public static string FamFamSpritesLink(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inUrl,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetSpriteIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public static string FamFamSpritesForElement(this HtmlHelper helper,
            string inText,
            FamFamSpritesEnum inIcon,
            string inElement,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return mFamFamSpritesAndButtonsRepository.GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }
    }
}
