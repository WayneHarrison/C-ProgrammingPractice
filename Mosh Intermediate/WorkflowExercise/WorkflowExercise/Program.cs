using System;
using System.Collections.Generic;

namespace WorkflowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var work = new Workflow();
            work.Add(new updateDB());
            work.Add(new uploadVideo());
            work.Add(new sendMail());

            var engine = new WorkFlowEngine();

            engine.Run(work);
        }
    }

    public interface ITask
    {
        void Execute();
    }

    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class Workflow : IWorkFlow
    {
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class uploadVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video...");
        }
    }
    class updateDB : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Update in progress...");
        }
    }
    class sendMail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Mail being sent...");
        }
    }

    public class WorkFlowEngine
    {
        

        public void Run(IWorkFlow workflow)
        {
            foreach (ITask i in workflow.GetTasks())
            {
                i.Execute();
            }
        }
    }
}
