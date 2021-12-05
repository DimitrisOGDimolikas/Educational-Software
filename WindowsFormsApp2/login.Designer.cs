namespace WindowsFormsApp2
{
    partial class login
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.secondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.helpHome = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(146, 80);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(150, 20);
            this.firstName.TabIndex = 0;
            // 
            // secondName
            // 
            this.secondName.Location = new System.Drawing.Point(146, 146);
            this.secondName.Name = "secondName";
            this.secondName.Size = new System.Drawing.Size(150, 20);
            this.secondName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Όνομα:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(69, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Επώνυμο:\r\n";
            // 
            // connect
            // 
            this.connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.connect.Location = new System.Drawing.Point(206, 228);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(90, 40);
            this.connect.TabIndex = 4;
            this.connect.Text = "Σύνδεση";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.connect);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.firstName);
            this.panel1.Controls.Add(this.secondName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(200, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 360);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(30, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Εισάγετε τα στοιχεία σας για να ξεκινήσετε\r\n";
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exit.Location = new System.Drawing.Point(72, 228);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 40);
            this.exit.TabIndex = 6;
            this.exit.Text = "Έξοδος";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // helpHome
            // 
            this.helpHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.helpHome.Location = new System.Drawing.Point(702, 12);
            this.helpHome.Name = "helpHome";
            this.helpHome.Size = new System.Drawing.Size(70, 30);
            this.helpHome.TabIndex = 7;
            this.helpHome.Text = "Βοήθεια";
            this.helpHome.UseVisualStyleBackColor = true;
            this.helpHome.Click += new System.EventHandler(this.helpHome_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(90, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(593, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Καλωσήρθατε στην εφαρμογή εκμάθησης Μαθηματικών";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.helpHome);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.ShowIcon = false;
            this.Text = "Μαθηματική Εφαρμογή - Καλωσήρθατε!";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox secondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button helpHome;
        private System.Windows.Forms.Label label4;
    }
}

