using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeViewCSharp
{
	public partial class FormDisplayTask : TreeViewCSharp.FormTask
	{
        private Task task;
        public delegate void ModifyItemDelegate(Task t);
        public ModifyItemDelegate ModifyItemCallback;
		public FormDisplayTask(ref Task task)
		{
			InitializeComponent();
            this.task = task;
        }

        private void updateUI()
        {
            base.txtTask.Text = task.task;
            base.txtDescription.Text = task.description;
            base.cbxStatus.SelectedItem = task.status;
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            String stringTask = base.txtTask.Text.Trim();
            if (stringTask != "")
            {
                this.task.task = stringTask;
                String stringDescription = base.txtDescription.Text;
                if (stringDescription != "")
                {
                    this.task.description = stringDescription;
                }
                if (cbxAssign.SelectedItem != null)
                {
                    this.task.dev = base.cbxAssign.SelectedItem.ToString();
                }
                Data.enumStatus status;
                Enum.TryParse<Data.enumStatus>(cbxStatus.SelectedValue.ToString(), out status);
                this.task.status = status;

                ModifyItemCallback(task);

                this.DialogResult = DialogResult.OK;

            }
        }

        private void FormDisplayTask_Load(object sender, EventArgs e)
        {
            updateUI();
        }
    }
}
