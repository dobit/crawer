namespace LFNet.Crawl.Interface
{
    public interface IRequestContext
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        IUser User { get; }
    }
}