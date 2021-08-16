
namespace TaskTracker
{
    partial class CreateNewTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTaskForm));
            this.BugTitleLabel = new System.Windows.Forms.Label();
            this.BugTitleText = new System.Windows.Forms.RichTextBox();
            this.DeadlineLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateBugButton = new System.Windows.Forms.Button();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.DifficultyBox = new System.Windows.Forms.ComboBox();
            this.PriotityComboBox = new System.Windows.Forms.ComboBox();
            this.DeadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.SpecificTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvancedTimeBox = new System.Windows.Forms.GroupBox();
            this.AdvancedTimeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BugTitleLabel
            // 
            this.BugTitleLabel.AutoSize = true;
            this.BugTitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.BugTitleLabel.Location = new System.Drawing.Point(30, 71);
            this.BugTitleLabel.Name = "BugTitleLabel";
            this.BugTitleLabel.Size = new System.Drawing.Size(81, 45);
            this.BugTitleLabel.TabIndex = 1;
            this.BugTitleLabel.Text = "Title";
            // 
            // BugTitleText
            // 
            this.BugTitleText.Location = new System.Drawing.Point(182, 90);
            this.BugTitleText.Name = "BugTitleText";
            this.BugTitleText.Size = new System.Drawing.Size(121, 26);
            this.BugTitleText.TabIndex = 2;
            this.BugTitleText.Text = "";
            // 
            // DeadlineLabel
            // 
            this.DeadlineLabel.AutoSize = true;
            this.DeadlineLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.DeadlineLabel.Location = new System.Drawing.Point(340, 55);
            this.DeadlineLabel.Name = "DeadlineLabel";
            this.DeadlineLabel.Size = new System.Drawing.Size(145, 45);
            this.DeadlineLabel.TabIndex = 3;
            this.DeadlineLabel.Text = "Deadline";
            this.DeadlineLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 45);
            this.label2.TabIndex = 5;
            this.label2.Text = "Priority";
            // 
            // CreateBugButton
            // 
            this.CreateBugButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateBugButton.Location = new System.Drawing.Point(253, 303);
            this.CreateBugButton.Name = "CreateBugButton";
            this.CreateBugButton.Size = new System.Drawing.Size(153, 53);
            this.CreateBugButton.TabIndex = 9;
            this.CreateBugButton.Text = "Create task";
            this.CreateBugButton.UseVisualStyleBackColor = false;
            this.CreateBugButton.Click += new System.EventHandler(this.CreateBugButton_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.DifficultyLabel.Location = new System.Drawing.Point(30, 188);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(145, 45);
            this.DifficultyLabel.TabIndex = 10;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // DifficultyBox
            // 
            this.DifficultyBox.FormattingEnabled = true;
            this.DifficultyBox.Location = new System.Drawing.Point(182, 210);
            this.DifficultyBox.Name = "DifficultyBox";
            this.DifficultyBox.Size = new System.Drawing.Size(121, 21);
            this.DifficultyBox.TabIndex = 11;
            // 
            // PriotityComboBox
            // 
            this.PriotityComboBox.FormattingEnabled = true;
            this.PriotityComboBox.Location = new System.Drawing.Point(182, 146);
            this.PriotityComboBox.Name = "PriotityComboBox";
            this.PriotityComboBox.Size = new System.Drawing.Size(121, 21);
            this.PriotityComboBox.TabIndex = 12;
            // 
            // DeadlinePicker
            // 
            this.DeadlinePicker.Location = new System.Drawing.Point(348, 112);
            this.DeadlinePicker.Name = "DeadlinePicker";
            this.DeadlinePicker.Size = new System.Drawing.Size(200, 20);
            this.DeadlinePicker.TabIndex = 13;
            // 
            // SpecificTimeCheckBox
            // 
            this.SpecificTimeCheckBox.AutoSize = true;
            this.SpecificTimeCheckBox.Location = new System.Drawing.Point(348, 139);
            this.SpecificTimeCheckBox.Name = "SpecificTimeCheckBox";
            this.SpecificTimeCheckBox.Size = new System.Drawing.Size(75, 17);
            this.SpecificTimeCheckBox.TabIndex = 14;
            this.SpecificTimeCheckBox.Text = "Advanced";
            this.SpecificTimeCheckBox.UseVisualStyleBackColor = true;
            this.SpecificTimeCheckBox.CheckedChanged += new System.EventHandler(this.SpecificTimeCheckBox_CheckedChanged);
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(26, 36);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(28, 20);
            this.hourTextBox.TabIndex = 15;
            this.hourTextBox.Text = "00";
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(76, 36);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(28, 20);
            this.minuteTextBox.TabIndex = 16;
            this.minuteTextBox.Text = "00";
            // 
            // HourLabel
            // 
            this.HourLabel.AutoSize = true;
            this.HourLabel.Location = new System.Drawing.Point(23, 16);
            this.HourLabel.Name = "HourLabel";
            this.HourLabel.Size = new System.Drawing.Size(35, 13);
            this.HourLabel.TabIndex = 17;
            this.HourLabel.Text = "Hours";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(73, 16);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(44, 13);
            this.minuteLabel.TabIndex = 18;
            this.minuteLabel.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // AdvancedTimeBox
            // 
            this.AdvancedTimeBox.Controls.Add(this.minuteLabel);
            this.AdvancedTimeBox.Controls.Add(this.label1);
            this.AdvancedTimeBox.Controls.Add(this.hourTextBox);
            this.AdvancedTimeBox.Controls.Add(this.minuteTextBox);
            this.AdvancedTimeBox.Controls.Add(this.HourLabel);
            this.AdvancedTimeBox.Location = new System.Drawing.Point(389, 162);
            this.AdvancedTimeBox.Name = "AdvancedTimeBox";
            this.AdvancedTimeBox.Size = new System.Drawing.Size(141, 69);
            this.AdvancedTimeBox.TabIndex = 20;
            this.AdvancedTimeBox.TabStop = false;
            this.AdvancedTimeBox.Visible = false;
            // 
            // CreateNewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 403);
            this.Controls.Add(this.AdvancedTimeBox);
            this.Controls.Add(this.SpecificTimeCheckBox);
            this.Controls.Add(this.DeadlinePicker);
            this.Controls.Add(this.PriotityComboBox);
            this.Controls.Add(this.DifficultyBox);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.CreateBugButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeadlineLabel);
            this.Controls.Add(this.BugTitleText);
            this.Controls.Add(this.BugTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewTaskForm";
            this.Text = "CreateNewBugForm";
            this.SizeChanged += new System.EventHandler(this.CreateNewTaskForm_SizeChanged);
            this.AdvancedTimeBox.ResumeLayout(false);
            this.AdvancedTimeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BugTitleLabel;
        private System.Windows.Forms.RichTextBox BugTitleText;
        private System.Windows.Forms.Label DeadlineLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateBugButton;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.ComboBox DifficultyBox;
        private System.Windows.Forms.ComboBox PriotityComboBox;
        private System.Windows.Forms.DateTimePicker DeadlinePicker;
        private System.Windows.Forms.CheckBox SpecificTimeCheckBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox AdvancedTimeBox;
    }
}