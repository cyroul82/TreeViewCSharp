using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewCSharp
{
    public partial class FormMain : Form
    {
        private Task task = null;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Array a = Enum.GetValues(typeof(Data.enumStatus));
            for (Int32 i = 0; i <= a.Length - 1; i++)
            {
                String s = a.GetValue(i).ToString();
                treeTask.Nodes.Add(s);
            }
        }
        private void treeTask_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is TaskTreeNode)
            {
                TaskTreeNode taskTreeNode = (TaskTreeNode)e.Node;
                task = taskTreeNode.task;
            }
        }

        private void treeTask_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node is TaskTreeNode)
            {
                TaskTreeNode taskTreeNode = (TaskTreeNode)e.Node;
                Task tsk = taskTreeNode.task;
                FormDisplayTask fdt = new FormDisplayTask(ref tsk);
                fdt.ModifyItemCallback = new FormDisplayTask.ModifyItemDelegate(this.ModifyItemCallbackFn);
                fdt.ShowDialog();
            }
        }

        private void btnPlusTask_Click(object sender, EventArgs e)
        {
            FormNewTask fnt = new FormNewTask();
            fnt.AddItemCallback = new FormNewTask.AddItemDelegate(this.AddItemCallbackFn);
            fnt.ShowDialog();
        }

        private void AddItemCallbackFn(Task t)
        {
            Array a = Enum.GetValues(typeof(Data.enumStatus));
            for (Int32 i = 0; i <= a.Length - 1; i++)
            {
                if (t.status.ToString() == a.GetValue(i).ToString())
                {
                    treeTask.Nodes[i].Nodes.Add(new TaskTreeNode(t));
                }
            }
        }

        private void ModifyItemCallbackFn(Task t)
        {
            fillTreeView();
        }

        private void bntMinusTask_Click(object sender, EventArgs e)
        {
            if (task != null)
            {
                DialogResult result = MessageBox.Show("Delete Task " + task.idTask + " ? ", "Task Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Data.listTask.Remove(task);
                    fillTreeView();
                    task = null;
                }
            }
        }

        private void fillTreeView()
        {
            Array a = Enum.GetValues(typeof(Data.enumStatus));
            for (Int32 i = 0; i <= a.Length - 1; i++)
            {
                treeTask.Nodes[i].Nodes.Clear();
            }

            foreach (Task t in Data.listTask)
            {

                for (Int32 i = 0; i <= a.Length - 1; i++)
                {
                    if (t.status.ToString() == a.GetValue(i).ToString())
                    {
                        treeTask.Nodes[i].Nodes.Add(new TaskTreeNode(t));
                    }
                }

            }
        }


    }
}
