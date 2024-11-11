namespace GrabICO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.processStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processStart
            // 
            this.processStart.BackColor = System.Drawing.Color.AliceBlue;
            this.processStart.Location = new System.Drawing.Point(60, 46);
            this.processStart.Name = "processStart";
            this.processStart.Size = new System.Drawing.Size(162, 174);
            this.processStart.TabIndex = 0;
            this.processStart.Text = "Start Process";
            this.processStart.UseVisualStyleBackColor = false;
            this.processStart.Click += new System.EventHandler(this.processStart_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(285, 273);
            this.Controls.Add(this.processStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Watches ~ ICO GRABBER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button processStart;
    }
}

