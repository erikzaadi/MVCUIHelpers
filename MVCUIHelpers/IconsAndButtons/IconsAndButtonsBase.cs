using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons
{

    public abstract class IconsAndButtonsBase<IconType> : IIconsAndButtons<IconType>
    {
        #region IIconsAndButtons<IconType> Members

        internal abstract string IconBaseCSSClass { get; }

        string IIconsAndButtons<IconType>.IIconBaseCSSClass { get { return IconBaseCSSClass; } }

        public virtual string GetSpriteIcon(
            IconType inIcon)
        {
            return GetSpriteIcon(inIcon, null);
        }

        public virtual string GetSpriteIcon(
           IconType inIcon,
           object htmlAttributes)
        {
            TagBuilder spanBuilder = new TagBuilder("span");
            spanBuilder.InnerHtml = "&nbsp;";
            spanBuilder.MergeAttribute("class", string.Format("{0} {1}", IconBaseCSSClass, Shared.GetDescription(inIcon)));

            if (htmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);

            return spanBuilder.ToString();
        }

        public virtual string GetSpriteIconButton(
            string inText,
            IconType inIcon)
        {
            return GetSpriteIconButton(
                inText,
                inIcon,
                MVCUIHelpers.Shared.ButtonType.Button,
                MVCUIHelpers.Shared.Direction.Ltr,
                null,
                null,
                null);
        }

        public virtual string GetSpriteIconButton(
            string inText,
            IconType inIcon,
            object htmlAttributes)
        {
            return GetSpriteIconButton(
                inText,
                inIcon,
                MVCUIHelpers.Shared.ButtonType.Button,
                MVCUIHelpers.Shared.Direction.Ltr,
                htmlAttributes,
                null,
                null);
        }

        public virtual string GetSpriteIconButton(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType)
        {
            return GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                MVCUIHelpers.Shared.Direction.Ltr,
                null,
                null,
                null);
        }

        public virtual string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection)
        {
            return GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                null,
                null,
                null);
        }

        public virtual string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes)
        {
            return GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                null,
                null);
        }

        public virtual string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes,
           object innerSpanHtmlAttributes)
        {
            return GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                htmlAttributes,
                innerSpanHtmlAttributes,
                null);
        }

        public virtual string GetSpriteIconButton(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            string iconTag = GetSpriteIcon(inIcon, innerIconHtmlAttributes);

            TagBuilder buttonBuilder = new TagBuilder("button");
            TagBuilder spanBuilder = new TagBuilder("span");
            buttonBuilder.Attributes["type"] = Shared.GetDescription(inButtonType);
            if (htmlAttributes != null)
                buttonBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);
            if (innerSpanHtmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(innerSpanHtmlAttributes), true);
            spanBuilder.InnerHtml = inText;

            buttonBuilder.InnerHtml = inDirection == MVCUIHelpers.Shared.Direction.Ltr ?
                (spanBuilder.ToString() + iconTag) :
                (iconTag + spanBuilder.ToString());

            return buttonBuilder.ToString();
        }

        #endregion
    }
}
