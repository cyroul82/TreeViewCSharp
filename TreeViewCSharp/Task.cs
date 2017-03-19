using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewCSharp
{
    /// <summary>
    /// Represent the task
    /// </summary>
    public class Task
    {
        public String task { get; set; }
        public Int32 idTask { get; private set; }

        public String description { get; set; }

        public String dev { get; set; }

        public Data.enumStatus status{ get; set; }

        public DateTime date { get; set; }

        public Task(String task, Int32 idTask, Data.enumStatus status, DateTime date)
        {
            this.task = task;
            this.idTask = idTask;
            this.status = status;
            this.date = date;
        }

        public override string ToString()
        {
            return idTask + " " + task + " " + date.ToShortDateString();
        }
    }


}
