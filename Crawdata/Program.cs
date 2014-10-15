using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crawdata
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface ITagDataProvider
    {
         
    }

  public  interface IIndexPage
    {
        List<LinkInfo> GetTagLinkList();
    }
}
