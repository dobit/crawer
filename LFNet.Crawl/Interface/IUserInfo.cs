namespace LFNet.Crawl.Interface
{
    public interface IUserInfo
    {
        /// <summary>
        /// 用户名
        /// </summary>
        string UserName { get; }

        /// <summary>
        /// 密码
        /// </summary>
        string Password { get; }
    }
}