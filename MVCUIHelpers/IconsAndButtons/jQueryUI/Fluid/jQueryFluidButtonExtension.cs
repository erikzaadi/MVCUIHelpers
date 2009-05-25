using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI.Fluid
{
    public class jQueryFluidButtonExtension
    {
        private readonly HtmlHelper _htmlHelper;
        private jQueryUIIconsEnum _Icon;
        private RouteValueDictionary _htmlAttributes;
        private RouteValueDictionary _InnerSpanHtmlAttributes;
        private RouteValueDictionary _IconHtmlAttributes;
        private MVCUIHelpers.Shared.Direction _Direction = Shared.Direction.Ltr;
        private MVCUIHelpers.Shared.ButtonType _ButtonType = Shared.ButtonType.Button;
        private string _Text;

        public jQueryFluidButtonExtension(HtmlHelper helper)
        {
            _htmlHelper = helper;
        }

        public jQueryFluidButtonExtension jQueryUIIcon(jQueryUIIconsEnum inIcon)
        {
            _Icon = inIcon;
            return this;
        }

        public jQueryFluidButtonExtension InnerSpanHtmlAttributes(object inInnerSpanHtmlAttributes)
        {
            return InnerSpanHtmlAttributes(new RouteValueDictionary(inInnerSpanHtmlAttributes));
        }

        public jQueryFluidButtonExtension InnerSpanHtmlAttributes(RouteValueDictionary inInnerSpanHtmlAttributes)
        {
            _InnerSpanHtmlAttributes = inInnerSpanHtmlAttributes;
            return this;
        }
        public jQueryFluidButtonExtension InnerIconHtmlAttributes(object inInnerIconHtmlAttributes)
        {
            return InnerIconHtmlAttributes(new RouteValueDictionary(inInnerIconHtmlAttributes));
        }

        public jQueryFluidButtonExtension InnerIconHtmlAttributes(RouteValueDictionary inInnerIconHtmlAttributes)
        {
            _IconHtmlAttributes = inInnerIconHtmlAttributes;
            return this;
        }
        public jQueryFluidButtonExtension HtmlAttributes(object htmlAttributes)
        {
            return HtmlAttributes(new RouteValueDictionary(htmlAttributes));
        }

        public jQueryFluidButtonExtension HtmlAttributes(RouteValueDictionary htmlAttributes)
        {
            _htmlAttributes = htmlAttributes;
            return this;
        }

        public jQueryFluidButtonExtension Direction(MVCUIHelpers.Shared.Direction inDirection)
        {
            _Direction = inDirection;
            return this;
        }

        public jQueryFluidButtonExtension ButtonType(MVCUIHelpers.Shared.ButtonType inButtonType)
        {
            _ButtonType = inButtonType;
            return this;
        }

        public jQueryFluidButtonExtension Text(string inText)
        {
            _Text = inText;
            return this;
        }

        public void Render()
        {
            jQueryUIIconsAndButtonsRepository mjQueryUIIconsAndButtonsRepository = 
                new jQueryUIIconsAndButtonsRepository();
            _htmlHelper.ViewContext.HttpContext.Response.Write(
                mjQueryUIIconsAndButtonsRepository.GetIconButton(_Text,
                _Icon,
                _ButtonType,
                _Direction,
                _htmlAttributes,
                _InnerSpanHtmlAttributes,
                _IconHtmlAttributes));

        }
    }
}
