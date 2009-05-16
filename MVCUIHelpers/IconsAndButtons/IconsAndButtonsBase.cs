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
           IconType inIcon,
           object htmlAttributes)
        {
            TagBuilder spanBuilder = new TagBuilder("span");
            spanBuilder.InnerHtml = "&nbsp;";

            if (htmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);

            spanBuilder.AddCssClass(string.Format("{0} {1}", IconBaseCSSClass, Shared.GetDescription(inIcon)));

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

            TagBuilder buttonBuilder = new TagBuilder("button");
            if (htmlAttributes != null)
                buttonBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);
            buttonBuilder.Attributes["type"] = Shared.GetDescription(inButtonType);

            return GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                "button",
                buttonBuilder.Attributes,
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
            TagBuilder aTag = new TagBuilder("a");
            if (htmlAttributes != null)
                aTag.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            aTag.Attributes.Add("href", inUrl);

            return GetSpriteIconForElement(
                inText,
                inIcon,
                inDirection,
                "a",
                aTag.Attributes,
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
            string iconTag = GetSpriteIcon(inIcon, innerIconHtmlAttributes);

            TagBuilder elementBuilder = new TagBuilder(inElement);
            TagBuilder spanBuilder = new TagBuilder("span");
            if (htmlAttributes != null)
                elementBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);
            if (innerSpanHtmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(innerSpanHtmlAttributes), true);
            spanBuilder.InnerHtml = inText;

            elementBuilder.InnerHtml = inDirection == MVCUIHelpers.Shared.Direction.Ltr ?
                (spanBuilder.ToString() + iconTag) :
                (iconTag + spanBuilder.ToString());

            return elementBuilder.ToString();
        }

        #endregion
    }
}
