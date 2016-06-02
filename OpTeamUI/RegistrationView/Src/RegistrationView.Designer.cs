namespace OpTeamUI.RegistrationView
{
    partial class RegistrationView
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.DirectorButton = new System.Windows.Forms.RadioButton();
            this.ManagerButton = new System.Windows.Forms.RadioButton();
            this.EngineerButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 227);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Surname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 262);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "e-mail";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(99, 359);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(100, 23);
            this.SubmitButton.TabIndex = 11;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            // 
            // DirectorButton
            // 
            this.DirectorButton.AutoSize = true;
            this.DirectorButton.Location = new System.Drawing.Point(99, 288);
            this.DirectorButton.Name = "DirectorButton";
            this.DirectorButton.Size = new System.Drawing.Size(62, 17);
            this.DirectorButton.TabIndex = 12;
            this.DirectorButton.TabStop = true;
            this.DirectorButton.Text = "Director";
            this.DirectorButton.UseVisualStyleBackColor = true;
            this.DirectorButton.CheckedChanged += new System.EventHandler(this.DirectorButton_CheckedChanged);
            // 
            // ManagerButton
            // 
            this.ManagerButton.AutoSize = true;
            this.ManagerButton.Location = new System.Drawing.Point(99, 311);
            this.ManagerButton.Name = "ManagerButton";
            this.ManagerButton.Size = new System.Drawing.Size(98, 17);
            this.ManagerButton.TabIndex = 13;
            this.ManagerButton.TabStop = true;
            this.ManagerButton.Text = "ManagerButton";
            this.ManagerButton.UseVisualStyleBackColor = true;
            // 
            // EngineerButton
            // 
            this.EngineerButton.AutoSize = true;
            this.EngineerButton.Location = new System.Drawing.Point(99, 334);
            this.EngineerButton.Name = "EngineerButton";
            this.EngineerButton.Size = new System.Drawing.Size(98, 17);
            this.EngineerButton.TabIndex = 14;
            this.EngineerButton.TabStop = true;
            this.EngineerButton.Text = "EngineerButton";
            this.EngineerButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 423);
            this.Controls.Add(this.EngineerButton);
            this.Controls.Add(this.ManagerButton);
            this.Controls.Add(this.DirectorButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Name = "RegistrationView";
            this.Text = "RegistrationView";
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.SubmitButton, 0);
            this.Controls.SetChildIndex(this.DirectorButton, 0);
            this.Controls.SetChildIndex(this.ManagerButton, 0);
            this.Controls.SetChildIndex(this.EngineerButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.RadioButton DirectorButton;
        private System.Windows.Forms.RadioButton ManagerButton;
        private System.Windows.Forms.RadioButton EngineerButton;
    }
}