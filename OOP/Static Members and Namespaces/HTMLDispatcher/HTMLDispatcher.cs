using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    static class HTMLDispatcher
    {
        static public ElementsBuilder CreateImage(string imageSource,string alt, string title)
        {
            ElementsBuilder imageTage = new ElementsBuilder("img");
            imageTage.AddAttribute("src", imageSource);
            imageTage.AddAttribute("alt", alt);
            imageTage.AddAttribute("title", title);

            return imageTage;

        }
        static public ElementsBuilder CreateURL(string url, string title, string text)
        {
            ElementsBuilder attributeUrl = new ElementsBuilder("a");
            attributeUrl.AddAttribute("href", url);           
            attributeUrl.AddAttribute("title", title);
            attributeUrl.AddContent(text);
            return attributeUrl;

        }
        static public ElementsBuilder CreateInput(string inputType, string name, string value)
        {
            ElementsBuilder input = new ElementsBuilder("input");
            input.AddAttribute("type", inputType);
            input.AddAttribute("name", name);
            input.AddAttribute("value", value);
            return input;
        }
    }
}
