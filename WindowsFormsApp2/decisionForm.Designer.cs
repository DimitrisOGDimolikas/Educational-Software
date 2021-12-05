namespace WindowsFormsApp2
{
    partial class decision
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
            this.lessonButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.statsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.helpHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonButton
            // 
            this.lessonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lessonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lessonButton.Location = new System.Drawing.Point(64, 62);
            this.lessonButton.Name = "lessonButton";
            this.lessonButton.Size = new System.Drawing.Size(160, 40);
            this.lessonButton.TabIndex = 0;
            this.lessonButton.Text = "Θεωρία";
            this.lessonButton.UseVisualStyleBackColor = true;
            this.lessonButton.Click += new System.EventHandler(this.lessonButton_Click);
            // 
            // testButton
            // 
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.testButton.Location = new System.Drawing.Point(64, 143);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(160, 40);
            this.testButton.TabIndex = 1;
            this.testButton.Text = "Διαγωνίσματα";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // statsButton
            // 
            this.statsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.statsButton.Location = new System.Drawing.Point(64, 222);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(160, 40);
            this.statsButton.TabIndex = 2;
            this.statsButton.Text = "Στατιστικά";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Επιλέξτε πού θέλετε να συνεχίσετε";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(230, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Εδώ μπορείτε να διαβάσετε την ύλη που δίνεται";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(230, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Εδώ μπορείτε να αξιολογήσετε τις γνώσεις σας";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(230, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Εδώ μπορείτε να δείτε την συνολική σας επίδοση";
            // 
            // helpHome
            // 
            this.helpHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.helpHome.Location = new System.Drawing.Point(702, 12);
            this.helpHome.Name = "helpHome";
            this.helpHome.Size = new System.Drawing.Size(70, 30);
            this.helpHome.TabIndex = 8;
            this.helpHome.Text = "Βοήθεια";
            this.helpHome.UseVisualStyleBackColor = true;
            this.helpHome.Click += new System.EventHandler(this.helpHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.statsButton);
            this.panel1.Controls.Add(this.testButton);
            this.panel1.Controls.Add(this.lessonButton);
            this.panel1.Location = new System.Drawing.Point(14, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 322);
            this.panel1.TabIndex = 9;
            // 
            // decision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpHome);
            this.Name = "decision";
            this.ShowIcon = false;
            this.Text = "Μαθηματική Εφαρμογή - Επιλογή Ενέργειας";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lessonButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button helpHome;
        private System.Windows.Forms.Panel panel1;
    }
}