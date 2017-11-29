namespace LessConnect
{
    partial class Password
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
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.okaybutton = new System.Windows.Forms.Button();
            this.canclebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(13, 13);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(387, 20);
            this.passwordbox.TabIndex = 0;
            this.passwordbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // okaybutton
            // 
            this.okaybutton.Location = new System.Drawing.Point(12, 52);
            this.okaybutton.Name = "okaybutton";
            this.okaybutton.Size = new System.Drawing.Size(162, 23);
            this.okaybutton.TabIndex = 1;
            this.okaybutton.Text = "Okay";
            this.okaybutton.UseVisualStyleBackColor = true;
            this.okaybutton.Click += new System.EventHandler(this.okaybutton_Click);
            // 
            // canclebutton
            // 
            this.canclebutton.Location = new System.Drawing.Point(238, 52);
            this.canclebutton.Name = "canclebutton";
            this.canclebutton.Size = new System.Drawing.Size(162, 23);
            this.canclebutton.TabIndex = 2;
            this.canclebutton.Text = "Cancel";
            this.canclebutton.UseVisualStyleBackColor = true;
            this.canclebutton.Click += new System.EventHandler(this.canclebutton_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 103);
            this.Controls.Add(this.canclebutton);
            this.Controls.Add(this.okaybutton);
            this.Controls.Add(this.passwordbox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(428, 142);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(428, 142);
            this.Name = "Password";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LessConnect : Enter Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button okaybutton;
        private System.Windows.Forms.Button canclebutton;
    }
}