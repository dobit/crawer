using System;

namespace LFNet.Crawl.Interface
{
    public abstract class Task : ITask
    {
        public ITaskInfo TaskInfo { get; private set; }
        public void ChangeState(State state)
        {
            this.TaskInfo.State = state;
            StateChanged(this,null);
        }

        public event EventHandler StateChanged;
        public abstract void Excute();
    }
}