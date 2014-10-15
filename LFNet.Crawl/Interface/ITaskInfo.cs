namespace LFNet.Crawl.Interface
{
    /// <summary>
    /// 任务信息
    /// </summary>
    public interface ITaskInfo
    {
        /// <summary>
        /// 名称
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        string Description { get; set; }
        /// <summary>
        /// 是否需要登录
        /// </summary>
        bool NeedLogin { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        State State { get; set; }
    }
}