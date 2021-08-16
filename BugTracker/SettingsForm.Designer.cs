
namespace TaskTracker
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.EmailCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursTextBox = new System.Windows.Forms.TextBox();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.TimeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.AlertGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AlertGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailCheckBox
            // 
            this.EmailCheckBox.AutoSize = true;
            this.EmailCheckBox.Location = new System.Drawing.Point(36, 48);
            this.EmailCheckBox.Name = "EmailCheckBox";
            this.EmailCheckBox.Size = new System.Drawing.Size(187, 17);
            this.EmailCheckBox.TabIndex = 0;
            this.EmailCheckBox.Text = "Alert me about incoming deadlines";
            this.EmailCheckBox.UseVisualStyleBackColor = true;
            this.EmailCheckBox.CheckedChanged += new System.EventHandler(this.EmailCheckBox_CheckedChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveButton.Location = new System.Drawing.Point(450, 293);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(8, 37);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(541, 13);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.Text = "You will be alerted about incoming deadlines when there is specified time left to" +
    " complete your tasks/assignments.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alert time:";
            // 
            // HoursTextBox
            // 
            this.HoursTextBox.Location = new System.Drawing.Point(184, 54);
            this.HoursTextBox.Name = "HoursTextBox";
            this.HoursTextBox.Size = new System.Drawing.Size(27, 20);
            this.HoursTextBox.TabIndex = 4;
            this.HoursTextBox.Text = "00";
            this.HoursTextBox.Visible = false;
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(151, 54);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(27, 20);
            this.DaysTextBox.TabIndex = 5;
            this.DaysTextBox.Text = "00";
            this.DaysTextBox.Visible = false;
            // 
            // TimeCheckedListBox
            // 
            this.TimeCheckedListBox.CheckOnClick = true;
            this.TimeCheckedListBox.FormattingEnabled = true;
            this.TimeCheckedListBox.Items.AddRange(new object[] {
            "Days",
            "Hours",
            "Minutes"});
            this.TimeCheckedListBox.Location = new System.Drawing.Point(67, 54);
            this.TimeCheckedListBox.Name = "TimeCheckedListBox";
            this.TimeCheckedListBox.Size = new System.Drawing.Size(66, 49);
            this.TimeCheckedListBox.TabIndex = 6;
            this.TimeCheckedListBox.SelectedValueChanged += new System.EventHandler(this.TimeCheckedListBox_SelectedValueChanged);
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(217, 54);
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(27, 20);
            this.MinutesTextBox.TabIndex = 7;
            this.MinutesTextBox.Text = "00";
            this.MinutesTextBox.Visible = false;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(8, 106);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(144, 13);
            this.EmailLabel.TabIndex = 8;
            this.EmailLabel.Text = "Email address to send alerts: ";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(151, 103);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(134, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // AlertGroupBox
            // 
            this.AlertGroupBox.Controls.Add(this.InfoLabel);
            this.AlertGroupBox.Controls.Add(this.EmailTextBox);
            this.AlertGroupBox.Controls.Add(this.label1);
            this.AlertGroupBox.Controls.Add(this.EmailLabel);
            this.AlertGroupBox.Controls.Add(this.HoursTextBox);
            this.AlertGroupBox.Controls.Add(this.MinutesTextBox);
            this.AlertGroupBox.Controls.Add(this.DaysTextBox);
            this.AlertGroupBox.Controls.Add(this.TimeCheckedListBox);
            this.AlertGroupBox.Location = new System.Drawing.Point(36, 71);
            this.AlertGroupBox.Name = "AlertGroupBox";
            this.AlertGroupBox.Size = new System.Drawing.Size(549, 134);
            this.AlertGroupBox.TabIndex = 10;
            this.AlertGroupBox.TabStop = false;
            this.AlertGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "(Changes will be made after you restart the application)";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 360);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AlertGroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.EmailCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.SizeChanged += new System.EventHandler(this.SettingsForm_SizeChanged);
            this.AlertGroupBox.ResumeLayout(false);
            this.AlertGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox EmailCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HoursTextBox;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.CheckedListBox TimeCheckedListBox;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.GroupBox AlertGroupBox;
        private System.Windows.Forms.Label label2;
    }
}