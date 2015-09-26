using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    class ElementsBuilder
    {
        private string elementName;
        private List<string> allAttributes;
        private string content;
        
        public ElementsBuilder(string elementName)
        {
            this.ElementName = elementName;
            this.allAttributes = new List<string>();
        }

        public string ElementName
        {
            get { return this.elementName; }
            set { this.elementName = value; }

        }

        public void AddContent(string content)
        {
            this.content = content;
        }
        
        public void AddAttribute(string attribute, string value)
        {
            string result = string.Format("{0}=\"{1}\"", attribute, value);         
            allAttributes.Add(result);
        }

        public override string ToString()
        {
            if(elementName == "img" || elementName == "input")
            {
                string specialCases = string.Format("<{0} {1}/>", elementName, string.Join(" ", allAttributes), content);
                return specialCases;
            }
            string result = string.Format("<{0} {1}>{2}</{0}>", elementName, string.Join(" ", allAttributes), content);
            return result;
        }
        
        public static string operator *(ElementsBuilder element, int multiplication)
        {
            if (multiplication < 0)
            {
                throw new ArgumentOutOfRangeException("The multiplication of the html must be with a positive number ..");
            }
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < multiplication; i++)
			{
			  result.Append(element);
			}
            
            return result.ToString();
        }
    }
}
