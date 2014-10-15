using System;

namespace LFNet.Crawl.Interface
{
    public interface ITask
    {
        ITaskInfo TaskInfo { get; }

        /// <summary>
        /// 变更状态
        /// </summary>
        /// <param name="state"></param>
        void ChangeState(State state);

        /// <summary>
        /// 状态发生改变
        /// </summary>
        event EventHandler StateChanged;

        /// <summary>
        /// 执行任务
        /// </summary>
        void Excute();

        /// <summary>
        /// 创建一个新用户
        /// </summary>
        /// <param name="taskContext"></param>
        /// <returns></returns>
        IUser CreateNewUser(ITaskContext taskContext);
    }
}