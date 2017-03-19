using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewCSharp
{
    public class TaskTreeNode : TreeNode
    {
        public Task task { get; private set; }

        public TaskTreeNode(Task task)
        {
            this.task = task;
            this.Text = task.ToString();
        }
    }
}
