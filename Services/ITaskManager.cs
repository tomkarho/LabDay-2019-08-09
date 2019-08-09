using System.Collections.Generic;
using BlazDo;

namespace BlazDo
{
    interface ITaskManager
    {
        void AddTask(Todo task);
        List<Todo> GetTasks();

        void RemoveTask(Todo task);
    }
}