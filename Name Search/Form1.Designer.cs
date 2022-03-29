namespace Name_Search
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
            this.girlLabel = new System.Windows.Forms.Label();
            this.boyLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.girlTextBox = new System.Windows.Forms.TextBox();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // girlLabel
            // 
            this.girlLabel.AutoSize = true;
            this.girlLabel.Location = new System.Drawing.Point(9, 45);
            this.girlLabel.Name = "girlLabel";
            this.girlLabel.Size = new System.Drawing.Size(115, 13);
            this.girlLabel.TabIndex = 0;
            this.girlLabel.Text = "Search for a Girl name:";
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.Location = new System.Drawing.Point(9, 80);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(118, 13);
            this.boyLabel.TabIndex = 1;
            this.boyLabel.Text = "Search for a Boy name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(40, 9);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(213, 13);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "Top 200 Boys and Girls Names (2000-2009)";
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Location = new System.Drawing.Point(64, 115);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(75, 39);
            this.nameSearchButton.TabIndex = 3;
            this.nameSearchButton.Text = "Search";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 115);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // girlTextBox
            // 
            this.girlTextBox.Location = new System.Drawing.Point(130, 42);
            this.girlTextBox.Name = "girlTextBox";
            this.girlTextBox.Size = new System.Drawing.Size(141, 20);
            this.girlTextBox.TabIndex = 5;
            // 
            // boyTextBox
            // 
            this.boyTextBox.Location = new System.Drawing.Point(130, 77);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(141, 20);
            this.boyTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 168);
            this.Controls.Add(this.boyTextBox);
            this.Controls.Add(this.girlTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.boyLabel);
            this.Controls.Add(this.girlLabel);
            this.Name = "Form1";
            this.Text = "Name Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girlLabel;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button nameSearchButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox girlTextBox;
        private System.Windows.Forms.TextBox boyTextBox;
    }
}

