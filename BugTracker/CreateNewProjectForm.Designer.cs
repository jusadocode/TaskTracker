
namespace TaskTracker
{
    partial class CreateNewProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewProjectForm));
            this.NewProjectNameLabel = new System.Windows.Forms.Label();
            this.NewProjectNameBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewProjectNameLabel
            // 
            this.NewProjectNameLabel.AutoSize = true;
            this.NewProjectNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewProjectNameLabel.Location = new System.Drawing.Point(131, 84);
            this.NewProjectNameLabel.Name = "NewProjectNameLabel";
            this.NewProjectNameLabel.Size = new System.Drawing.Size(246, 25);
            this.NewProjectNameLabel.TabIndex = 0;
            this.NewProjectNameLabel.Text = "Name of the project/activity";
            // 
            // NewProjectNameBox
            // 
            this.NewProjectNameBox.Location = new System.Drawing.Point(196, 133);
            this.NewProjectNameBox.Name = "NewProjectNameBox";
            this.NewProjectNameBox.Size = new System.Drawing.Size(100, 20);
            this.NewProjectNameBox.TabIndex = 1;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(181, 176);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(128, 51);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateNewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 308);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.NewProjectNameBox);
            this.Controls.Add(this.NewProjectNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewProjectForm";
            this.Text = "CreateNewProjectForm";
            this.SizeChanged += new System.EventHandler(this.CreateNewProjectForm_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewProjectNameLabel;
        private System.Windows.Forms.TextBox NewProjectNameBox;
        private System.Windows.Forms.Button CreateButton;
    }
}