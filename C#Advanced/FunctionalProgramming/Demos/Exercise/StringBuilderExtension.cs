using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  
    public static class StringBuilderExtension
    {
          public static string Substring(this StringBuilder sb, int startIndex, int count)
          {
              StringBuilder substring = new StringBuilder();
              for (int i = startIndex; i <  startIndex + count; i++)
              {
                  substring.Append(sb[i]);
              }
              return substring.ToString();
          }
    }

