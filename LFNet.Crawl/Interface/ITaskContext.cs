namespace LFNet.Crawl.Interface
{
    /// <summary>
    /// 任务上下文
    /// </summary>
    public interface ITaskContext
    {
        /// <summary>
        /// 任务信息
        /// </summary>
        ITask Task { get; }
    }
}