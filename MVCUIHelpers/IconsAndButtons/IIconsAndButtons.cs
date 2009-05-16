using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons
{
    interface IIconsAndButtons<IconType>
    {
        string IIconBaseCSSClass { get; }

        string GetSpriteIcon(
          IconType inIcon,
          object htmlAttributes);

        string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes,
           object innerSpanHtmlAttributes,
           object innerIconHtmlAttributes);

        string GetSpriteIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes);

        string GetSpriteIconForElement(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inElement,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes);
    }
}
