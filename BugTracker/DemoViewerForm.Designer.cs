﻿
namespace TaskTracker
{
    partial class DemoViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoViewerForm));
            this.label6 = new System.Windows.Forms.Label();
            this.MoveTasksButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FailedBugListView = new System.Windows.Forms.ListView();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MarkButton = new System.Windows.Forms.Button();
            this.finishedBugListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BugListView = new System.Windows.Forms.ListView();
            this.DeleteBugButton = new System.Windows.Forms.Button();
            this.EditBugButton = new System.Windows.Forms.Button();
            this.AddBugButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 21);
            this.label6.TabIndex = 32;
            this.label6.Text = "Activity in the last 24 hours";
            // 
            // MoveTasksButton
            // 
            this.MoveTasksButton.BackColor = System.Drawing.SystemColors.Info;
            this.MoveTasksButton.Location = new System.Drawing.Point(493, 533);
            this.MoveTasksButton.Name = "MoveTasksButton";
            this.MoveTasksButton.Size = new System.Drawing.Size(44, 25);
            this.MoveTasksButton.TabIndex = 31;
            this.MoveTasksButton.Text = "<--";
            this.MoveTasksButton.UseVisualStyleBackColor = false;
            this.MoveTasksButton.Visible = false;
            this.MoveTasksButton.Click += new System.EventHandler(this.MoveTasksButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Activity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(529, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tasks failed to complete on time";
            // 
            // FailedBugListView
            // 
            this.FailedBugListView.FullRowSelect = true;
            this.FailedBugListView.GridLines = true;
            this.FailedBugListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.FailedBugListView.HideSelection = false;
            this.FailedBugListView.Location = new System.Drawing.Point(533, 498);
            this.FailedBugListView.Name = "FailedBugListView";
            this.FailedBugListView.Size = new System.Drawing.Size(283, 97);
            this.FailedBugListView.TabIndex = 28;
            this.FailedBugListView.UseCompatibleStateImageBehavior = false;
            this.FailedBugListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.FailedBugListView_ItemSelectionChanged);
            this.FailedBugListView.SelectedIndexChanged += new System.EventHandler(this.FailedBugListView_SelectedIndexChanged);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Location = new System.Drawing.Point(977, 526);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(75, 23);
            this.SettingsButton.TabIndex = 27;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tasks completed";
            // 
            // MarkButton
            // 
            this.MarkButton.BackColor = System.Drawing.SystemColors.Control;
            this.MarkButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarkButton.Location = new System.Drawing.Point(16, 211);
            this.MarkButton.Name = "MarkButton";
            this.MarkButton.Size = new System.Drawing.Size(142, 37);
            this.MarkButton.TabIndex = 25;
            this.MarkButton.Text = "Mark as finished";
            this.MarkButton.UseVisualStyleBackColor = false;
            this.MarkButton.Click += new System.EventHandler(this.MarkButton_Click);
            // 
            // finishedBugListView
            // 
            this.finishedBugListView.FullRowSelect = true;
            this.finishedBugListView.GridLines = true;
            this.finishedBugListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.finishedBugListView.HideSelection = false;
            this.finishedBugListView.Location = new System.Drawing.Point(213, 498);
            this.finishedBugListView.Name = "finishedBugListView";
            this.finishedBugListView.Size = new System.Drawing.Size(283, 97);
            this.finishedBugListView.TabIndex = 24;
            this.finishedBugListView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(938, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 23;
            // 
            // CurrentTimeLabel
            // 
            this.CurrentTimeLabel.AutoSize = true;
            this.CurrentTimeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTimeLabel.Location = new System.Drawing.Point(833, 13);
            this.CurrentTimeLabel.Name = "CurrentTimeLabel";
            this.CurrentTimeLabel.Size = new System.Drawing.Size(111, 21);
            this.CurrentTimeLabel.TabIndex = 22;
            this.CurrentTimeLabel.Text = "Current date - ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "List of tasks";
            // 
            // BugListView
            // 
            this.BugListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.BugListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BugListView.FullRowSelect = true;
            this.BugListView.GridLines = true;
            this.BugListView.HideSelection = false;
            this.BugListView.Location = new System.Drawing.Point(213, 76);
            this.BugListView.Name = "BugListView";
            this.BugListView.Size = new System.Drawing.Size(603, 346);
            this.BugListView.TabIndex = 20;
            this.BugListView.UseCompatibleStateImageBehavior = false;
            this.BugListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.BugListView_ColumnClick);
            this.BugListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BugListView_MouseClick);
            // 
            // DeleteBugButton
            // 
            this.DeleteBugButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBugButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBugButton.Location = new System.Drawing.Point(38, 159);
            this.DeleteBugButton.Name = "DeleteBugButton";
            this.DeleteBugButton.Size = new System.Drawing.Size(95, 35);
            this.DeleteBugButton.TabIndex = 19;
            this.DeleteBugButton.Text = "Delete";
            this.DeleteBugButton.UseVisualStyleBackColor = false;
            this.DeleteBugButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EditBugButton
            // 
            this.EditBugButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EditBugButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBugButton.Location = new System.Drawing.Point(38, 118);
            this.EditBugButton.Name = "EditBugButton";
            this.EditBugButton.Size = new System.Drawing.Size(95, 35);
            this.EditBugButton.TabIndex = 18;
            this.EditBugButton.Text = "Edit";
            this.EditBugButton.UseVisualStyleBackColor = false;
            this.EditBugButton.Click += new System.EventHandler(this.EditBugButton_Click);
            // 
            // AddBugButton
            // 
            this.AddBugButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddBugButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBugButton.Location = new System.Drawing.Point(38, 76);
            this.AddBugButton.Name = "AddBugButton";
            this.AddBugButton.Size = new System.Drawing.Size(95, 35);
            this.AddBugButton.TabIndex = 17;
            this.AddBugButton.Text = "Add";
            this.AddBugButton.UseVisualStyleBackColor = false;
            this.AddBugButton.Click += new System.EventHandler(this.AddBugButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Mark as finished";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.MarkButton_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Edit";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.EditBugButton_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "Delete";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(958, 552);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "(Disabled in demo)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(160, 26);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem6.Text = "Quit application";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Tracker is running in the background";
            this.notifyIcon1.BalloonTipTitle = "TaskTracker";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Task Tracker";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // DemoViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 639);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MoveTasksButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FailedBugListView);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MarkButton);
            this.Controls.Add(this.finishedBugListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CurrentTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BugListView);
            this.Controls.Add(this.DeleteBugButton);
            this.Controls.Add(this.EditBugButton);
            this.Controls.Add(this.AddBugButton);
            this.Name = "DemoViewerForm";
            this.Text = "DemoViewerForm";
            this.SizeChanged += new System.EventHandler(this.TrackerViewerForm_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MoveTasksButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView FailedBugListView;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MarkButton;
        private System.Windows.Forms.ListView finishedBugListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label CurrentTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView BugListView;
        private System.Windows.Forms.Button DeleteBugButton;
        private System.Windows.Forms.Button EditBugButton;
        private System.Windows.Forms.Button AddBugButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}