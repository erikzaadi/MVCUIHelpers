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
            IconType inIcon);

        string GetSpriteIcon(
          IconType inIcon,
          object htmlAttributes);

        string GetSpriteIconButton(
           string inText,
           IconType inIcon);

        string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           object htmlAttributes);

        string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType);

        string GetSpriteIconButton(
          string inText,
          IconType inIcon,
          MVCUIHelpers.Shared.ButtonType inButtonType,
          MVCUIHelpers.Shared.Direction inDirection);

        string GetSpriteIconButton(
          string inText,
          IconType inIcon,
          MVCUIHelpers.Shared.ButtonType inButtonType,
          MVCUIHelpers.Shared.Direction inDirection,
          object htmlAttributes);

        string GetSpriteIconButton(
          string inText,
          IconType inIcon,
          MVCUIHelpers.Shared.ButtonType inButtonType,
          MVCUIHelpers.Shared.Direction inDirection,
          object htmlAttributes,
          object innerSpanHtmlAttributes);

        string GetSpriteIconButton(
           string inText,
           IconType inIcon,
           MVCUIHelpers.Shared.ButtonType inButtonType,
           MVCUIHelpers.Shared.Direction inDirection,
           object htmlAttributes,
           object innerSpanHtmlAttributes,
           object innerIconHtmlAttributes);

    }
}
