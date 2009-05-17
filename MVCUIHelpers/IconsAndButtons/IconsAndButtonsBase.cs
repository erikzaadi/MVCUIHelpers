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

        internal abstract string IconBaseCSSClassLtr { get; }
        internal abstract string IconBaseCSSClassRtl { get; }

        string IIconsAndButtons<IconType>.IIconBaseCSSClassRtl { get { return IconBaseCSSClassRtl; } }
        string IIconsAndButtons<IconType>.IIconBaseCSSClassLtr { get { return IconBaseCSSClassLtr; } }

        public virtual string GetSpriteIcon(
           IconType inIcon,
           object htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return GetSpriteIcon(
                inIcon,
                new RouteValueDictionary(htmlAttributes),
                inDirection);
        }
            
        public virtual string GetSpriteIcon(
            IconType inIcon,
            RouteValueDictionary htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            TagBuilder spanBuilder = new TagBuilder("span");
            spanBuilder.InnerHtml = "&nbsp;";

            if (htmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);

            spanBuilder.AddCssClass(string.Format("{0} {1}",
                inDirection == Shared.Direction.Rtl ? IconBaseCSSClassRtl : IconBaseCSSClassLtr,
                Shared.GetDescription(inIcon)));

            return spanBuilder.ToString();
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
            return GetSpriteIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                new RouteValueDictionary(htmlAttributes),
                new RouteValueDictionary(innerSpanHtmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes));
        }
        public virtual string GetSpriteIconButton(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            htmlAttributes.Add("type", Shared.GetDescription(inButtonType));

            return GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                "button",
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public virtual string GetSpriteIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return GetSpriteIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                new RouteValueDictionary(htmlAttributes),
                new RouteValueDictionary(innerSpanHtmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes));
        }

        public virtual string GetSpriteIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            htmlAttributes.Add("href", inUrl);
            return GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                "a",
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        public virtual string GetSpriteIconForElement(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inElement,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                new RouteValueDictionary(htmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes));
        }

        public virtual string GetSpriteIconForElement(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inElement,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            string iconTag = GetSpriteIcon(inIcon, innerIconHtmlAttributes, inDirection);
            TagBuilder elementBuilder = new TagBuilder(inElement);
            TagBuilder spanBuilder = new TagBuilder("span");
            if (htmlAttributes != null)
                elementBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);
            if (innerSpanHtmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(innerSpanHtmlAttributes), true);
            spanBuilder.InnerHtml = inText;

            elementBuilder.InnerHtml = inDirection == MVCUIHelpers.Shared.Direction.Rtl ?
                (spanBuilder.ToString() + iconTag) :
                (iconTag + spanBuilder.ToString());

            return elementBuilder.ToString();
        }

        #endregion
    }
}
