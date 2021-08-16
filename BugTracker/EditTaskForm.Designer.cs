
namespace TaskTracker
{
    partial class EditTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTaskForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.priorComboBox = new System.Windows.Forms.ComboBox();
            this.diffComboBox = new System.Windows.Forms.ComboBox();
            this.deadlinePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.AdvancedTimeBox = new System.Windows.Forms.GroupBox();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.HourLabel = new System.Windows.Forms.Label();
            this.SpecificTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.AdvancedTimeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deadline";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Priority";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Difficulty";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(43, 55);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 20);
            this.titleTextBox.TabIndex = 4;
            this.titleTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // priorComboBox
            // 
            this.priorComboBox.FormattingEnabled = true;
            this.priorComboBox.Location = new System.Drawing.Point(416, 55);
            this.priorComboBox.Name = "priorComboBox";
            this.priorComboBox.Size = new System.Drawing.Size(57, 21);
            this.priorComboBox.TabIndex = 5;
            // 
            // diffComboBox
            // 
            this.diffComboBox.FormattingEnabled = true;
            this.diffComboBox.Location = new System.Drawing.Point(507, 56);
            this.diffComboBox.Name = "diffComboBox";
            this.diffComboBox.Size = new System.Drawing.Size(68, 21);
            this.diffComboBox.TabIndex = 6;
            // 
            // deadlinePicker
            // 
            this.deadlinePicker.Location = new System.Drawing.Point(177, 55);
            this.deadlinePicker.Name = "deadlinePicker";
            this.deadlinePicker.Size = new System.Drawing.Size(200, 20);
            this.deadlinePicker.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdvancedTimeBox
            // 
            this.AdvancedTimeBox.Controls.Add(this.minuteLabel);
            this.AdvancedTimeBox.Controls.Add(this.label5);
            this.AdvancedTimeBox.Controls.Add(this.hourTextBox);
            this.AdvancedTimeBox.Controls.Add(this.minuteTextBox);
            this.AdvancedTimeBox.Controls.Add(this.HourLabel);
            this.AdvancedTimeBox.Location = new System.Drawing.Point(218, 104);
            this.AdvancedTimeBox.Name = "AdvancedTimeBox";
            this.AdvancedTimeBox.Size = new System.Drawing.Size(141, 69);
            this.AdvancedTimeBox.TabIndex = 22;
            this.AdvancedTimeBox.TabStop = false;
            this.AdvancedTimeBox.Visible = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
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
            // SpecificTimeCheckBox
            // 
            this.SpecificTimeCheckBox.AutoSize = true;
            this.SpecificTimeCheckBox.Location = new System.Drawing.Point(177, 81);
            this.SpecificTimeCheckBox.Name = "SpecificTimeCheckBox";
            this.SpecificTimeCheckBox.Size = new System.Drawing.Size(75, 17);
            this.SpecificTimeCheckBox.TabIndex = 21;
            this.SpecificTimeCheckBox.Text = "Advanced";
            this.SpecificTimeCheckBox.UseVisualStyleBackColor = true;
            this.SpecificTimeCheckBox.CheckedChanged += new System.EventHandler(this.SpecificTimeCheckBox_CheckedChanged_1);
            // 
            // EditTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 303);
            this.Controls.Add(this.AdvancedTimeBox);
            this.Controls.Add(this.SpecificTimeCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deadlinePicker);
            this.Controls.Add(this.diffComboBox);
            this.Controls.Add(this.priorComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTaskForm";
            this.Text = "EditTaskForm";
            this.SizeChanged += new System.EventHandler(this.EditTaskForm_SizeChanged);
            this.AdvancedTimeBox.ResumeLayout(false);
            this.AdvancedTimeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox priorComboBox;
        private System.Windows.Forms.ComboBox diffComboBox;
        private System.Windows.Forms.DateTimePicker deadlinePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox AdvancedTimeBox;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.Label HourLabel;
        private System.Windows.Forms.CheckBox SpecificTimeCheckBox;
    }
}