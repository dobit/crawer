using System.Net;

namespace LFNet.Crawl.Interface
{
    /// <summary>
    /// 用户
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        IUserInfo UserInfo { get; }
        /// <summary>
        /// 代理信息
        /// </summary>
        WebProxy WebProxy { get; }

        /// <summary>
        /// 是否登陆
        /// </summary>
        bool IsLogin { get; }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <returns></returns>
        bool Login();
        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        bool Logout();

        /// <summary>
        /// cookie容器
        /// </summary>
        CookieContainer CookieContainer { get; }

        
    }
}