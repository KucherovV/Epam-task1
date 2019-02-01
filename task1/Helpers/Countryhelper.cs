using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task1.Helpers
{
    public static class Countryhelper
    {
        public static MvcHtmlString GetCountries(this HtmlHelper html, List<string> countries)
        {
            TagBuilder ul = new TagBuilder("select");
            foreach (string item in countries)
            {
                TagBuilder li = new TagBuilder("option");
                li.SetInnerText(item);
                li.MergeAttribute("value", item);
                ul.InnerHtml += li.ToString();
            }
            ul.MergeAttribute("name", "Country");

            return new MvcHtmlString(ul.ToString());
        }


        public static MvcHtmlString CreateList(this HtmlHelper html, List<string> items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item);
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

    }
}