using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    class HTMLCode
    {
        static void Main()
        {
            ElementsBuilder div = new ElementsBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);
            ElementsBuilder image = HTMLDispatcher.CreateImage("../../image", "a boy dancing with a girl", "street dances");
            ElementsBuilder attribute = HTMLDispatcher.CreateURL("www.softuni.bg", "programming courses", "learn programming");
            ElementsBuilder input = HTMLDispatcher.CreateInput("radio", "button", "click this button when you want to exit");
            Console.WriteLine(string.Format("{0}\n{1}\n{2}", image, attribute, input));

        }
    }
}
