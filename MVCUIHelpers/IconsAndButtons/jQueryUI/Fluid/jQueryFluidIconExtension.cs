using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI.Fluid
{
    /// <summary>
    /// jQuery UI Icons and Buttons HtmlHelper Class
    /// 
    /// This class exposes the Icons and Buttons 
    /// Repository using a Html Helper
    /// </summary>
    public class jQueryFluidIconExtension
    {
        private readonly HtmlHelper _htmlHelper;
        private jQueryUIIconsEnum _Icon;
        private RouteValueDictionary _htmlAttributes;
        private MVCUIHelpers.Shared.Direction _Direction = Shared.Direction.Ltr;

        #region Icon

        /// <summary>
        /// Returns a jQuery UI Icon
        /// </summary>
        /// <returns>Html of jQuery UI Icon</returns>
        public jQueryFluidIconExtension(HtmlHelper helper)
        {
            _htmlHelper = helper;
        }

        public jQueryFluidIconExtension jQueryUIIcon(jQueryUIIconsEnum inIcon)
        {
            _Icon = inIcon;
            return this;
        }

        public jQueryFluidIconExtension HtmlAttributes(object htmlAttributes)
        {
            return HtmlAttributes(new RouteValueDictionary(htmlAttributes));
        }

        public jQueryFluidIconExtension HtmlAttributes(RouteValueDictionary htmlAttributes)
        {
            _htmlAttributes = htmlAttributes;
            return this;
        }

        public jQueryFluidIconExtension Direction(MVCUIHelpers.Shared.Direction inDirection)
        {
            _Direction = inDirection;
            return this;
        }

        #endregion Icon

        public void Render()
        {
            jQueryUIIconsAndButtonsRepository mjQueryUIIconsAndButtonsRepository = 
                new jQueryUIIconsAndButtonsRepository();
            _htmlHelper.ViewContext.HttpContext.Response.Write(
                mjQueryUIIconsAndButtonsRepository.GetIcon(_Icon,
                _htmlAttributes,
                _Direction));

        }
    }
}
