using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LFNet.Crawl
{
    public static class HtmlExtension
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static List<string> Getlinks(this string html)
        {
            throw new  NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="html"></param>
        /// <param name="baseUri"></param>
        /// <returns></returns>
        public static List<Uri> GetUris(this string html,Uri baseUri)
        {
            throw new NotImplementedException();
        }
        private static Regex hrefRegex=new Regex(@"",RegexOptions.Compiled|RegexOptions.IgnoreCase);
    }
}