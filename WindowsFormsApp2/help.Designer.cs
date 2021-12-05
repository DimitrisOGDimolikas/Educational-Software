namespace WindowsFormsApp2
{
    partial class help
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
            this.helpTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helpTxt
            // 
            this.helpTxt.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.helpTxt.BackColor = System.Drawing.Color.Honeydew;
            this.helpTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpTxt.Location = new System.Drawing.Point(70, 43);
            this.helpTxt.Name = "helpTxt";
            this.helpTxt.ReadOnly = true;
            this.helpTxt.Size = new System.Drawing.Size(640, 550);
            this.helpTxt.TabIndex = 1;
            this.helpTxt.Text = "";
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.helpTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "help";
            this.ShowIcon = false;
            this.Text = "Μαθηματική Εφαρμογή - Βοήθεια";
            this.Load += new System.EventHandler(this.help_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpTxt;
    }
}