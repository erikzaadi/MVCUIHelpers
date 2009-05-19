using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCUIHelpers.IconsAndButtons
{
    /// <summary>
    /// IconsAndButtonsBase Class
    /// 
    /// This class is used as a repository for the Html Helper,
    /// Mostly due to the fact that the Html helper class can not
    /// inherite anything except for a base object (and needs to 
    /// be static as well..)
    /// 
    /// Please note that the passed Icon enum type needs 
    /// descriptions for each enum element:
    /// E.g.
    /// <example><code><![CDATA[
    ///  public enum MyIconsEnum
    ///  {
    ///     [Description("CSSClassNameThatWillBeUsed")]
    ///     enumDisplayName
    /// }
    /// ]]></code></example>
    /// 
    /// Only the IconBaseCSSClassLtr|Rtl are mandatory to implement
    /// </summary>
    /// <typeparam name="IconType">Enum type for Icons<</typeparam>
    public abstract class IconsAndButtonsBase<IconType> : IIconsAndButtons<IconType>
    {
        #region IIconsAndButtons<IconType> Members

        /// <summary>
        /// Base CSS class used for Left to right direction
        /// </summary>
        internal abstract string IconBaseCSSClassLtr { get; }
        /// <summary>
        /// Base CSS class used for Right to left direction
        /// </summary>
        internal abstract string IconBaseCSSClassRtl { get; }

        /// <summary>
        /// Implementation of IIconBaseCSSClassRtl
        /// </summary>
        string IIconsAndButtons<IconType>.IIconBaseCSSClassRtl { get { return IconBaseCSSClassRtl; } }
        /// <summary>
        /// Implementation of IIconBaseCSSClassLtr
        /// </summary>
        string IIconsAndButtons<IconType>.IIconBaseCSSClassLtr { get { return IconBaseCSSClassLtr; } }

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created span</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of created Icon span</returns>
        public virtual string GetIcon(
            IconType inIcon,
            object htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            return GetIcon(
                inIcon,
                new RouteValueDictionary(htmlAttributes),
                inDirection);
        }

        /// <summary>
        /// Returns an Icon
        /// 
        /// Returns a span with the Base CSS Class
        /// according to the direction specified.
        /// <example><code><![CDATA[<span class="baseClassForDirection">&nbsp;</span>]]></code></example>
        /// </summary>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created span</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <returns>Html of created Icon span</returns>
        public virtual string GetIcon(
            IconType inIcon,
            RouteValueDictionary htmlAttributes,
            MVCUIHelpers.Shared.Direction inDirection)
        {
            //Create empty tag for Icon
            TagBuilder spanBuilder = new TagBuilder(Shared.DefaultInnerContainerHtmlTag);
            spanBuilder.InnerHtml = Shared.DefaultSpacerHtmlTag;

            //Merge passed attributes (if exists)
            if (htmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);

            //Add default Base CSS class according to direction
            spanBuilder.AddCssClass(string.Format("{0} {1}",
                inDirection == Shared.Direction.Rtl ? IconBaseCSSClassRtl : IconBaseCSSClassLtr,
                Shared.GetDescription(inIcon)));

            return spanBuilder.ToString();
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Button</returns>
        public virtual string GetIconButton(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return GetIconButton(
                inText,
                inIcon,
                inButtonType,
                inDirection,
                new RouteValueDictionary(htmlAttributes),
                new RouteValueDictionary(innerSpanHtmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes));
        }

        /// <summary>
        /// Returns a button with an Icon
        /// 
        /// <example><code><![CDATA[<button type="Submit"><span class="baseClassForDirection">&nbsp;</span><span>ButtonText</span></button>]]></code></example>
        /// </summary>
        /// <param name="inText">Text to display on button</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inButtonType">Type of button (Submit|Button|Reset)</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Button</returns>
        public virtual string GetIconButton(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.ButtonType inButtonType,
            MVCUIHelpers.Shared.Direction inDirection,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            //Merged passed attributes if exists with the passed button type
            if (htmlAttributes != null)
                htmlAttributes.Add("type", Shared.GetDescription(inButtonType));
            //Or set the button type attribute (if not attributes were passed)
            else
                htmlAttributes = new RouteValueDictionary(new { @type = Shared.GetDescription(inButtonType) });

            /*
             * The cool thing about the button tag is that it can include other
             * tags as inner tags, allowing us to fill the button with our icons
             * and text (and still get a functional button)..
             */
            return GetIconForElement(
                inText,
                inIcon,
                inDirection,
                "button",
                htmlAttributes,
                innerSpanHtmlAttributes,
                innerIconHtmlAttributes);
        }

        /// <summary>
        /// Returns a link with an Icon
        /// </summary>
        /// <param name="inText">Link Text</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public virtual string GetIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return GetIconLink(
                inText,
                inIcon,
                inDirection,
                inUrl,
                new RouteValueDictionary(htmlAttributes),
                new RouteValueDictionary(innerSpanHtmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes));
        }

        /// <summary>
        /// Returns a link with an Icon
        /// </summary>
        /// <param name="inText">Link Text</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inUrl">Link Url (href)</param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created Icon Link</returns>
        public virtual string GetIconLink(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inUrl,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            //Merge the wanted url to the passed attributes
            if (htmlAttributes != null)
                htmlAttributes.Add("href", inUrl);
            //or set the href to the passed url as a attribute
            else
                htmlAttributes = new RouteValueDictionary(new { href = inUrl });

            /*
             * Similar to the button tag, the anchor tag also allows inner tags
             * (Although more well known usage that with the button tag)
             */
            return GetIconForElement(
             inText,
             inIcon,
             inDirection,
             "a",
             htmlAttributes,
             innerSpanHtmlAttributes,
             innerIconHtmlAttributes);
        }

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example>
        /// <remarks>Note : Can not be empty</remarks></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        public virtual string GetIconForElement(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inElement,
            object htmlAttributes,
            object innerSpanHtmlAttributes,
            object innerIconHtmlAttributes)
        {
            return GetIconForElement(
                inText,
                inIcon,
                inDirection,
                inElement,
                new RouteValueDictionary(htmlAttributes),
                new RouteValueDictionary(innerSpanHtmlAttributes),
                new RouteValueDictionary(innerIconHtmlAttributes));
        }

        /// <summary>
        /// Returns a given element with an Icon
        /// </summary>
        /// <param name="inText">Text to display in Element</param>
        /// <param name="inIcon">Icon to show</param>
        /// <param name="inDirection">Direction (Ltr|Rtl)</param>
        /// <param name="inElement">Html Element
        /// <example><code>a|div|li</code> etc</example>
        /// <remarks>Note : Can not be empty</remarks></param>
        /// <param name="htmlAttributes">Additional html attributes dictionary to set to the created button</param>
        /// <param name="innerSpanHtmlAttributes">Additional html attributes dictionary to set to the created span for the button text</param>
        /// <param name="innerIconHtmlAttributes">Additional html attributes dictionary to set to the created span for the Icon</param>
        /// <returns>Html of created element with Icon</returns>
        public virtual string GetIconForElement(
            string inText,
            IconType inIcon,
            MVCUIHelpers.Shared.Direction inDirection,
            string inElement,
            RouteValueDictionary htmlAttributes,
            RouteValueDictionary innerSpanHtmlAttributes,
            RouteValueDictionary innerIconHtmlAttributes)
        {
            //Get the Icon tag
            string iconTag = GetIcon(inIcon, innerIconHtmlAttributes, inDirection);

            //Create the passed element
            TagBuilder elementBuilder = new TagBuilder(inElement);
            //Merge attributes for passed element if given
            if (htmlAttributes != null)
                elementBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes), true);

            //Create the element for the inner text
            TagBuilder spanBuilder = new TagBuilder(Shared.DefaultInnerContainerHtmlTag);
            //Merge attributes for the inner text element if given
            if (innerSpanHtmlAttributes != null)
                spanBuilder.MergeAttributes(new RouteValueDictionary(innerSpanHtmlAttributes), true);
            //Set the wanted text as the inner text of the inner text element
            spanBuilder.InnerHtml = inText;

            /*
             * Order the elements according to the passed direction
             * 
             * This is done to achieve both Rtl language support, and 
             * design flexibility
             */
            elementBuilder.InnerHtml = inDirection == MVCUIHelpers.Shared.Direction.Rtl ?
                (spanBuilder.ToString() + iconTag) :
                (iconTag + spanBuilder.ToString());

            //Return the created element
            return elementBuilder.ToString();
        }

        #endregion IIconsAndButtons<IconType> Members
    }
}
