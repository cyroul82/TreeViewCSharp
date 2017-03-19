namespace TreeViewCSharp
{
    partial class FormTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpTask = new System.Windows.Forms.GroupBox();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbxAssign = new System.Windows.Forms.ComboBox();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblTask = new System.Windows.Forms.Label();
            this.enumStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enumStatusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTask
            // 
            this.grpTask.Controls.Add(this.cbxStatus);
            this.grpTask.Controls.Add(this.lblStatus);
            this.grpTask.Controls.Add(this.cbxAssign);
            this.grpTask.Controls.Add(this.lblAssignTo);
            this.grpTask.Controls.Add(this.txtDescription);
            this.grpTask.Controls.Add(this.lblDescription);
            this.grpTask.Controls.Add(this.txtTask);
            this.grpTask.Controls.Add(this.lblTask);
            this.grpTask.Location = new System.Drawing.Point(12, 12);
            this.grpTask.Name = "grpTask";
            this.grpTask.Size = new System.Drawing.Size(342, 172);
            this.grpTask.TabIndex = 14;
            this.grpTask.TabStop = false;
            this.grpTask.Text = "Tâches";
            // 
            // cbxStatus
            // 
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(84, 128);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(121, 21);
            this.cbxStatus.TabIndex = 19;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(25, 132);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 13);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status : ";
            // 
            // cbxAssign
            // 
            this.cbxAssign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAssign.FormattingEnabled = true;
            this.cbxAssign.Location = new System.Drawing.Point(84, 93);
            this.cbxAssign.Name = "cbxAssign";
            this.cbxAssign.Size = new System.Drawing.Size(121, 21);
            this.cbxAssign.Sorted = true;
            this.cbxAssign.TabIndex = 3;
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Location = new System.Drawing.Point(7, 97);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.Size = new System.Drawing.Size(65, 13);
            this.lblAssignTo.TabIndex = 18;
            this.lblAssignTo.Text = "Assigner à : ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(84, 60);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(247, 20);
            this.txtDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(3, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description : ";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(84, 27);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(100, 20);
            this.txtTask.TabIndex = 1;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(25, 30);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(47, 13);
            this.lblTask.TabIndex = 13;
            this.lblTask.Text = "Tâche : ";
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 191);
            this.Controls.Add(this.grpTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.grpTask.ResumeLayout(false);
            this.grpTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enumStatusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTask;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.BindingSource enumStatusBindingSource;
        protected System.Windows.Forms.ComboBox cbxAssign;
        protected System.Windows.Forms.TextBox txtDescription;
        protected System.Windows.Forms.TextBox txtTask;
        protected System.Windows.Forms.ComboBox cbxStatus;
    }
}