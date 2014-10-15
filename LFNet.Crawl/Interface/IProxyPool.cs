using System.Collections.Generic;
using System.Net;
using System.Security;

namespace LFNet.Crawl.Interface
{
    /// <summary>
    /// 代理池
    /// </summary>
    public interface IProxyPool
    {
        /// <summary>
        /// 添加一个代理
        /// </summary>
        /// <param name="proxy"></param>
        void Add(WebProxy proxy);

        /// <summary>
        /// 获取全部代理
        /// </summary>
        /// <returns></returns>
        List<WebProxy> GetList();

        /// <summary>
        /// 获取一个可用的代理
        /// </summary>
        /// <returns></returns>
        WebProxy GetOne();
    }
}