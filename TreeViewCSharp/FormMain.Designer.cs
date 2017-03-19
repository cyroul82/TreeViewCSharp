namespace TreeViewCSharp
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeTask = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bntMinusTask = new System.Windows.Forms.Button();
            this.btnPlusTask = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTaskList = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeTask);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 458);
            this.panel1.TabIndex = 20;
            // 
            // treeTask
            // 
            this.treeTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTask.FullRowSelect = true;
            this.treeTask.ItemHeight = 18;
            this.treeTask.Location = new System.Drawing.Point(0, 17);
            this.treeTask.Name = "treeTask";
            this.treeTask.Size = new System.Drawing.Size(268, 397);
            this.treeTask.TabIndex = 8;
            this.treeTask.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeTask_NodeMouseClick);
            this.treeTask.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeTask_NodeMouseDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bntMinusTask, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPlusTask, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 414);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 44);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // bntMinusTask
            // 
            this.bntMinusTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntMinusTask.Location = new System.Drawing.Point(182, 3);
            this.bntMinusTask.Name = "bntMinusTask";
            this.bntMinusTask.Size = new System.Drawing.Size(37, 38);
            this.bntMinusTask.TabIndex = 1;
            this.bntMinusTask.Text = "-";
            this.bntMinusTask.UseVisualStyleBackColor = true;
            this.bntMinusTask.Click += new System.EventHandler(this.bntMinusTask_Click);
            // 
            // btnPlusTask
            // 
            this.btnPlusTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlusTask.Location = new System.Drawing.Point(48, 3);
            this.btnPlusTask.Name = "btnPlusTask";
            this.btnPlusTask.Size = new System.Drawing.Size(37, 38);
            this.btnPlusTask.TabIndex = 0;
            this.btnPlusTask.Text = "+";
            this.btnPlusTask.UseVisualStyleBackColor = true;
            this.btnPlusTask.Click += new System.EventHandler(this.btnPlusTask_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel3.Controls.Add(this.lblTaskList);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(268, 17);
            this.flowLayoutPanel3.TabIndex = 10;
            // 
            // lblTaskList
            // 
            this.lblTaskList.AutoSize = true;
            this.lblTaskList.Location = new System.Drawing.Point(3, 0);
            this.lblTaskList.Name = "lblTaskList";
            this.lblTaskList.Size = new System.Drawing.Size(88, 13);
            this.lblTaskList.TabIndex = 0;
            this.lblTaskList.Text = "Liste des Tâches";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 458);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeTask;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bntMinusTask;
        private System.Windows.Forms.Button btnPlusTask;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblTaskList;
    }
}

