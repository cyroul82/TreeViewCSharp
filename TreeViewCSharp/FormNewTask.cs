using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeViewCSharp
{
    public partial class FormNewTask : TreeViewCSharp.FormTask
    {
        public delegate void AddItemDelegate(Task t);
        public FormNewTask( )
        {
            InitializeComponent();
        }

        //Declare delagete callback function, the owner of communication
        public AddItemDelegate AddItemCallback;
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
        String stringTask = base.txtTask.Text.Trim();
            if (stringTask != "")
            {
                Data.idTask++;

                Data.enumStatus status;
                Enum.TryParse<Data.enumStatus>(cbxStatus.SelectedValue.ToString(), out status);

                Task task = new Task(stringTask, Data.idTask, status, DateTime.Now);

                String stringDescription = base.txtDescription.Text;
                if (stringDescription != "")
                {
                    task.description = stringDescription;
                }
                if (cbxAssign.SelectedItem != null)
                {
                    task.dev = base.cbxAssign.SelectedItem.ToString();
                }

                Data.listTask.Add(task);

                AddItemCallback(task);

                this.DialogResult = DialogResult.OK;

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
