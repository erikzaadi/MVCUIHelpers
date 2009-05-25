using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI.Fluid
{
    public class jQueryFluidGenericExtension
    {
        private readonly HtmlHelper _htmlHelper;
        private jQueryUIIconsEnum _Icon;
        private RouteValueDictionary _htmlAttributes;
        private RouteValueDictionary _InnerSpanHtmlAttributes;
        private RouteValueDictionary _IconHtmlAttributes;
        private MVCUIHelpers.Shared.Direction _Direction = Shared.Direction.Ltr;
        private string _Element;
        private string _Text;

        public jQueryFluidGenericExtension(HtmlHelper helper)
        {
            _htmlHelper = helper;
        }

        public jQueryFluidGenericExtension jQueryUIIcon(jQueryUIIconsEnum inIcon)
        {
            _Icon = inIcon;
            return this;
        }

        public jQueryFluidGenericExtension InnerSpanHtmlAttributes(object inInnerSpanHtmlAttributes)
        {
            return InnerSpanHtmlAttributes(new RouteValueDictionary(inInnerSpanHtmlAttributes));
        }

        public jQueryFluidGenericExtension InnerSpanHtmlAttributes(RouteValueDictionary inInnerSpanHtmlAttributes)
        {
            _InnerSpanHtmlAttributes = inInnerSpanHtmlAttributes;
            return this;
        }
        public jQueryFluidGenericExtension InnerIconHtmlAttributes(object inInnerIconHtmlAttributes)
        {
            return InnerIconHtmlAttributes(new RouteValueDictionary(inInnerIconHtmlAttributes));
        }

        public jQueryFluidGenericExtension InnerIconHtmlAttributes(RouteValueDictionary inInnerIconHtmlAttributes)
        {
            _IconHtmlAttributes = inInnerIconHtmlAttributes;
            return this;
        }
        public jQueryFluidGenericExtension HtmlAttributes(object htmlAttributes)
        {
            return HtmlAttributes(new RouteValueDictionary(htmlAttributes));
        }

        public jQueryFluidGenericExtension HtmlAttributes(RouteValueDictionary htmlAttributes)
        {
            _htmlAttributes = htmlAttributes;
            return this;
        }

        public jQueryFluidGenericExtension Direction(MVCUIHelpers.Shared.Direction inDirection)
        {
            _Direction = inDirection;
            return this;
        }

        public jQueryFluidGenericExtension Element(string inElement)
        {
            _Element = inElement;
            return this;
        }

        public jQueryFluidGenericExtension Text(string inText)
        {
            _Text = inText;
            return this;
        }

        public void Render()
        {
            jQueryUIIconsAndButtonsRepository mjQueryUIIconsAndButtonsRepository =
                new jQueryUIIconsAndButtonsRepository();
            _htmlHelper.ViewContext.HttpContext.Response.Write(
                mjQueryUIIconsAndButtonsRepository.GetIconForElement(_Text,
                _Icon,
                _Direction,
                _Element,
                _htmlAttributes,
                _InnerSpanHtmlAttributes,
                _IconHtmlAttributes));

        }
    }
}
