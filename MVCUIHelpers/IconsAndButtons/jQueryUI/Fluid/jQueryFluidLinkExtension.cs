using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI.Fluid
{
    public class jQueryFluidLinkExtension
    {
        private readonly HtmlHelper _htmlHelper;
        private jQueryUIIconsEnum _Icon;
        private RouteValueDictionary _htmlAttributes;
        private RouteValueDictionary _InnerSpanHtmlAttributes;
        private RouteValueDictionary _IconHtmlAttributes;
        private MVCUIHelpers.Shared.Direction _Direction = Shared.Direction.Ltr;
        private string _URL;
        private string _Text;

        public jQueryFluidLinkExtension(HtmlHelper helper)
        {
            _htmlHelper = helper;
        }

        public jQueryFluidLinkExtension jQueryUIIcon(jQueryUIIconsEnum inIcon)
        {
            _Icon = inIcon;
            return this;
        }

        public jQueryFluidLinkExtension InnerSpanHtmlAttributes(object inInnerSpanHtmlAttributes)
        {
            return InnerSpanHtmlAttributes(new RouteValueDictionary(inInnerSpanHtmlAttributes));
        }

        public jQueryFluidLinkExtension InnerSpanHtmlAttributes(RouteValueDictionary inInnerSpanHtmlAttributes)
        {
            _InnerSpanHtmlAttributes = inInnerSpanHtmlAttributes;
            return this;
        }
        public jQueryFluidLinkExtension InnerIconHtmlAttributes(object inInnerIconHtmlAttributes)
        {
            return InnerIconHtmlAttributes(new RouteValueDictionary(inInnerIconHtmlAttributes));
        }

        public jQueryFluidLinkExtension InnerIconHtmlAttributes(RouteValueDictionary inInnerIconHtmlAttributes)
        {
            _IconHtmlAttributes = inInnerIconHtmlAttributes;
            return this;
        }
        public jQueryFluidLinkExtension HtmlAttributes(object htmlAttributes)
        {
            return HtmlAttributes(new RouteValueDictionary(htmlAttributes));
        }

        public jQueryFluidLinkExtension HtmlAttributes(RouteValueDictionary htmlAttributes)
        {
            _htmlAttributes = htmlAttributes;
            return this;
        }

        public jQueryFluidLinkExtension Direction(MVCUIHelpers.Shared.Direction inDirection)
        {
            _Direction = inDirection;
            return this;
        }

        public jQueryFluidLinkExtension URL(string inURL)
        {
            _URL = inURL;
            return this;
        }

        public jQueryFluidLinkExtension Text(string inText)
        {
            _Text = inText;
            return this;
        }

        public void Render()
        {
            jQueryUIIconsAndButtonsRepository mjQueryUIIconsAndButtonsRepository =
                new jQueryUIIconsAndButtonsRepository();
            _htmlHelper.ViewContext.HttpContext.Response.Write(
                mjQueryUIIconsAndButtonsRepository.GetIconLink(_Text,
                _Icon,
                _Direction,
                _URL,
                _htmlAttributes,
                _InnerSpanHtmlAttributes,
                _IconHtmlAttributes));

        }
    }
}
