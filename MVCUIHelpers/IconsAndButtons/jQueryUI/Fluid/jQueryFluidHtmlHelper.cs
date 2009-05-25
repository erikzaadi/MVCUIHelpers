using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MVCUIHelpers.IconsAndButtons.jQueryUI.Fluid
{
    public static class jQueryFluidHtmlHelper
    {
        public static jQueryFluidButtonExtension jQueryFluidButton(this HtmlHelper helper)
        {
            return new jQueryFluidButtonExtension(helper);
        }

        public static jQueryFluidIconExtension jQueryFluidIcon(this HtmlHelper helper)
        {
            return new jQueryFluidIconExtension(helper);
        }

        public static jQueryFluidLinkExtension jQueryFluidLink(this HtmlHelper helper)
        {
            return new jQueryFluidLinkExtension(helper);
        }

        public static jQueryFluidGenericExtension jQueryFluidGeneric(this HtmlHelper helper)
        {
            return new jQueryFluidGenericExtension(helper);
        }
    }
}
