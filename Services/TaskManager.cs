using System.Collections.Generic;
using BlazDo;

namespace BlazDo
{
    class TaskManager : ITaskManager
    {
        private List<Todo> Tasks = new List<Todo>();

        public List<Todo> GetTasks()
        {
            return Tasks;
        }

        public void AddTask(Todo task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Todo task)
        {
            Tasks.Remove(task);
        }
    }
}