namespace SortedListExTask
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveTask = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.lblTaskDetails = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.dtpTaskDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Task List";
            // 
            // btnRemoveTask
            // 
            this.btnRemoveTask.Location = new System.Drawing.Point(434, 33);
            this.btnRemoveTask.Name = "btnRemoveTask";
            this.btnRemoveTask.Size = new System.Drawing.Size(134, 23);
            this.btnRemoveTask.TabIndex = 15;
            this.btnRemoveTask.Text = "Remove Task";
            this.btnRemoveTask.UseVisualStyleBackColor = true;
            this.btnRemoveTask.Click += new System.EventHandler(this.BtnRemoveTask_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.Location = new System.Drawing.Point(240, 33);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(188, 95);
            this.lstTasks.TabIndex = 14;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.LstTasks_SelectedIndexChanged);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(434, 59);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(134, 23);
            this.btnPrintAll.TabIndex = 13;
            this.btnPrintAll.Text = "Print All Tasks";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.BtnPrintAll_Click);
            // 
            // lblTaskDetails
            // 
            this.lblTaskDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaskDetails.Location = new System.Drawing.Point(240, 131);
            this.lblTaskDetails.Name = "lblTaskDetails";
            this.lblTaskDetails.Size = new System.Drawing.Size(188, 57);
            this.lblTaskDetails.TabIndex = 12;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(24, 165);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(200, 23);
            this.btnAddTask.TabIndex = 11;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(24, 59);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(200, 100);
            this.txtTask.TabIndex = 10;
            // 
            // dtpTaskDate
            // 
            this.dtpTaskDate.Location = new System.Drawing.Point(24, 33);
            this.dtpTaskDate.Name = "dtpTaskDate";
            this.dtpTaskDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTaskDate.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveTask);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.lblTaskDetails);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.dtpTaskDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveTask;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.Label lblTaskDetails;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.DateTimePicker dtpTaskDate;
    }
}

