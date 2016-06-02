namespace OpTeamUI.ProjectView.Src
{
    partial class ProjectView
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
            this.LoggedAsLabel = new System.Windows.Forms.Label();
            this.AssignedTo = new System.Windows.Forms.Label();
            this.LoggedAsUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoggedAsLabel
            // 
            this.LoggedAsLabel.AutoSize = true;
            this.LoggedAsLabel.Location = new System.Drawing.Point(12, 9);
            this.LoggedAsLabel.Name = "LoggedAsLabel";
            this.LoggedAsLabel.Size = new System.Drawing.Size(60, 13);
            this.LoggedAsLabel.TabIndex = 0;
            this.LoggedAsLabel.Text = "Logged as:";
            this.LoggedAsLabel.Click += new System.EventHandler(this.LoggedAs_Click);
            // 
            // AssignedTo
            // 
            this.AssignedTo.AutoSize = true;
            this.AssignedTo.Location = new System.Drawing.Point(383, 9);
            this.AssignedTo.Name = "AssignedTo";
            this.AssignedTo.Size = new System.Drawing.Size(65, 13);
            this.AssignedTo.TabIndex = 1;
            this.AssignedTo.Text = "Assigned to:";
            // 
            // LoggedAsUser
            // 
            this.LoggedAsUser.AutoSize = true;
            this.LoggedAsUser.Location = new System.Drawing.Point(78, 9);
            this.LoggedAsUser.Name = "LoggedAsUser";
            this.LoggedAsUser.Size = new System.Drawing.Size(0, 13);
            this.LoggedAsUser.TabIndex = 2;
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 498);
            this.Controls.Add(this.LoggedAsUser);
            this.Controls.Add(this.AssignedTo);
            this.Controls.Add(this.LoggedAsLabel);
            this.Name = "ProjectView";
            this.Text = "ProjectView";
            this.Load += new System.EventHandler(this.ProjectView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoggedAsLabel;
        private System.Windows.Forms.Label AssignedTo;
        private System.Windows.Forms.Label LoggedAsUser;
    }
}