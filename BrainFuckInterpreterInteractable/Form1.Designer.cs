namespace BrainFuckInterpreterInteractable
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
            this.input = new System.Windows.Forms.TextBox();
            this.console = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 13);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(500, 250);
            this.input.TabIndex = 0;
            // 
            // console
            // 
            this.console.FormattingEnabled = true;
            this.console.Location = new System.Drawing.Point(13, 326);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(500, 160);
            this.console.TabIndex = 1;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 270);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(500, 50);
            this.start.TabIndex = 2;
            this.start.Text = "Run";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 528);
            this.Controls.Add(this.start);
            this.Controls.Add(this.console);
            this.Controls.Add(this.input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BrainFuck Interpreter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.ListBox console;
        private System.Windows.Forms.Button start;
    }
}

